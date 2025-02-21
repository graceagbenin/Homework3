using System.Collections.Generic;

namespace HomeWork
{
    public class Program
    {
        //function 1 Create a method that takes a string and returns the word count. The string will be a sentence.
        public static int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
       
        // Function 2 Create a function that takes a string and returns a new string with its first and last characters swapped, except under two conditions:
        //If the length of the string is less than two, return "Incompatible.".
        //If the first and last characters are the same, return "Two's a pair.".
        public static string SwapFirstAndLast(string input)
        {
            // Check if the string is too short
            if (input.Length < 2)
            {
                return "Incompatible";
            }
            // Check if the first and last characters are the same

            if (input[0] == input[input.Length - 1])
            {
                return "Two's a pair";
            }
            // Swap the first and last characters
            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            string middlePart = input.Substring(1, input.Length - 2);

            // Construct the new string
            return lastChar + middlePart + firstChar;
        }
        //function 3 Create a function that takes a string and returns true or false, depending on whether the characters are in order or not.
        public static bool IsInOrder(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    return false;
                }
            }
            return true;

        }
        // function 4 Write a function that returns the first n vowels of a string
        public static string firstNVowels(string input, int n)
        {
            string vowels = "aeiou";
            string result = "";

            foreach (char c in input.ToLower())
            {
                if (vowels.Contains(c))
                { 
                    result += c;

                    if (result.Length == n)
                    {
                        return result;
                    }
                    
                    
                }
                  
            }
            return "invalid";
        }
        //Function 5 Write a function that changes every letter to the next letter:
        public static string move(string input)
        {
            string result = "";
            foreach (char c in input.ToLower())
            {
                result += (c == 'z') ? 'a' : (char)(c + 1);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            //function 1
            string inputString = "just an example here move along";
            int wordCount = CountWords(inputString);
            Console.WriteLine($"The word count is: {wordCount}");

            //function 2
            string inputString2 = "Cat, dog, and mouse";
            string result = SwapFirstAndLast(inputString);
            Console.WriteLine(result);

            // Function 3 
            string inputString3 = "abcdef";
            Console.WriteLine($"Is '{inputString3}' in order? {IsInOrder(inputString3)}");

            //Function 4 
            Console.WriteLine(firstNVowels("sharpening skills", 3));
            Console.WriteLine(firstNVowels("major league", 5));      
            Console.WriteLine(firstNVowels("hostess", 5));

            //Function 5 
            Console.WriteLine(move("hello"));
            Console.WriteLine(move("bye"));     
            Console.WriteLine(move("welcome")); 

        }
    }
}
