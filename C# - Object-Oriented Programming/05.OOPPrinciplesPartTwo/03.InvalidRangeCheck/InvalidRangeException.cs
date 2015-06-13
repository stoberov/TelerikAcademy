namespace InvalidRangeCheck
{
    using System;
    using System.Linq;
    
    [Serializable]
    public class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {
            this.MinValue = start;
            this.MaxValue = end;
        }

        public InvalidRangeException(string message, T start, T end, Exception inner)
            : base(message)
        {
            this.MinValue = start;
            this.MaxValue = end;
        }

        protected InvalidRangeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        public T MinValue { get; private set; }

        public T MaxValue { get; private set; }

        public override string ToString()
        {
            string exceptionInfo = string.Format(
                "{0}.Valid range is [{1}..{2}].",
                this.Message, 
                this.MinValue, 
                this.MaxValue);

            return exceptionInfo;
        }
    }
}