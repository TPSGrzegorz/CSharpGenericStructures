using System;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            var railway = new WheelRailway<double>(capacity: 3);
            var railway2 = new WheelRailway<int>(capacity: 4);
            var railway3 = new WheelRailway<string>(capacity: 1000);

            var railwayPerson = new WheelRailway<Person>();
            railwayPerson.Write(new Person { Name = "Grzegorz", Surname = "Bogusz" });
            railwayPerson.Write(new Person { Name = "Anna", Surname = "Bogusz" });
            railwayPerson.Write(new Person { Name = "Tymoteusz", Surname = "Bogusz" });
            railwayPerson.Write(new Person { Name = "Maryja", Surname = "Bogusz" });

            while (!railwayPerson.IsEmpty)
            {
                var person = railwayPerson.Read();
                Console.WriteLine("\t\t" + person.Name + " " + person.Surname);
            }

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
            var sum = 0.0;
            Console.WriteLine("In our Railway:");
            while (!railway.IsEmpty)
            {
                Console.WriteLine("\t\t" + railway.Read());
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
