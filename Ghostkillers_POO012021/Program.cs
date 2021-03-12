using System;

namespace Ghostkillers_POO012021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0, b= 0;

            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of {a} + {b} equals {SumNumbers(a, b)}");
            
        }
        public static int SumNumbers(int a, int b)
        {
            return a + b;
        }
    }
}