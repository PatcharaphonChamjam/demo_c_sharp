using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        //TODO สร้าง class ตามหัวข้อ 1 - 12
        //TODO สร้าง Method ใน Class ที่สร้างตามหัวข้อ
        //TODO เรียกใช้ Method จาก Class ต่างๆใน Program.cs

        //TODO Comment Code Every Line
        //Group Code in Main 

        static void Main(string[] args)
        {
            //การแสดงข้อความ Start พร้อมกับ DateTime ปัจจุบัน
            Console.WriteLine("Start :{0}", DateTime.Now);

            /*-----------------------------------------------
                Chapter 3 :: ตัวแปรและประเภทข้อมูล
            ------------------------------------------------*/
            //สร้าง obj ใหม่จาก class VariableAndDataType_3
            VariableAndDataType_3 variableAndData = new VariableAndDataType_3();
            // เรียก Method --การตั้งค่าตัวแปร
            variableAndData.VariableDeclaration();
            // เรียก Method --Boolean กำหนดค่าเป็น True
            variableAndData.Boolean();
            // เรียก Method --กำหนดค่า Interger
            variableAndData.IntegerNumberType();
            //DoubleNumberType

/*            //ตัวอย่าง  If else
            //สร้าง obj ใหม่จาก class SelectionStatement
            SelectionStatement_7 selectionStatement = new SelectionStatement_7();
            //เรียก Method IfElse
            selectionStatement.IfElse();
            //เรียก Method 
            selectionStatement.SwitchCase();
            //get ค่าจาก Props ใส่ตัวแปร
            int myProp = selectionStatement.MyPropertyTest;
            //แสดงค่าจากตัวแปร
            Console.WriteLine(myProp);
            //set ค่ากลับไปที่ Props
            selectionStatement.MyPropertyTest=100;
            //แสดงค่าจาก Props
            Console.WriteLine(selectionStatement.MyPropertyTest);*/

            //Array_9 array_9 = new Array_9();
            //array_9.JaggedArray();

            //ทำให้หน้าจอค้างไว้ เมื่อประมวนผลเสร็จ
            Console.ReadKey();
        }

       


    }

}
