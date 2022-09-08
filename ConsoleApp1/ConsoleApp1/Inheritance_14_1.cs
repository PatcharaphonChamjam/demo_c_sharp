using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance_14_1
    {
        //กำหนดตัวแปร x Type int ,public
        public int x;
        //กำหนดตัวแปร y Type int ,public
        public int y;

        //กำหนด Constuctor รับค่า x และ Y ทีมี Type เป็น int
        public Inheritance_14_1 (int x, int y)
        {
            //กำหนดให้ค่า x ที่รับมา = x
            this.x = x;
            //กำหนดให้ค่า y ที่รับมา = x
            this.y = y;
        }

        //กำหนด Method GetArea มีการ Return ค่าเป็น double , public
        public double GetArea()
        {
            //กำหนดให้ Return x * y เมื่อมีการเรียกใช้ Method
            return x * y;
        }
    }
}
