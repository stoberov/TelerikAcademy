namespace IEnumarambleTools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    internal static class IEnumarableExtensions
    {
        public static T CustomSum<T>(this IEnumerable<T> source)
        {
            T resulut = source.FunctionOverElements((m, n) => m + n);
            return resulut;
        }

        public static T CustomProduct<T>(this IEnumerable<T> source)
        {
            T result = source.FunctionOverElements((m, n) => m * n);
            return result;
        }

        public static T CustomMin<T>(this IEnumerable<T> source)
        {
            T result = source.FunctionOverElements((m, n) => m < n ? m : n);
            return result;
        }

        public static T CustomMax<T>(this IEnumerable<T> source)
        {
            T result = source.FunctionOverElements((m, n) => m > n ? m : n);
            return result;
        }

        public static double CustomAverage<T>(this IEnumerable<T> source)
        {
            double result = (dynamic)source.CustomSum() / source.Count();
            return result;
        }

        private static T FunctionOverElements<T>(this IEnumerable<T> source, Func<dynamic, T, T> func)
        {
            IEnumerator<T> enumerator = source.GetEnumerator();
            enumerator.MoveNext();
            T first = enumerator.Current;
            T operation = first;
            while (enumerator.MoveNext())
            {
                operation = func(enumerator.Current, operation);
            }

            return operation;
        }
    }
}