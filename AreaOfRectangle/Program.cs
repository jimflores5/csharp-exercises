using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;

            Console.WriteLine("Eneter the length of the rectangle in cm:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Eneter the width of the rectangle in cm:");
            width = double.Parse(Console.ReadLine());
            area = length * width;
            Console.WriteLine($"The area of the rectangle is {area.ToString()} cm^2.");
            Console.ReadLine();
        }
    }
}
