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
            //set ค่า Input : width
            width = w;
            //set ค่า Input : height
            height = h;

        }

        public int CalculateArea()
        {
            //เมื่อมีการเรียกใช้ Method จะ Return ค่า width * height
            return width * height;
        }
        
    }

}
