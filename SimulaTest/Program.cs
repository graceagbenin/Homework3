// Written by Grace Ofure Agbenin
// Feb 14, 2024

namespace SimulaTest
{
    public class Program
    {
        enum ChestState
        {
            Open,
            Closed,
            Locked
        }
        public static void Main(string[] args)
        {
            ChestState currentState = ChestState.Locked;

            while (true)
            {
                Console.WriteLine($"The chest is {currentState.ToString().ToLower()}.");

                Console.Write("What do you want to do? ");
                string input = Console.ReadLine().ToLower();

                if (currentState == ChestState.Locked && input == "unlock")
                {
                    currentState = ChestState.Closed;
                    Console.WriteLine("You unlock the chest.");
                }
                else if (currentState == ChestState.Closed && input == "open")
                {
                    currentState = ChestState.Open;
                    Console.WriteLine("You open the chest.");
                }
                else if (currentState == ChestState.Open && input == "close")
                {
                    currentState = ChestState.Closed;
                    Console.WriteLine("You close the chest.");
                }
                else if (currentState == ChestState.Closed && input == "lock")
                {
                    currentState = ChestState.Locked;
                    Console.WriteLine("You lock the chest.");
                }
                else
                {
                    // Handle invalid commands
                    Console.WriteLine("You can't do that right now.");
                }

                Console.WriteLine();


            }
        }
    }
}
