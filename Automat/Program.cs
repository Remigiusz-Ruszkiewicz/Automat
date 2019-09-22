using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose what you want buy :");
            Console.WriteLine("S - Orange Juice");
            Console.WriteLine("W - Water");
            Console.WriteLine("C - Cola");
            Machine Machine = new Machine();
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.S:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("You bought Orange Juice");
                    Machine.juice.Pop();
                    break;
                case ConsoleKey.W:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("You bought Water");
                    Machine.water.Pop();
                    break;
                case ConsoleKey.C:
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("You bought Cola");
                    Machine.cola.Pop();
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
            Console.Read();
        }
    }
}
