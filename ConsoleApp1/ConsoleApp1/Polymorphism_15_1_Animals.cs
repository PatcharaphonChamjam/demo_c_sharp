using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    public class Polymorphism_15_1_Animals
    {
        //กำหนดตัวแปร name Type string ,public
        public string name;

        //กำหนดตัวแปร height Type int ,public
        public int height;

        //กำหนดตัวแปร weight Type int ,public
        public int weight;

        //กำหนด Method Result ให้สามารถ Override ได้โดยการใช้คำสั่ง virtual
        public virtual void Move()
        {
            //แสดงผล Perform base class move
            Console.WriteLine("Perform base class move");
        }
    }
}