// Written by Grace Ofure Agbenin
// Feb 14, 2025
using System;

namespace ManticoreDefense
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cityHealth = 15;
            int manticoreHealth = 10;
            int round = 1;

            int range = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
            Console.Clear();

            Console.WriteLine("Player 2, it is your turn.");

            while (cityHealth > 0 && manticoreHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------------------------");
                DisplayStatus(round, cityHealth, manticoreHealth);

                int damage = DamageForRound(round);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

                Console.ForegroundColor = ConsoleColor.White;
                int targetRange = AskForNumber("Enter desired cannon range:");

                Console.ForegroundColor = ConsoleColor.Magenta;
                DisplayOverOrUnder(targetRange, range);

                if (targetRange == range) manticoreHealth -= damage;
                if (manticoreHealth > 0) cityHealth--;

                round++;
            }

            bool won = cityHealth > 0;
            DisplayWinOrLose(won);
        }

        public static void DisplayWinOrLose(bool won)
        {
            if (won)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
            }
        }

        public static void DisplayOverOrUnder(int targetRange, int range)
        {
            if (targetRange < range)
                Console.WriteLine("That round FELL SHORT of the target.");
            else if (targetRange > range)
                Console.WriteLine("That round OVERSHOT the target.");
            else
                Console.WriteLine("That round was a DIRECT HIT!");
        }

        public static void DisplayStatus(int round, int cityHealth, int manticoreHealth) =>
            Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");

        public static int DamageForRound(int roundNumber)
        {
            if (roundNumber % 5 == 0 && roundNumber % 3 == 0) return 10; // Combined Electric and Fire
            else if (roundNumber % 5 == 0) return 3; // Electric
            else if (roundNumber % 3 == 0) return 3; // Fire
            return 1; // Normal
        }

        public static int AskForNumber(string text)
        {
            Console.Write(text + " ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int number = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            return number;
        }

        public static int AskForNumberInRange(string text, int min, int max)
        {
            while (true)
            {
                int number = AskForNumber(text);
                if (number >= min && number <= max)
                    return number;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                Console.ResetColor();
            }
        }
    }
}
