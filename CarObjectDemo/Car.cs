using System;
using System.Collections.Generic;
using System.Text;

namespace CarObjectDemo
{
    public abstract class Car
    {
        public string Make { get; private set; } // Can only set the make and model from inside the Car class.
        public string Model { get; private set; }

        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public abstract void Drive(int miles);
    }
}
