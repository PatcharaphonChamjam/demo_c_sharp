using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance_14_22 : Inheritance_14_21
    {
        //กำหนด Method มีชื่อเหมือนกับ Base Class คือ Result ใช้คำสั้ง override 
        public override int Result()
        {
            //กำหนดให้ Return a * b เมื่อมีการเรียกใช้ Method
            return a * b;
        }
    }
}
