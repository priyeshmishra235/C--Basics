using System;

namespace SwapTwoNum
{
    class SwapTwoNum
    { 
        static int Main(string[] args)
        {
            int a, b, temp;

            Console.WriteLine("enter first number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers befor swapping are a = {a} and b = {b}");

            temp =a;
            a = b;
            b= temp;

            Console.WriteLine($"Swapped Numbers are a = {a} and b = {b}");

            Console.ReadLine();
            return 0;
        }
    }
}