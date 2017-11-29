using System;
using System.Collections.Generic;
using System.Text;

namespace CarObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create different cars and "drive" them.

            //Car myCar = new Car("Ford", "Mustang"); This line would not work since the Car class is set as 'abstract'.
            GasCar mTcar = new GasCar("Ford", "Model T", 15, 8);
            mTcar.Drive(75);
            mTcar.Drive(15);

            ElectricCar leaf = new ElectricCar("Nissan", "Leaf", 24, 5.2);
            leaf.Drive(36);
            leaf.Drive(88);
 
        }
    }
}
