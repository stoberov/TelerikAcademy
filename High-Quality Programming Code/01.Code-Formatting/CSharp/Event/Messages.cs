namespace Event
{
    using System;
    using System.Linq;
    using System.Text;
    
    public static class Messages
    {
        private static readonly StringBuilder output = new StringBuilder();

        public static StringBuilder Output
        {
            get
            {
                return output;
            }
        }

        public static void EventAdded()
        { 
            output.Append("Event added\n"); 
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound() 
        { 
            output.Append("No events found\n"); 
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.AppendFormat("{0}\n", eventToPrint);
            }
        }

        internal static void PrintEvent(object eventToShow)
        {
            throw new NotImplementedException();
        }
    }
}