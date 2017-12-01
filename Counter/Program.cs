using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Apples apple = new Apples();
            Crates box = new Crates();
            Carts cart = new Carts();
            apple.List();
            box.Count();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Number of Apples: {0}", apple.List());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Number of Items in Box4: {0}", box.Count());
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Apple = {0}", apple.Count());
            Console.ReadLine();

            cart.Crate();
        }
    }
}
