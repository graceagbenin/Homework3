// Written by Grace Ofure Agbenin
// Feb 14, 2025


using System;
using System.Linq;

namespace MultipleFunctions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Function 1 - FindMinMax
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] minMax = FindMinMax(numbers1);
            Console.WriteLine($"Min and Max: [{minMax[0]}, {minMax[1]}]");

            // Function 2 - FindAbsValue
            int[] numbers2 = { -1, -2, -3, -4, -5 };
            int absSum = FindAbsValue(numbers2);
            Console.WriteLine($"Sum of absolute values: {absSum}");

            // Function 3 - MultiplyArray
            int[] numbers3 = { 1, 2, 3 };
            var multipliedResult = MultiplyArray(numbers3);
            Console.WriteLine($"Multiplied Array: {string.Join(", ", multipliedResult)}");

            // Function 4 - SmallerNum
            string smaller = SmallerNum("21", "44");
            Console.WriteLine($"Smaller number: {smaller}");

            // Function 5 - CountDs
            string sentence = "Dare to dream big!";
            int dCount = CountDs(sentence);
            Console.WriteLine($"Count of 'd': {dCount}");
        }

        // function 1
        public static int[] FindMinMax(int[] numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();
            
            return new int[] { min, max };
            
            
        }

        // Function 2 
        public static int FindAbsValue(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += Math.Abs(n);
            }
            return sum;

        }

        //Function 3
        public static int[] MultiplyArray(int[] numbers)
        {
            // get length of array
            int length = numbers.Length;

            // create new array to store result
            int[] result = new int[length];

            // Loop through the array and multiply each element by the length of the array

            for (int i = 0; i < length; i++)
            {
                result[i] = numbers[i] * length;
            }
            return result;

        }

        //Function 4
        public static string SmallerNum(string num1, string num2)
        {
            // Compare the numbers as integers, then return the smaller one as a string
            if (int.Parse(num1) < int.Parse(num2))
                return num1;
            else
                return num2;
        }

        //Function 5
        public static int CountDs(string sentence)
        {
            // Convert the sentence to lowercase to make it case-insensitive
            string lowercaseSentence = sentence.ToLower();

            // Count the number of 'd' characters
            int count = lowercaseSentence.Count(c => c == 'd');

            return count;
        }

















    }
}
