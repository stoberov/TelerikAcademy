namespace AttributeDemo
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    [Version(1, 2)]
    public class AttributeDemo
    {
        [Version(10, 12)]
        public static void Main(string[] args)
        {
            MemberInfo member = typeof(AttributeDemo);
            Console.WriteLine("Information for class: {0}", member.Name);

            foreach (Attribute attribute in member.GetCustomAttributes())
            {
                PrintVersionAttributeInfo(attribute);
            }

            MethodInfo[] methods = typeof(AttributeDemo).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public | BindingFlags.Static);

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method name : {0}", method.Name);

                foreach (Attribute attribute in method.GetCustomAttributes())
                {
                    PrintVersionAttributeInfo(attribute);
                }
            }
        }

        private static void PrintVersionAttributeInfo(Attribute attribute)
        {
            if (attribute is VersionAttribute)
            {
                VersionAttribute version = (VersionAttribute)attribute;
                Console.WriteLine("Version: {0}", version.GetVersion);
            }
        }

        [Version(10, 13)]
        private void Test()
        {
        }

        [Version(10, 14)]
        private void Test1()
        {
        }
    }
}