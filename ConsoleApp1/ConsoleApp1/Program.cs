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
            /*Console.WriteLine("--------Chapter 3 :: VariableAndDataType----------");
            //สร้าง obj ใหม่จาก class VariableAndDataType_3
            VariableAndDataType_3 variableAndData = new VariableAndDataType_3();
            // เรียก Method --การตั้งค่าตัวแปร
            variableAndData.VariableDeclaration();
            
            Console.WriteLine("------------------");
            // เรียก Method --Boolean กำหนดค่าเป็น True
            variableAndData.Boolean();
            
            Console.WriteLine("------------------");
            // เรียก Method --กำหนดค่า Interger
            variableAndData.IntegerNumberType();
            
            Console.WriteLine("------------------");
            //DoubleNumberType
            variableAndData.DoubleNumberType();*/


             /*-----------------------------------------------
                Chapter 4 :: ค่าคงที่
            ------------------------------------------------*/
            /* Console.WriteLine("--------Chapter 4 :: Constants----------");
             //สร้าง obj ใหม่จาก class Constants_4
            Constants_4 constants = new Constants_4();
            // เรียก Method --กำหนดค่าของค่าคงที่ (Constants)
            constants.ConstantsDeclaration();*/
            
            //Console.WriteLine("------------------");
            // เรียก Method --กำหนดค่าของค่าคงที่ (Constants) ใน Array
            //constants.ConstantsArray();
            

            /*-----------------------------------------------
                Chapter 5 :: ตัวดำเนินการ
            ------------------------------------------------*/
             /*Console.WriteLine("--------Chapter 5 :: Operators----------");
             //สร้าง obj ใหม่จาก class Operators_5
             Operators_5 operators5 = new Operators_5();
            // เรียก Method --ตัวดำเนินการทางคณิตศาสตร (บวก ลบ คูณ หาร)
            operators5.ArithmeticOperators();

            Console.WriteLine("------------------");
            // เรียก Method --การเปรียบเทียบความสัมพันธ์ แสดงผลเป็น True กับ False
            operators5.RelationComparison();

            Console.WriteLine("------------------");
            // เรียก Method --การดำเนินการเชิงตรรก 
            operators5.LogicalOperation();

            Console.WriteLine("------------------");
             // เรียก Method --การดำเนินการเชิงตรรก เพิ่มเติม
            operators5.LogicalOperation2();

            Console.WriteLine("------------------");
             // เรียก Method --การใช้เงื่อนไข Ternary ถ้าหาก True จะแสดงผล Index 0 ถ้า Flase จะแสดง Index 1
            operators5.TernaryOperator();*/
           

            /*-----------------------------------------------
                Chapter 6 :: Input Output
            ------------------------------------------------*/
            /* Console.WriteLine("--------Chapter 6 :: Input Output----------");
            //สร้าง obj ใหม่จาก class InputOutput_6
            InputOutput_6 inputOutput = new InputOutput_6();
            // เรียก Method --การแสดงผลข้อความ แบบไม่่ขึ้นบรรทัดใหม่
            inputOutput.WriteConsole();

            Console.WriteLine("------------------");
            // เรียก Method --การแสดงผลข้อความ แบบขึ้นบรรทัดใหม่
            inputOutput.WriteLine();

            Console.WriteLine("------------------");
            // เรียก Method --การแสดงผลข้อความ แบบขึ้นบรรทัดใหม่ โดยการอ้างอิงตัวแปร
            inputOutput.WriteLineVariable();

            Console.WriteLine("------------------");
            // เรียก Method --การรับค่า Keyboard แบบ int
            inputOutput.Read();

            Console.WriteLine("------------------");
            // เรียก Method --การรับค่า Keyboard 
            inputOutput.ReadLine();*/


            /*-----------------------------------------------
                Chapter 7 :: If Else and Switch Case
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 7 :: if else and switch case----------");
           //ตัวอย่าง  If else
            //สร้าง obj ใหม่จาก class SelectionStatement_7
            SelectionStatement_7 selectionStatement = new SelectionStatement_7();
            //เรียก Method IfElse
            selectionStatement.IfElse();

            Console.WriteLine("------------------");
            //เรียก Method 
            selectionStatement.SwitchCase();

            Console.WriteLine("------------------");
            //get ค่าจาก Props ใส่ตัวแปร
            int myProp = selectionStatement.MyPropertyTest;
            //แสดงค่าจากตัวแปร
            Console.WriteLine(myProp);
            //set ค่ากลับไปที่ Props
            selectionStatement.MyPropertyTest=100;
            //แสดงค่าจาก Props
            Console.WriteLine(selectionStatement.MyPropertyTest);*/


            /*-----------------------------------------------
                Chapter 8 :: การวนซ้ำ Loop 
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 8 :: Loop----------");
            //สร้าง obj ใหม่จาก class ILoop_8nputOutput_6
            Loop_8 loop = new Loop_8();
            // เรียก Method --วนลูป While
            loop.WhileLoop();

            Console.WriteLine("------------------");
            // เรียก Method --วนลูป DoWhile
            loop.DoWhile();

            Console.WriteLine("------------------");
            // เรียก Method --วนลูป For
            loop.ForLoop();

            Console.WriteLine("------------------");
            // เรียก Method --วนลูป For เพิ่มเติม
            loop.ForLoop2();

            Console.WriteLine("------------------");
            // เรียก Method --วนลูป Foreach
            loop.ForeachLoop();

            Console.WriteLine("------------------");
            // เรียก Method --การ Break วนลูป 10 ครั้งแต่ break ที่ 5
            loop.Break();

            Console.WriteLine("------------------");
            // เรียก Method --การข้ามการวนซ้ำ ในรอบปัจจุบัน
            loop.Continue();*/


            /*-----------------------------------------------
                Chapter 9 :: Array
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 9 :: Array----------");
            //สร้าง obj ใหม่จาก class Array_9
            Array_9 array_9 = new Array_9();
            // เรียก Method --การสร้าง Array 1
            array_9.Array1Dimention();

            Console.WriteLine("------------------");
            // เรียก Method --การสร้าง Array 1 มิติ จาก For Loop
            array_9.ForLoopArray1Dimention();

            Console.WriteLine("------------------");
            // เรียก Method --การสร้าง Array 2 มิติ
            array_9.Array2Dimention();

            Console.WriteLine("------------------");
            // เรียก Method --การสร้าง Array 2 มิติ จาก For Loop
            array_9.ForLoopArray2Dimention();

            Console.WriteLine("------------------");
            // เรียก Method --การสร้าง JaggedArray
            array_9.JaggedArray();

            Console.WriteLine("------------------");
            // เรียก Method --การสร้าง JaggedArray เพิ่มเติม
            array_9.JaggedArray2();*/


            /*-----------------------------------------------
                Chapter 10 :: Method
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 10 :: Method----------");
            //สร้าง  obj ใหม่จาก class Method_10
            Method_10 method = new Method_10();
            //เรียก Method --การสร้าง Method
            method.CreatingMethod();

            Console.WriteLine("------------------");
            //เรียก Method --การสร้าง Method เพิ่มเติม
            method.CreatingMethod2();*/



            /*-----------------------------------------------
                 Chapter 11 :: Class
             ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 11 :: Class----------");
            Class_11 class_11 = new Class_11();
            class_11.Run();*/


            /*-----------------------------------------------
                Chapter 12 :: Object
            ------------------------------------------------*/
            Console.WriteLine("--------Chapter 12 :: Object----------");
            //สร้าง obj ใหม่จาก Class Objects_12
            Objects_12 objects = new Objects_12();
            //Assisgh ค่า Paper ให้ name
            objects.name = "Paper";
            //Assisgh ค่า width = 8 ,height = 11 
            objects.setDimension(8,11);

            //สร้าง obj ใหม่จาก Class Objects_12
            Objects_12 objects2 = new Objects_12();
            //Assisgh ค่า Computer Screen ให้ name
            objects2.name = "Computer Screen";
            //Assisgh ค่า width = 16 ,height = 9
            objects2.setDimension(16,9);

            //ให้แสดงค่า Object Paper has area = 88 in ^ 2
            Console.WriteLine("Object " + objects.name + " has area = " + objects.CalculateArea() + " in ^ 2");
            //ให้แสดงค่า Object Computer Acreen has area = 144 in ^ 2
            Console.WriteLine("Object " + objects2.name + " has area = " + objects2.CalculateArea() + " in ^ 2");


            //ทำให้หน้าจอค้างไว้ เมื่อประมวนผลเสร็จ
            Console.ReadKey();
        }

       


    }

}
