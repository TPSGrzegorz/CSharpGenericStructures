﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColetions
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList();

            //MyQueue();
            //MyStack();

            MyHashSet();
        }

        private static void MyHashSet()
        {
            HashSet<Worker> set = new HashSet<Worker>();
            var worker = new Worker { Name = "Adam", Sunrame = "Bogusz" };
            set.Add(worker);
            set.Add(worker);
            set.Add(new Worker { Name = "Grzegorz", Sunrame = "Bogusz" });
            set.Add(new Worker { Name = "Grzegorz", Sunrame = "Bogusz" }); ;


            foreach (var i in set)
            {
                Console.WriteLine(i.Name);
            }
        }

        private static void MyList()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker { Name = "Grzegorz", Sunrame = "Bogusz"},
                new Worker { Name = "Jan", Sunrame = "Kowalski"},
                new Worker { Name = "Jakub", Sunrame = "Nowak"},
            };
            workers[1].Name = "Marek";

            //Array.Resize(ref workers, 10);

            //workers[9] = new Worker { Name = "Anatol", Sunrame = "Koszyk" };
            workers.Add(new Worker { Name = "Anatol", Sunrame = "Koszyk" });
            foreach (var worker in workers)
            {
                if (worker != null)
                    Console.WriteLine($"{worker.Name}, {worker.Sunrame}");
            }

            var number = new List<int>(10);
            var capacity = -1;

            //while (true) // Test 
            //{
            //    if (number.Capacity != capacity)
            //    {
            //        capacity = number.Capacity;
            //        Console.WriteLine(capacity);
            //    }
            //    number.Add(1);
            //}
        }

        private static void MyStack()
        {
            Console.WriteLine("!!!!!!!!!!STOS!!!!!!!!!");
            Stack<Worker> stack = new Stack<Worker>();
            stack.Push(new Worker { Name = "Grzegorz", Sunrame = "Bogusz" });
            stack.Push(new Worker { Name = "Anna", Sunrame = "Rurarz" });
            stack.Push(new Worker { Name = "Marek", Sunrame = "Cros" });
            stack.Push(new Worker { Name = "Ola", Sunrame = "War" });

            while (stack.Count > 0)
            {
                var temp = stack.Peek();
                var worker = stack.Pop();
                Console.WriteLine(worker.Name + " " + worker.Sunrame);
            }
        }

        private static void MyQueue()
        {
            Console.WriteLine("!!!!!!!!!Queue!!!!!!!!!!!");
            Queue<Worker> queue = new Queue<Worker>();
            queue.Enqueue(new Worker { Name = "Grzegorz", Sunrame = "Bogusz" });
            queue.Enqueue(new Worker { Name = "Anna", Sunrame = "Rurarz" });
            queue.Enqueue(new Worker { Name = "Marek", Sunrame = "Cros" });
            queue.Enqueue(new Worker { Name = "Ola", Sunrame = "War" });

            while (queue.Count > 0)
            {
                var worker = queue.Dequeue();
                Console.WriteLine(worker.Name + " " + worker.Sunrame);
            }
        }
    }
}
