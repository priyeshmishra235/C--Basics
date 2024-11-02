using System;

namespace twoNumSumFind
{
    class TwoNumSumFind
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of {a} and {b} is : {a+b}");

            Console.ReadLine();
            return 0;
        }
    }
}