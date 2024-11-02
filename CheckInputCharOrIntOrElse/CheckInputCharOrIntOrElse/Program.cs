namespace CheckInputCharOrIntOrElse
{
    class CheckInputCharOrIntOrElses
    {
        static int Main(string[] args)
        {
           
                char ch = ' '; //declaring a character
                Console.WriteLine("Enter the Character or a Digit \nAllowed: a ,y ,t ,E ,U ,3 ,7 ,$ ,@ ,*");
                Console.WriteLine("Not Allowed : bH ,vnk ,$h ,3H ,$23 ,B$ ,etc.");
                string input = Console.ReadLine(); //getting input as string



                if (input == "") //checking if input is null or not .if null run this
                {
                    Console.WriteLine("Input is NULL");
                }
                else if (input != null) //if input is not null but also not valid like Ty,2h,etc.
                {
                    bool success = char.TryParse(input, out ch); // to handle null input exception
                    if (success)
                    {
                        ch = Convert.ToChar(input); //convert input to character
                    }
                    else
                    {
                        Console.WriteLine("Failed to convert");
                    }
                }


                if (ch >= 48 && ch <= 57)//checking for number
                    Console.WriteLine("It is a number");

                else if (ch >= 33 && ch <= 47)//checking for symbol
                    Console.WriteLine("It is a Symbol");

                else if (ch >= 58 && ch <= 64)//checking for symbol
                    Console.WriteLine("It is a Symbol");

                else if (ch >= 91 && ch <= 96)//checking for symbol
                    Console.WriteLine("It is a Symbol");

                else if (ch >= 123 && ch <= 126)//checking for symbol
                    Console.WriteLine("It is a Symbol");

                else if (ch >= 65 && ch <= 90)//checking for capital letter
                    Console.WriteLine("Capital Letter");

                else if (ch >= 97 && ch <= 122)//checking for small letter
                    Console.WriteLine("Small Letter");

                else //if none of ascii value compared against here matches
                    Console.WriteLine("Illegal Input");



                return 0;
            
        }
    }
}