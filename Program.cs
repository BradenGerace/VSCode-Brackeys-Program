using System;
using System.Collections.Generic;

namespace VSCode_Brackeys_Program
{
    class Wizard {
        public string name;
        public string favouriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favouriteSpell) {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell() {

            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is all out of spell slots.");
            }
        }

        public void Meditate() {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 2;
        }
    }

    class Program
    {
        private const int V = 40;

        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Parry", "Patronum");

            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();

            wizard01.Meditate();

            wizard01.CastSpell();
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Glindalf", "Kadabra");

            Console.WriteLine(Wizard.Count);

            Console.WriteLine("Enter a sentence: ");

            string inputSentence = Console.ReadLine();

            WordsInSentence(inputSentence);

            MeetAlien();
            Console.ReadKey();
            MeetAlien();
            Console.ReadKey();
            Console.WriteLine(Convert.ToInt32(Square(4)));
            Console.ReadKey();
            int resultMultiply01 = Multiply(3, 8);
            Console.ReadKey();
            int resultMultiply02 = Multiply(7,13);
            Console.ReadKey();
            int resultOfResults = Multiply(resultMultiply01, resultMultiply02);
            Console.ReadKey();
            Console.WriteLine("Those numbers multiplied equals " + resultOfResults);
            Console.ReadKey();
            if (resultOfResults % 2 == 0)
            {
                Console.WriteLine("Your result is even");
            }
            else {
                Console.WriteLine("Result is an odd number");
            }

            //list and sort student names
             List<string> students = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter student's name, write q to quit: ");
                string name = Console.ReadLine();
                if(name == "q")
                {
                    break;
                }
                students.Add(name);
            }


            students.Sort();


            Console.WriteLine("\n----------------------");
            Console.WriteLine("Here are students names sorted alphabetically");
            for(int i=0; i<students.Count; i++)
            {
                Console.WriteLine(i+1 + ". "+ students[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

            //roll the dice
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

            //Math.Pow
            Console.Write("How many powers of 2? ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double result2 = Math.Pow(2, i);
                Console.WriteLine(result2);  
            }

            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Ponies");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.RemoveAt(1);

            Console.WriteLine("--------------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            //Array
            string[] beans = {
                "Vanilla", "Coffee", "Green", "Black", "Pinto"
            };

            int j = 0;

            string[] movies = new string[4];

            Console.WriteLine("Enter your 4 fav movies: ");

            //foreach loop for array
            foreach (string item in movies)
            {
                movies[j] = Console.ReadLine();
                j++;
            }

            int x = 0;

            Console.WriteLine("Your fav movies are: ");

            foreach (string item in movies)
            {
                Console.WriteLine(movies[x++]);
            }

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            Console.WriteLine("The best beans: ");

            for (int i = 0; i < 5; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + beans[i]);
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

            Console.WriteLine("What is your fav animal?");

            string favAnimal = Console.ReadLine();

            Console.WriteLine("I guess: " + favAnimal);

            Console.WriteLine("Spot on.");

            Console.ReadKey();
        }

        static void MeetAlien() {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(20, 5000);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
        }

        static int Square (int toSquare) {
            int result = toSquare * toSquare;
            return result;
        }

        static int Multiply (int num01, int num02) {
            int result = num01 * num02;
            Console.WriteLine("The result is: " + result);
            return result;
        }

        static int WordsInSentence (string sentence) {
            int sentenceLength = sentence.Split(' ').Length;
            Console.WriteLine("There are " + sentenceLength + " words in your sentence.");
            return sentenceLength;
        }
    }
}
