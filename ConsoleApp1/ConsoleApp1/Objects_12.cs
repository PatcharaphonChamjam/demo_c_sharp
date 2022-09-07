using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Objects_12
    {
        public string name;
        public int width;
        public int height;

        public void setDimension(int w,int h)
        {
            width = w;
            height = h;

        }

        public int CalculateArea()
        {
            return width * height;
        }
        
    }

}
