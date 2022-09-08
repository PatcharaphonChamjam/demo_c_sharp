using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Polymorphism_15_2_Dog : Polymorphism_15_1_Animals
    {
        //กำหนด Method มีชื่อเหมือนกับ Base Class คือ Move ใช้คำสั้ง override
        public override void Move()
        {
            //แสดงผล Running on the ground
            Console.WriteLine("Dog : Running on the ground");
        }
    }
}