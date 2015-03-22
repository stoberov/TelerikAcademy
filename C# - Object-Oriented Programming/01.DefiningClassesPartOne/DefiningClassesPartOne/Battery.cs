namespace MobilePhone
{
    using System;

    public class Battery
    {
        private const string LENGTH_EXCEPTION_MESSAGE = "Length of string must be at least one symbol.";
        private const string PRICE_EXCEPTION_MESSAGE = "Value must be not negative.";

        private readonly BatteryType batteryKind;
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;

        public Battery(BatteryType batteryKind = BatteryType.Unknown, string model = null, double? hoursIdle = null, double? hoursTalk = null)
        {
            this.batteryKind = batteryKind;
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType BatteryKind { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException(LENGTH_EXCEPTION_MESSAGE);
                }
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(PRICE_EXCEPTION_MESSAGE);
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(PRICE_EXCEPTION_MESSAGE);
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public override string ToString()
        {
            const string NoInformation = "No information";

            string batteryInfo = string.Format("Battery type: {0}\nBattery model: {1}\nIdle hours: {2}\nTalk hours: {3}",
                this.batteryKind,
                this.model == null ? NoInformation : this.model,
                this.hoursIdle == null ? NoInformation : this.hoursIdle.ToString(),
                this.hoursTalk == null ? NoInformation : this.hoursTalk.ToString());

            return batteryInfo;
        }
    }
}