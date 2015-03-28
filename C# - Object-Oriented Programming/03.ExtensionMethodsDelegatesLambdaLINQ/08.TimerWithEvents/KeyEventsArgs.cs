namespace TimerExecuteMethodWithEvents
{
    using System;
    
    public class KeyEventsArgs : EventArgs
    {
        public KeyEventsArgs(char pressedKey)
        {
            this.PressedKey = pressedKey;
        }

        public char PressedKey { get; private set; }
    }
}