using System;
using System.Net.Security;

namespace SumOfDigitsOfNum
{ 
    class SumOfDigitsOfNum
    {
        static int Main(string[] args)
        {
            int num,rem,temp,sum=0;
            Console.WriteLine("enter the number you want to find sum of digits of");
            num = Convert.ToInt32(Console.ReadLine());

            while (num >0)
            {
                temp = num;
                sum = sum + (num % 10);
                num = temp/10;
            }

            Console.WriteLine($"sum of digits is {sum}");
            Console.ReadLine();
            return 0;
        }
    }
}
