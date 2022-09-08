using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Encapsulation_13
    {
        //กำหนดตัวแปร name มี Type เป็น string ,public
        public string name;
        //กำหนดตัวแปร radius มี Type เป็น int ,private
        private int radius;

        //กำหนด Method SetRadius รับค่า Int : ไม่มีการ Return ค่า : มี Access Modifier(การเข้าถึง)เป็น public
        public void SetRadius(int r)
        {
            //กำหนดให้ค่าที่รับมา เท่ากับ radius
            radius = r;
        }

        //กำหนด Method GetRadius Return ค่าเป็น int : มี Access Modifier(การเข้าถึง)เป็น public
        public int GetRadius()
        {
            //เมื่อมการเรียก Method จะ Return ค่า radius
            return radius;
        }
        //กำหนด Method GetSurfaceArea Return ค่าเป็น float : มี Access Modifier(การเข้าถึง)เป็น public
        public float GetSurfaceArea()
        {
            //เมื่อมการเรียก Method จะ Return ค่า 4 * (22/7.0f) * radius * radius
            return 4 * (22/7.0f) * radius * radius;
        }

    }

}
