using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  //Creates an 'instance' of the Car class by defining a new object.
            myCar.Make = "Ford";    //Lines 10-13 set the properties of the object.
            myCar.Model = "Taurus";
            myCar.Year = 2015;
            myCar.Color = "Green";

            Car myOtherCar = new Car();

            Console.WriteLine("{0} {1} {2} {3}",myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.WriteLine("{0} {1} {2} {3}",myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            Console.ReadLine();

        }
    }

    class Car //Establishes the 'Car' class, which holds 4 pieces of information about each Car object.
    {
        public string Make { get; set; }  //These define the properties of the class.
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()  //This CONSTRUCTOR is optional, but it allows the coder to set 1 or more default values. 
        {               //Parameters could be required as well.  Ex: Car(string make, string model), but these would have to be passed
            Make = "Tesla";     //into the class when a new instance is created.  So, Car myCar = new Car("Ford","F150").
            Model = "S75D";
            Year = 2017;
            Color = "Blue";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;            //This creates an 'OVERLOADED' constructor.  This allows more flexibility in calling a new Car class.
            Model = model;          //The new instance may or may not pass parameters into the class.  Both conditions will be allowed.
            Year = year;
            Color = color;
        }
    }
}
