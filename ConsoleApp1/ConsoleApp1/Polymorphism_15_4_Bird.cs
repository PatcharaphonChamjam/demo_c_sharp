using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Polymorphism_15_4_Bird : Polymorphism_15_1_Animals
    {
        //กำหนด Method มีชื่อเหมือนกับ Base Class คือ Move ใช้คำสั้ง override
        public override void Move()
        {
            //แสดงผล Flying in the air
            Console.WriteLine("Bird : Flying in the air");
        }
    }
}