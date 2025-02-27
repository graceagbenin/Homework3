//Written by Grace Ofure Agbenin
//Feb 26, 2025

using System;

namespace HomeWork
{
    public class Vehicle
    {
        private string make = "n/a";
        private string model = "n/a";
        private int year = 0;

        // Gets and sets
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // Constructors
        public Vehicle(string aMake, string aModel, int aYear)
        {
            this.make = aMake;
            this.model = aModel;
            this.year = aYear;
        }

        public Vehicle() : this("n/a", "n/a", 0)
        {
        }

        // Methods
        public override string ToString()
        {
            return $"{Make} {Model} {Year}";
        }

        // Subclasses
        public class Car : Vehicle
        {
            private int numberOfDoors = 0;

            // Gets and sets
            public int NumberOfDoors
            {
                get { return this.numberOfDoors; }
                set { this.numberOfDoors = value; }
            }

            // Constructors
            public Car(string make, string model, int year, int numberOfDoors)
                : base(make, model, year)
            {
                this.numberOfDoors = numberOfDoors;
            }

            public override string ToString()
            {
                return $"{Year} {Make} {Model} with {NumberOfDoors} doors";
            }
        }

        public class Motorcycle : Vehicle
        {
            private bool hasSidecar = false;

            // Gets and sets
            public bool HasSidecar
            {
                get { return this.hasSidecar; }
                set { this.hasSidecar = value; }
            }

            // Constructors
            public Motorcycle(string make, string model, int year, bool hasSidecar)
                : base(make, model, year)
            {
                this.hasSidecar = hasSidecar;
            }

            public override string ToString()
            {
                return $"{Year} {Make} {Model} (Has Sidecar: {HasSidecar})";
            }
        }
    }

}
