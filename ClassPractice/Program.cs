using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  //Creates an 'instance' of the Car class by defining a new object.
            myCar.Make = "Ford";
            myCar.Model = "Taurus";
            myCar.Year = 2015;
            myCar.Color = "Green";

        }
    }

    class Car //Establishes the 'Car' class, which holds 4 pieces of information about each Car object.
    {
        public string Make { get; set; }  //These define the properties of the class.
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
