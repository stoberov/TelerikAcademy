namespace SubstringStringBuilder
{
    using System;
    using System.Text;
    
    internal static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex, int length)
        {
            StringBuilder substring = new StringBuilder(stringBuilder.ToString().Substring(startIndex, length));
            return substring;
        }

        public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex)
        {
            StringBuilder substring = new StringBuilder(stringBuilder.ToString().Substring(startIndex));
            return substring;
        }
    }
}