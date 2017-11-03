using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;
            double area;

            //Console.WriteLine("Enter the radius of the circle in cm:");
            //radius = float.Parse(Console.ReadLine());

            radius = -1;
            while (radius < 0)
            {
                Console.WriteLine("Enter the radius of the circle in cm:");
                radius = float.Parse(Console.ReadLine());
                if (radius > 0)
                {
                    break;
                }
                Console.WriteLine("Radius cannot be negative, you FOOL!");
                Console.WriteLine();
            }
            
            area = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            Console.WriteLine($"The area of the circle is {area.ToString()} cm^2.");
            Console.ReadLine();
            
        }
    }
}
