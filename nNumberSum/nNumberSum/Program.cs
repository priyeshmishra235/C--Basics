using System;

namespace nNumberSum
{
    class nNumberSum
    {
        static int Main(string[] args)
        {
            Console.Write("How many numbers you want to add : ");
            int howMany = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i = 1; i <= howMany; i++)
            {
                Console.Write($"Enter {i}th number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }

            Console.WriteLine($"sum of these numbers is {sum}");



            Console.ReadLine();
            return 0;
        }
    }
}