using System;
using System.Collections.Generic;

namespace DuckSimulator
{
    class Program
    {
        private static readonly List<string> DuckList = new List<string>(){ "Mallard Duck", "Redhead Duck" };
        
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("Welcome to DuckSimulator!");
            
            SimulateDucks();
            AwaitUserAction();
            MakeDucksSwim();
            Console.ReadKey();
        }

        private static void AwaitUserAction()
        {
            Console.WriteLine("\r\nPress the [s] key to make them swim about!");
            var key = new ConsoleKeyInfo();
            while (key.KeyChar != 's')
            {
                key = Console.ReadKey(true);
            }
        }

        private static void SimulateDucks()
        {
            Console.WriteLine("Look at all of the lovely ducks!");
            DuckList.ForEach(d => Console.Write($"{d}\r\n"));
        }

        private static void MakeDucksSwim()
        {
            DuckList.ForEach(d => Console.Write($"\r\n{d} is swimming."));
            Console.WriteLine("\r\nWow! The ducks are all swimming around. It's so realistic!");
        }
    }
}
