using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Square
{
    public class Square
    {
        public double lenght;

        public void SetDimension(double value)
        {
            lenght = value;
        }

        public double Calculate()
        {
            return lenght * lenght;
        }
    }
}