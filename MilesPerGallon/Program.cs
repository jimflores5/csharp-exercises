using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance;
            float gasUsed;
            double mpg;

            Console.WriteLine("Eneter the distance driven (in miles):");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Eneter the number of gallons of gas used:");
            gasUsed = float.Parse(Console.ReadLine());
            mpg = Math.Round(distance/gasUsed, 1);
            //mpg = distance/gasUsed;
            Console.WriteLine($"Your fuel economy is {mpg.ToString()} miles per gallon.");
            Console.ReadLine();
        }
    }
}
