using System;

namespace Palindrome
{
    class Palindrome
    {
        static int Main(string[] args)
        {
            int reverse=0, rem, num, originalNum; //declaring variables
            //getting input from the user for the number
            Console.WriteLine("Enter number you want to find if palindrome or not:");
            num=Convert.ToInt32(Console.ReadLine()); //getting input

            originalNum = num; //storing input num as original num for comparison

            while (num > 0) //loop until num >0
            {
                rem = num % 10;
                reverse= reverse*10 + rem;
                num = num / 10;
            }
             //ternary operator simplifies simple if else statements
            string result = reverse == originalNum ? "It is a Palindrome" : "It is not a palindrome";
            Console.WriteLine(result);

            return 0;
        }
    }
}