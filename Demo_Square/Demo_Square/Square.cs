using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Square
{
    public class Square
    {
        public double length;

        public void SetDimension(double value)
        {
            length = value;
        }

        public double Calculate()
        {
            return length * length;
        }
    }
}