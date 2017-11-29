using System;
using System.Collections.Generic;
using System.Text;

namespace CarObjectDemo
{
    public class GasCar : Car
    {
        public int GasTankSize { get; private set; }
        public double GasTankLevel { get; private set; }
        public double MPG { get; private set; }

        public GasCar(string make, string model, int gasTankSize, double mpg) : base(make, model) //This is the constructor.
        {
            this.GasTankSize = gasTankSize;
            this.GasTankLevel = gasTankSize;
            this.MPG = mpg;
        }

        public override void Drive(int miles)
        {
            //TODO: Adjust fuel based on mpg.
            //TODO: Write out distance traveled and fuel level left.
            double maxDistance = this.MPG * this.GasTankLevel;
            double distanceTraveled = miles;
            double fuelUsed;

            if (miles > maxDistance)
            {
                distanceTraveled = maxDistance;
            }
            fuelUsed = Math.Round(distanceTraveled / this.MPG,2);
            this.GasTankLevel = this.GasTankLevel - fuelUsed;

            var text = String.Format("Traveled {0} miles.  Gallons used = {1}.  Gallons remaining = {2}.", distanceTraveled, fuelUsed, this.GasTankLevel);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
