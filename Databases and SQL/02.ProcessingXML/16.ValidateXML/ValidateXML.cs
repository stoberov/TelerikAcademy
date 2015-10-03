namespace _16.ValidateXML
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public static class ValidateXML
    {
        public static void Main()
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../catalog.xsd");

            XDocument correctDoc = XDocument.Load("../../catalog.xml");
            XDocument invalidDoc = XDocument.Load("../../catalogWithMistakes.xml");

            ValidateXml(schema, correctDoc);
            ValidateXml(schema, invalidDoc);
        }

        private static void ValidateXml(XmlSchemaSet schema, XDocument docToBeValidated)
        {
            bool hasError = false;

            docToBeValidated.Validate(schema, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                hasError = true;
            });

            Console.WriteLine("XML document {0}", hasError ? "is invalid" : "valid");
            Console.WriteLine();
        }
    }
}