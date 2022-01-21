using System;

namespace VSCode_Brackeys_Program
{
    class Program
    {
        private const int V = 40;

        static void Main(string[] args)
        {

            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the die.");

            while (roll != roll2)
            {
                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll + " and " + roll2);
                if (roll == roll2)
                {
                    Console.WriteLine("Your rolls matched!");
                }
                attempts++;
            }

            Console.WriteLine("you made " + attempts + " rolls");

            Console.Write("How many powers of 2? ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double result2 = Math.Pow(2, i);
                Console.WriteLine(result2);  
            }

            


            //If statement checking cash
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

            //switch statement

            Console.Write("Input a number between 1 and 5: ");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num) {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
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
