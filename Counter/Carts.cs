using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Carts:ICountable
    {
        public static int ContentsOfBoxOne { get; private set; }
        public static int ContentsOfBoxTwo { get; private set; }
        public static int ContentsOfBoxThree { get; private set; }

        public int Count()
        {
            ContentsOfBoxOne = 56;
            ContentsOfBoxTwo = 4998;
            ContentsOfBoxThree = 20;
            return ContentsOfBoxOne + ContentsOfBoxTwo + ContentsOfBoxThree;
        }
        public void Crate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total Number of Items in crates: {0}", Count());
            Console.WriteLine();
            Console.WriteLine("Amount of things in box one: {0}", ContentsOfBoxOne);
            Console.WriteLine("Amount of things in box two: {0}", ContentsOfBoxTwo);
            Console.WriteLine("Amount of things in box three: {0}", ContentsOfBoxThree);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
