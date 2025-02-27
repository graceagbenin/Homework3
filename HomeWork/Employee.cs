//Written by Grace Ofure Agbenin
//Feb 27, 2025

using System;


namespace HomeWork
{
    public class Employee
    {
        private string name = "n/a";
        private double salary = 0.0;

        // Gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        // Constructors
        public Employee(string aName, double aSalary)
        {
            this.name = aName;
            this.salary = aSalary;
        }

        public Employee() : this("n/a", 0.0)
        {
        }

        // Methods
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary:0.00}";
        }
    }

    // Subclass: Manager
    public class Manager : Employee
    {
        private int numberOfEmployeesManaged = 0;

        // Gets and sets
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        // Constructors
        public Manager(string name, double salary, int numberOfEmployeesManaged)
            : base(name, salary)
        {
            this.numberOfEmployeesManaged = numberOfEmployeesManaged;
        }

        // Methods
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary:0.00}, Number of Employees Managed: {NumberOfEmployeesManaged}";
        }
    }

    // Subclass: Engineer
    public class Engineer : Employee
    {
        private string specialization = "n/a";

        // Gets and sets
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        // Constructors
        public Engineer(string name, double salary, string specialization)
            : base(name, salary)
        {
            this.specialization = specialization;
        }

        // Methods
        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary:0.00}, Specialization: {Specialization}";
        }
    }

}
