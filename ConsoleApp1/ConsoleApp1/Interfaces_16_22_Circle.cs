using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Interfaces_16_22_Circle : Interfaces_16_21, Interfaces_16_20
    {
        public double radius;
        private const double PI = 3.14;

        public void Draw()
        {
            Console.WriteLine("Draw circle.");
        }

        public double getArea()
        {
            return PI * Math.Pow(radius, 2);
        }

        public void Draw3D()
        {
            Console.WriteLine("Draw sphere.");
        }

        // formular: 4 * PI * (r ^ 2)
        public double getSurfaceArea()
        {
            return 4 * getArea();
        }
    }
}