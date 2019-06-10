using System;

namespace DuckSimulator
{
    public class Duck
    {
        private readonly string _name;

        public Duck(string name)
        {
            _name = name + " Duck";
        }

        public override string ToString()
        {
            return _name;
        }

        public void Display()
        {
            Console.Write($"{_name}\r\n");
        }

        public void Swim()
        {
            Console.Write($"\r\n{_name} is swimming.");
        }

        public void Quack()
        {
            Console.Write($"\r\n{_name} says \"Quack\".");
        }
    }
}