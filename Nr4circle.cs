using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr4
{
    public class Circle
    {
        // Private field for the radius of the circle
        private double _radius;

        // Constructor to initialize the radius
        public Circle(double radius)
        {
            _radius = radius;
        }

        // Calculated property for Area
        public double Area
        {
            get
            {
                return Math.PI * _radius * _radius;  // Area = π * r^2
            }
        }

        // Method to display the radius and area of the circle
        public void DisplayInfo()
        {
            Console.WriteLine($"Radius: {_radius}, Area: {Area}");
        }
    }
}
