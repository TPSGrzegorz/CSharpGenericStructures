namespace Railway
{
    public class WheelRailway
    {
        private double[] buffer;
        private int startIndex;
        private int endIndex;

        public WheelRailway() : this(capacity: 5) // default value
        {

        }

        public WheelRailway(int capacity)
        {
            buffer = new double[capacity + 1];

            startIndex = 0;
            endIndex = 0;
        }

        public void Write(double value)
        {
            buffer[endIndex] = value;
            endIndex = (endIndex + 1) % buffer.Length;

            if (endIndex == startIndex)
            {
                startIndex = (startIndex + 1) % buffer.Length;
            }
        }

        public double Read()
        {
            var result = buffer[startIndex];
            startIndex = (startIndex + 1) % buffer.Length;
            return result;
        }

        public int Capacity 
        {
            get 
            {
                return buffer.Length;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return endIndex == startIndex;
            }
        }

        public bool IsFull
        {
            get
            {
                return (endIndex + 1) % buffer.Length == startIndex;
            }
        }
    }
}
