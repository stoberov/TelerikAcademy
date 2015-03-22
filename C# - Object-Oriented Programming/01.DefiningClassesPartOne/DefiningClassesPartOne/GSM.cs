namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const string LENGTH_EXCEPTION_MESSAGE = "Length of string must be at least one symbol.";
        private const string PRICE_EXCEPTION_MESSAGE = "Price must be positive.";

        private static readonly GSM iPhone4S;

        private readonly List<Call> callHistory;

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;

        public GSM(string model, string manufacturer, double? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            if (battery == null)
            {
                this.Battery = new Battery();
            }
            else
            {
                this.Battery = battery;
            }

            if (display == null)
            {
                this.Display = new Display();
            }
            else
            {
                this.Display = display;
            }

            this.callHistory = new List<Call>();
        }

        public static GSM()
        {
            iPhone4S = new GSM("4S", "Apple", 600, "Pe6o", new Battery(BatteryType.LiPol, null, 400, 10), new Display(4.5, "16M"));
        }

        public static string IPhone4S
        {
            get
            {
                return iPhone4S.ToString();
            }
        }

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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException(LENGTH_EXCEPTION_MESSAGE);
                }
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(PRICE_EXCEPTION_MESSAGE);
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException(LENGTH_EXCEPTION_MESSAGE);
                }
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public Call[] CallHistory
        {
            get
            {
                return this.callHistory.ToArray();
            }
        }

        public void AddCall(DateTime startDateTime, DateTime endDateTime, string dialedNumber)
        {
            this.callHistory.Add(new Call(startDateTime, endDateTime, dialedNumber));
        }

        public void DeleteCall(int callNumber)
        {
            if ((callNumber > 0) && (callNumber <= this.callHistory.Count))
            {
                this.callHistory.RemoveAt(callNumber - 1);
            }
            else
            {
                throw new ApplicationException("Call not found");
            }
        }

        public void DeleteLongestCall()
        {
            double longestDuration = double.MinValue;
            Call selectedElement = null;
            foreach (Call call in this.callHistory)
            {
                if (call.Duration > longestDuration)
                {
                    longestDuration = call.Duration;
                    selectedElement = call;
                }
            }

            if (selectedElement != null)
            {
                this.callHistory.Remove(selectedElement);
            }
        }

        public void DeleteAllCalls()
        {
            this.callHistory.Clear();
        }

        public double TotalAmountOfCalls(double minutePrise)
        {
            double totalCallTimeInSeconds = 0;
            foreach (Call call in this.callHistory)
            {
                totalCallTimeInSeconds += call.Duration;
            }

            double totalAmountofCalls = (totalCallTimeInSeconds / 60) * minutePrise;
            return totalAmountofCalls;
        }

        public override string ToString()
        {
            StringBuilder gsmInfo = new StringBuilder();
            gsmInfo.AppendLine(string.Format("Model: {0}", this.model));
            gsmInfo.AppendLine(string.Format("Manufacturer: {0}", this.manufacturer));
            gsmInfo.AppendLine(string.Format("Price: ${0}", this.price == null ? "no price inserted" : this.price.ToString()));
            gsmInfo.AppendLine(string.Format("Owner: {0}", this.owner == null ? "no owner inserted" : this.owner));
            gsmInfo.AppendLine(this.Battery.ToString());
            gsmInfo.AppendLine(this.Display.ToString());
            gsmInfo.AppendLine(new string('-', 25));
            if (this.callHistory.Count != 0)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    gsmInfo.AppendLine(string.Format("Call #{0}\n{1}", i + 1, this.callHistory[i]));
                    gsmInfo.AppendLine(new string('-', 25));
                }
            }
            else
            {
                gsmInfo.AppendLine("Call history is empty.");
                gsmInfo.AppendLine(new string('-', 25));
            }

            return gsmInfo.ToString();
        }
    }
}