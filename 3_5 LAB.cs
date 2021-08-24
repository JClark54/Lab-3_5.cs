using System;

namespace _3_5_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "Viagra";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord));
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");

            }

            
            Console.WriteLine("Hello World!");
        }
    }
}
