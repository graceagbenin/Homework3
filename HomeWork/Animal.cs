//Written by Grace Ofure Agbenin
// Feb 25, 2025

using System;


namespace HomeWork
{
    public class Animal
    {
        // gets and sets
        public string Name { get; set; }

        // constructors 
        public Animal(string name)
        {
            this.Name = name;
        }

        // methods 
        public virtual string MakeSound()
        {
            return "Some sound";
        }

        public override string ToString()
        {
            return $"Animal: {Name}, Sound: {MakeSound()}";
        }
    }

    // Subclass Dog
    public class Dog : Animal
    {
        // constructors
        public Dog(string name) : base(name)
        {
            this.Name = name;
        }

        public override string MakeSound()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"{Name}, Sound: {MakeSound()}";
        }
    }

    // Subclass Cat
    public class Cat : Animal
    {
        // constructors
        public Cat(string name) : base(name)
        {
            this.Name = name;
        }

        public override string MakeSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"{Name}, Sound: {MakeSound()}";
        }
    }

}
