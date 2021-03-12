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

            Console.WriteLine($"The subtraction of {a} - {b} equals {SubNumbers(a, b)}");
             }
             public static int SubNumbers(int a, int b)
        {
            return a - b;
        }
    }
}