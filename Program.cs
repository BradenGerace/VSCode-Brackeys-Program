using System;

namespace VSCode_Brackeys_Program
{
    class Program
    {
        private const int V = 40;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This game costs $5 to play. Please enter cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5) {
                Console.WriteLine("Not enough money.");
            }

            else if (cash == 5) {
                Console.WriteLine("You may play.");
            }

            else {
                int change = cash - 5;
                Console.WriteLine("You may play. Your change is: $" + change);
            }

            //Average of 3 numbers

            double num01;
            double num02;
            double num03;

            Console.Write("Input a number: ");

            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");

            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a third number: ");

            num03 = Convert.ToDouble(Console.ReadLine());

            double result = (num01 + num02 + num03) / 3;
            Console.WriteLine("The average of your numbers is: " + result);

            // Change the appearance

            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WindowHeight = V;

            // Get a conversation going

            Console.WriteLine("Hello, what's your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Right, so your name is " + userName + "? (y/n)");

            //clarify if username is correct
            var answer = Console.ReadLine();

            if  (answer == "n") {
                return;
            }

            if  (answer == "y") {
                
            }

            Console.WriteLine("What is your fav colour?");

            string favColour = Console.ReadLine();

            Console.WriteLine("I guess: ");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("red");

            if  (favColour == "red" || favColour == "Red" || favColour == "RED") {
                Console.WriteLine("Nailed it.");
            }

            else {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Flubbed it");
            }

            Console.ReadKey();
        }
    }
}
