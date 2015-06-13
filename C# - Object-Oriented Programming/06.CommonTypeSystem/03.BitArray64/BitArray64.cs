namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.ConvertToBitsArray();
                return bits[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBitsArray();
            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BitArray64))
            {
                return false;
            }

            BitArray64 other = obj as BitArray64;
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Number == other.Number;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int[] ConvertToBitsArray()
        {
            int[] bits = new int[64];
            for (int i = 0; i < bits.Length; i++)
            {
                int bit = (int)((this.Number >> i) & 1);
                bits[63 - i] = bit;
            }

            return bits;
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !(a == b);
        }
    }
}