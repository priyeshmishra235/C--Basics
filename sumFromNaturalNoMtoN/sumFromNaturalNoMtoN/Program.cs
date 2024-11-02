using System;

namespace sumFromNaturalNoMtoN
{
    class sumFromNaturalNoMtoN
    {
        static int Main(string[] args)
        {
            Console.WriteLine("You want to find sum from:");
            int startNum= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("to:");
            int finalNum= Convert.ToInt32(Console.ReadLine());

            int sum=0;

            for(int i = startNum; i <= finalNum; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine($"Sum from {startNum} to {finalNum} is: {sum}");

            Console.ReadLine();
            return 0;
        }
    }
}