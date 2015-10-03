namespace _13_14.TransformXMLIntoHTML
{
    using System;
    using System.Xml.Xsl;

    public static class TransformXMLIntoHTML
    {
        public static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xslt");
            xslt.Transform("../../catalog.xml", "../../catalog.html");

            Console.WriteLine("An HTML file has been generated.");
        }
    }
}