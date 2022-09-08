using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance_14_2 : Inheritance_14_1
    {
        //กำหนดตัวแปร z Type int ,publi
        public int z;

        //กำหนด Constuctor รับค่า x,y,z โดย x,y สืบทอดมาจาก class Inheritance_14_1
        public Inheritance_14_2(int x,int y,int z) : base(x,y)
        {
            //กำหนดให้ค่า z ที่รับมา = z
            this.z = z;
        }

        //กำหนด Method GetVolumn มีการ Return ค่าเป็น double , public
        public double GetVolumn()
        {
            //กำหนดให้ Return x * y * z เมื่อมีการเรียกใช้ Method (โดย x * y สืบทอดมาจาก class Inheritance_14_1)
            return base.GetArea() * z;
        }
    }
}
