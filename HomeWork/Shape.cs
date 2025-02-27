//Written by Grace Ofure Agbenin
// Feb 25, 2025


using System;

namespace HomeWork
{
    // Abstract base class
    public abstract class Shape
    {
        // gets and sets
        public string Color { get; set; }

        // constructors
        public Shape(string aColor)
        {
            this.Color = aColor;
        }

        // methods
        public abstract double GetArea();

        public override string ToString()
        {
            return $"{Color} Shape";
        }
    }

    // Subclass Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // constructors
        public Rectangle(string color, double height, double width) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"{Color} Rectangle (Width: {Width}, Height: {Height}, Area: {GetArea()})";
        }
    }

    // Subclass Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        // Constructors
        public Circle(string color, double radius) : base(color)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"{Color} Circle (Radius: {Radius}, Area: {GetArea():0.00})";
        }
    }

}
