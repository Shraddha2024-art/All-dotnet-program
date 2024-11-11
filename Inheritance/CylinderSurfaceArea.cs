using System;

namespace Inheritance
{
    class CylinderSurfaceArea

    {
        static void Main(string[] args)
        {
            // Input radius and height
            Console.Write("Enter the radius of the cylinder: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double surfaceArea = CalculateSurfaceArea(radius, height);

            Console.WriteLine($"The surface area of the cylinder is: {surfaceArea}");

            Console.ReadLine();
        }

        static double CalculateSurfaceArea(double radius, double height)
        {
            double surfaceArea = 2 * Math.PI * radius * (radius + height);
            return surfaceArea;
        }
    }
}
