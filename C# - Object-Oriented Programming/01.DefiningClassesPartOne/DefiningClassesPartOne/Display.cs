namespace MobilePhone
{
    using System;
    
    public class Display
    {
        private const string STRING_EXCEPTION_MESSAGE = "Length of string must be at least one symbol.";
        private const string DOUBLE_EXCEPTION_MESSAGE = "Value must be not negative.";

        private double? displaySize;
        private string displayColors;

        public Display(double? displaySize = null, string displayColors = null)
        {
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColors;
        }

        public double? DisplaySize
        {
            get
            {
                return this.displaySize;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(DOUBLE_EXCEPTION_MESSAGE);
                }
                else
                {
                    this.displaySize = value;
                }
            }
        }

        public string DisplayColors
        {
            get
            {
                return this.displayColors;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.displayColors = value;
                }
                else
                {
                    throw new ArgumentException(STRING_EXCEPTION_MESSAGE);
                }
            }
        }

        public override string ToString()
        {
            const string NoInformation = "no information";

            string displayInfo = string.Format("Display size: {0}\nDisplay colors: {1}",
                this.DisplaySize == null ? NoInformation : this.DisplaySize.ToString(),
                this.DisplayColors == null ? NoInformation : this.DisplayColors);

            return displayInfo;
        }
    }
}