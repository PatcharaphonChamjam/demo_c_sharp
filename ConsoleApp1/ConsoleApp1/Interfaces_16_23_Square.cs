using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Interfaces_16_23_Square : Interfaces_16_21, Interfaces_16_20
    {
        public double lenght;

        public void Draw()
        {
            Console.WriteLine("Draw square.");
        }

        public double getArea()
        {
            return Math.Pow(lenght, 2);
        }

        public void Draw3D()
        {
            Console.WriteLine("Draw cube");
        }

        // 6 sides surface area
        public double getSurfaceArea()
        {
            return 6 * getArea();
        }
    }
}