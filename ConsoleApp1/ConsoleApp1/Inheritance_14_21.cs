using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inheritance_14_21
    {
        //กำหนดตัวแปร a Type int ,public
        public int a;
        //กำหนดตัวแปร b Type int ,public
        public int b;

        //กำหนด Method Result ให้สามารถ Override ได้โดยการใช้คำสั่ง virtual
        public virtual int Result()
        {
            //กำหนดให้ Return a + b เมื่อมีการเรียกใช้ Method
            return a + b;   
        }
    }
}
