using System;
using System.Collections.Generic;
using System.Text;

namespace CarObjectDemo
{
    public class ElectricCar : Car
    {
        public int BatterySize { get; private set; }
        public double ChargeLeft { get; private set; }
        public double MilesPerkWh { get; private set; }

        public ElectricCar(string make, string model, int batterySize, double mpkwh) : base(make, model) //This is the constructor.
        {
            this.BatterySize = batterySize;
            this.ChargeLeft = batterySize;
            this.MilesPerkWh = mpkwh;
        }

        public override void Drive(int miles)
        {
            //TODO: Adjust chage based on efficiency.
            //TODO: Write out distance traveled and charge level left.
            double maxDistance = Math.Round(this.MilesPerkWh * this.ChargeLeft,2);
            double distanceTraveled = miles;
            double kWhUsed;

            if (miles > maxDistance)
            {
                distanceTraveled = maxDistance;
            }
            kWhUsed = Math.Round(distanceTraveled / this.MilesPerkWh,2);
            this.ChargeLeft = Math.Round(this.ChargeLeft - kWhUsed,2);

            var text = String.Format("Traveled {0} miles.  Charge used = {1} kWh.  Charge remaining = {2} kWh.", distanceTraveled, kWhUsed, this.ChargeLeft);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
