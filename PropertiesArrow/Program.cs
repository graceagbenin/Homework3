// Written by Grace Ofure Agbenin
// Feb 13, 2025

using System;

namespace PropertiesArrow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose arrowhead: 1. Steel, 2. Wood, 3. Obsidian");
            ArrowheadType arrowhead = (ArrowheadType)(int.Parse(Console.ReadLine()) - 1);

            Console.WriteLine("Choose fletching: 1. Plastic, 2. Turkey Feathers, 3. Goose Feathers");
            FletchingType fletching = (FletchingType)(int.Parse(Console.ReadLine()) - 1);

            Console.Write("Enter shaft length (cm): ");
            float length = float.Parse(Console.ReadLine());

            Arrow arrow = new Arrow(arrowhead, fletching, length);
            Console.WriteLine($"Arrow cost: {arrow.GetCost()} gold.");
        }
    }
}
