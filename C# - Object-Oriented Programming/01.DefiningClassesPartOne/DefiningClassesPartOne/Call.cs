namespace MobilePhone
{
    using System;
    
    public class Call
    {
        private readonly DateTime startDateTime;
        private readonly DateTime endDateTime;

        public Call(DateTime startDateTime, DateTime endDateTime, string dialedNumber)
        {
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
            this.DialedNumber = dialedNumber;
        }

        public string Date
        {
            get
            {
                return this.startDateTime.ToShortDateString();
            }
        }

        public string Time
        {
            get
            {
                return this.startDateTime.ToShortTimeString();
            }
        }

        public string DialedNumber { get; private set; }

        public double Duration
        {
            get
            {
                return (this.endDateTime - this.startDateTime).TotalSeconds;
            }
        }

        public override string ToString()
        {
            string callInfo = string.Format("Number: {0}\nDate: {1}\nTime: {2}\nDuration: {3} seconds",
                this.DialedNumber,
                this.Date,
                this.Time,
                this.Duration);

            return callInfo;
        }
    }
}