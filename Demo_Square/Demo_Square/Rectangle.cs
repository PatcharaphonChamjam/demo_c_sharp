using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Square
{
    public class Rectangle
    {
        public double width;
        public double height;

        public void SetDimension(double wvalue, double hvalue)
        {
            width = wvalue;
            height = hvalue;
        }

        public double Calculate()
        {
            return width * height;
        }
    }
}