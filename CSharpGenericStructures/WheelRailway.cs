namespace Railway
{
    public class WheelRailway<T>
    {
        private T[] buffer;
        private int startIndex;
        private int endIndex;

        public WheelRailway() : this(capacity: 5) // default value
        {

        }

        public WheelRailway(int capacity)
        {
            buffer = new T[capacity + 1];

            startIndex = 0;
            endIndex = 0;
        }

        public void Write(T value)
        {
            buffer[endIndex] = value;
            endIndex = (endIndex + 1) % buffer.Length;

            if (endIndex == startIndex)
            {
                startIndex = (startIndex + 1) % buffer.Length;
            }
        }

        public T Read()
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
