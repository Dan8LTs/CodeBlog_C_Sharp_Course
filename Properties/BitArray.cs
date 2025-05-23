namespace Properties
{
    internal sealed class BitArray
    {
        private byte[] byteArray;
        private int numBits;

        public BitArray(int numBits)
        {
            if (numBits < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numBits), "incorrect number of bits");
            }

            this.numBits = numBits;
            byteArray = new byte[(numBits + 7) / 8];
        }

        public bool this[int bitPosition]
        {
            get
            {
                if ((bitPosition < 0) || (bitPosition >= numBits))
                {
                    throw new ArgumentOutOfRangeException(nameof(bitPosition));
                }
                return (byteArray[bitPosition / 8] & (1 << (bitPosition % 8))) != 0;
            }
            set
            {
                if ((bitPosition < 0) || (bitPosition >= numBits))
                {
                    throw new ArgumentOutOfRangeException(nameof(bitPosition), "bit position is incorrect");
                }

                if (value)
                {
                    byteArray[bitPosition / 8] = (byte)(byteArray[bitPosition / 8] | (1 << (bitPosition % 8)));
                }
                else
                {
                    byteArray[bitPosition / 8] = (byte)(byteArray[bitPosition / 8] & ~(1 << (bitPosition % 8)));
                }
            }
        }
    }
}