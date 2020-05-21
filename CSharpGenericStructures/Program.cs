using System;

namespace CSharpGenericStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var railway = new WheelRailway(capacity: 3);

            while (true)
            {
                var value = 0.0;
                var inputValue = Console.ReadLine();

                if (double.TryParse(inputValue, out value))
                {
                    railway.Write(value);
                    continue;
                }
                break;
            }

            Console.WriteLine("In our Railway:");
            while (!railway.IsEmpty)
            {
                Console.WriteLine("\t\t" + railway.Read());
            }
            Console.ReadLine();
        }
    }
}
