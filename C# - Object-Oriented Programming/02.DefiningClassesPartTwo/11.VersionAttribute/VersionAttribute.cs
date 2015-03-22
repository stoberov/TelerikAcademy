namespace AttributeDemo
{
    using System;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface |
        AttributeTargets.Method | AttributeTargets.Struct)]
    
    public class VersionAttribute : Attribute
    {
        private readonly int major;
        private readonly int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public string GetVersion
        {
            get
            {
                return this.major + "." + this.minor;
            }
        }
    }
}