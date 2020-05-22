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

            CreatPersonRailway(railwayPerson);
            PrintPersonRailway(railwayPerson);
            ReadData(railway);
            RefactoringData(railway);
            Console.ReadLine();

        }

        private static void PrintPersonRailway(WheelRailway<Person> railwayPerson)
        {
            while (!railwayPerson.IsEmpty)
            {
                var person = railwayPerson.Read();
                Console.WriteLine("\t\t" + person.Name + " " + person.Surname);
            }
        }

        private static void CreatPersonRailway(WheelRailway<Person> railwayPerson)
        {
            railwayPerson.Write(new Person { Name = "Grzegorz", Surname = "Bogusz" });
            railwayPerson.Write(new Person { Name = "Anna", Surname = "Bogusz" });
            railwayPerson.Write(new Person { Name = "Tymoteusz", Surname = "Bogusz" });
            railwayPerson.Write(new Person { Name = "Maryja", Surname = "Bogusz" });
        }

        private static void RefactoringData(WheelRailway<double> railway)
        {
            var sum = 0.0;
            Console.WriteLine("In our Railway:");
            while (!railway.IsEmpty)
            {
                Console.WriteLine("\t\t" + railway.Read());
            }
            Console.WriteLine(sum);
        }

        private static void ReadData(WheelRailway<double> railway)
        {
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
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
