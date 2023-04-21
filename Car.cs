using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ConstructorsMethodsOverloading
{
    internal class Car
    {
        //Fields
        protected string make;
        protected string model;
        protected int year;
        protected int mileage;

        //properties
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public int Mileage { get => mileage; set => mileage = value; }

        //3 Constructors using overloading
        public Car()
        {
            Make = "unassigned";
            Model = "unassigned";
            Year = 0;
            Mileage = 0;
        }
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Year = 0;
            Mileage = 0;
        }

        public Car(string make, string model, int year, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        //override to string
        public override string ToString()
        {
            return $"{year} {make} {model} Mileage: {mileage}";
        }
    }
}
