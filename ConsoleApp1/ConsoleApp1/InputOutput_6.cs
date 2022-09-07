using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InputOutput_6
    {
        public void WriteConsole()
        {
            //แสดงผลแบบไม่ขึ้นบรรทัดใหม่ Hello Java
            Console.Write("Hello Java");
            //แสดงผลแบบไม่ขึ้นบรรทัดใหม่ Hello C#
            Console.Write("Hello C#");
            //แสดงผลแบบไม่ขึ้นบรรทัดใหม่ Hello C++
            Console.Write("Hello C++");
        }

        public void WriteLine()
        {
            //แสดงผลแบบไม่ขึ้นบรรทัดใหม่ Hello C# ใช้ Method Write ใช้ \n
            Console.Write("Hello C#\n");
            //แสดงผลแบบขึ้นบรรทัดใหม่ Hello C#
            Console.WriteLine("Hello C#");
        }

        public void WriteLineVariable()
        {
            //กำหนดค่า Marcus ให้ตัวแปร name Type string
            string name = "Marcus";
            //กำหนดค่า Pop ให้ตัวแปร music Type string
            string music = "Pop";
            //กำหนดค่า science ให้ตัวแปร movie Type string
            string movie = "science";

            //แสดงค่า My name is Marcus
            Console.WriteLine("My name is {0}.",name);
            //แสดงค่า Pop is my favorite music style and science is movie style
            Console.WriteLine("{0} is my favorite music style and {1} is movie style",music,movie);
        }

        public void Read()
        {
            //แสดงค่า Enter for tes Method Console.Read():
            Console.WriteLine("Enter for tes Method Console.Read(): ");
            //รับค่าจาก Keyboard แสดงผลเป็นค่า Integer ของตัวอักษร
            Console.WriteLine(Console.Read());
        }

        public void ReadLine()
        {
            //กำหนดตัวแปร name Type string
            string name;
            //กำหนดตัวแปร age Type int
            int age;
            //กำหนดตัวแปร height Type double
            double height;

            //แสดงค่า Enter name :
            Console.Write("Enter name :");
            //กำหนด Console.ReadLine() ให้ตัวแปร name
            name = Console.ReadLine();
            //แสดงค่า Enter age :
            Console.Write("Enter age :");
            //รับค่าจาก Keyboard แปลงค่าจาก String เป็น int 
            int.TryParse(Console.ReadLine(), out age);
            //แสดงค่า Enter height :
            Console.Write("Enter height :");
            //รับค่าจาก Keyboard แปลงค่าจาก String เป็น double 
            double.TryParse(Console.ReadLine(), out height);

            //แสดงค่า Name : 
            Console.WriteLine("Name: " + name);
            //แสดงค่า Age : 
            Console.WriteLine("Age: {0}", age);
            //แสดงค่า Height : 
            Console.WriteLine("Height: {0}", height);

        }
    }
}
