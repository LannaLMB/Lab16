using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Console
{
    class Program
    {
        static void Main(string[] args)
        {

            // Continue Loop
            bool loop = true;

            Console.WriteLine("Let's Locate Some Primes!\n");
            Console.WriteLine("This Application Will Find You Any Prime, In Order From The First Prime Number On.");

            while (loop)
            {
                Console.Write("Which Prime Are You Looking For?  ");
                int input = GetRange(1, 100);
                int primeNumber = countPrimeNumbers(input);

                Console.WriteLine($"The {input} Prime Number is  --->   {primeNumber}");

                if (!GetContinue())
                {
                    Console.WriteLine("Byebye!");
                    loop = false;
                }
            }

        }



        // Method to Find Out if the Number is Prime
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }



        // Method to Count the Placement of the Prime Number
        public static int countPrimeNumbers(int input)
        {
            int number;
            int primeCount = 0;
            for (number = 1; input != primeCount; number++)
            {
                if (isPrime(number))
                    primeCount++;
            }
            return number - 1;
        }



        // Method to Ask User to Continue
        public static bool GetContinue()
        {
            string Continue;
            //Continue Loop
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Do You Want to Find Another Prime Number? (y/n): ");
                Continue = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                if (Continue == "Y")
                    return true;

                if (Continue == "N")
                    return false;

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                    Console.WriteLine("Please Enter Y or N");
                    Console.ForegroundColor = ConsoleColor.Green;   // Green to Go Back to Original Color
                }
            }
        }



        // Method to Get Valid Integer
        public static int GetValidInt()
        {

            int number;

            // Validate Input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();

                // Number Validation with Colors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Enter a Number:  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;

            }
            return number;
        }



        // Method to Get Input and Validate That Number is Between 0 and 4.
        public static int GetRange(int min, int max)
        {

            // Get a Valid Int from Previous Method
            int number = GetValidInt();

            while (number < min || number > max)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"You MUST Enter a Number That is in Between {min} and {max}  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                number = GetValidInt();
            }
            return number;

        }

    }
}
