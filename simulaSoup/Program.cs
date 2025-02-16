// Written by Grace Ofure Agbenin
// Feb 16, 2025

namespace SimulaSoup
{
    public class Program
    {
        enum FoodType
        {
            Soup,
            Stew,
            Gumbo
        }

        enum MainIngredient
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes
        }

        enum Seasoning
        {
            Spicy,
            Salty,
            Sweet
        }

        public static void Main(string[] args)
        {
            (FoodType type, MainIngredient ingredient, Seasoning seasoning) dish;

            // Step 3: Let the user choose options
            Console.WriteLine("Welcome to Simula's Soup Kitchen!");

            // Choose the type of food
            Console.WriteLine("Choose a type of food:");
            Console.WriteLine("1. Soup");
            Console.WriteLine("2. Stew");
            Console.WriteLine("3. Gumbo");
            Console.Write("Enter the number of your choice: ");
            dish.type = GetEnumValue<FoodType>();

            // Choose the main ingredient
            Console.WriteLine("Choose a main ingredient:");
            Console.WriteLine("1. Mushrooms");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Carrots");
            Console.WriteLine("4. Potatoes");
            Console.Write("Enter the number of your choice: ");
            dish.ingredient = GetEnumValue<MainIngredient>();

            // Choose the seasoning
            Console.WriteLine("Choose a seasoning:");
            Console.WriteLine("1. Spicy");
            Console.WriteLine("2. Salty");
            Console.WriteLine("3. Sweet");
            Console.Write("Enter the number of your choice: ");
            dish.seasoning = GetEnumValue<Seasoning>();

            // Display the final dish
            Console.WriteLine($"Your dish is: {dish.seasoning} {dish.ingredient} {dish.type}");
        }

        // Helper method to get an enum value from user input
        static T GetEnumValue<T>() where T : Enum
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (Enum.IsDefined(typeof(T), choice - 1))
                    {
                        return (T)(object)(choice - 1); // Convert to zero-based index
                    }
                }
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}