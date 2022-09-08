using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
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
            /*Console.WriteLine("--------Chapter 4 :: Constants----------");
            //สร้าง obj ใหม่จาก class Constants_4
            Constants_4 constants = new Constants_4();
            // เรียก Method --กำหนดค่าของค่าคงที่ (Constants)
            constants.ConstantsDeclaration();

            Console.WriteLine("------------------");
            // เรียก Method --กำหนดค่าของค่าคงที่ (Constants) ใน Array
            constants.ConstantsArray();*/

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
            /*Console.WriteLine("--------Chapter 6 :: Input Output----------");
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

            /*-----------------------------------------------
                Chapter 12 :: Object
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 12 :: Object----------");
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
            Console.WriteLine("Object " + objects2.name + " has area = " + objects2.CalculateArea() + " in ^ 2");*/

            /*-----------------------------------------------
                Chapter 13 :: Encapsulation การห่อหุ้ม
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 13 :: Encapsulation----------");
            //สร้าง obj ใหม่จาก Class Encapsulation_13
            Encapsulation_13 encapsulation = new Encapsulation_13();
            //กำหนดค่า Mars ในตัวแปร name ใน Class Encapsulation_13
            encapsulation.name = "Mars";
            //กำหนดค่า 3390 ในตัวแปร radius ใน Method SetRadius จาก Class Encapsulation_13
            encapsulation.SetRadius(3390);

            //แสดงค่า Planet name = Mars
            Console.WriteLine("Planet name = " + encapsulation.name);
            //แสดงค่า Radius = 3390 km
            Console.WriteLine("Radius = " + encapsulation.GetRadius() + " km");
            //แสดงค่า Surface area ~144.472112 million square km
            Console.WriteLine("Surface area ~" +encapsulation.GetSurfaceArea() /10E5 + " million square km");*/

            /*-----------------------------------------------
                Chapter 14 :: Inheritance การสืบทอดอำนาจ
            ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 14 :: Inheritance----------");
            //สร้าง obj ใหม่จาก Class Inheritance_14_1
            Inheritance_14_11 baseclass = new Inheritance_14_11(3, 4);
            //แสดงค่า Rectangle 1
            Console.WriteLine("Rectangle 1");
            //แสดงค่า size [3,4]
            Console.WriteLine("size [{0},{1}]", baseclass.x, baseclass.y);
            //แสดงค่า Area = 12
            Console.WriteLine("Area = {0}", baseclass.GetArea());

            Console.WriteLine("------------------");
            //สร้าง obj ใหม่จาก Class Inheritance_14_1
            Inheritance_14_12 deliveredclass1 = new Inheritance_14_12(5, 4, 3);
            //แสดงค่า Cuboid 1
            Console.WriteLine("Cuboid 1");
            //แสดงค่า size [5,4,3]
            Console.WriteLine("size [{0},{1},{2}]", deliveredclass1.x, deliveredclass1.y, deliveredclass1.z);
            //แสดงค่า Volumn = 60
            Console.WriteLine("Volumn = {0}", deliveredclass1.GetVolumn());

            Console.WriteLine("------------------");
            //สร้าง obj ใหม่จาก Class Inheritance_14_1
            Inheritance_14_12 deliveredclass2 = new Inheritance_14_12(10, 10, 10);
            //แสดงค่า Cuboid 2
            Console.WriteLine("Cuboid 2");
            //แสดงค่า size [10,10,10]
            Console.WriteLine("size [{0},{1},{2}]", deliveredclass2.x, deliveredclass2.y, deliveredclass2.z);
            //แสดงค่า Volumn = 1000
            Console.WriteLine("Volumn = {0}", deliveredclass2.GetVolumn());

            Console.WriteLine("------------------");
            //สร้าง obj ใหม่จาก Class Inheritance_14_21
            Inheritance_14_21 plusnumber = new Inheritance_14_21();
            //กำหนดค่า 1 ในตัวแปร a
            plusnumber.a = 1;
            //กำหนดค่า 2 ในตัวแปร b
            plusnumber.b = 2;
            //แสดงผล 1 + 2 = 3
            Console.WriteLine("{0} + {1} = {2}", plusnumber.a, plusnumber.b, plusnumber.Result());

            Console.WriteLine("------------------");
            //สร้าง obj ใหม่จาก Class Inheritance_14_22
            Inheritance_14_22 multiply = new Inheritance_14_22();
            //กำหนดค่า 2 ในตัวแปร a
            multiply.a = 2;
            //กำหนดค่า 3 ในตัวแปร b
            multiply.b = 3;
            //แสดงผล 2 * 3 = 6
            Console.WriteLine("{0} * {1} = {2}", multiply.a, multiply.b, multiply.Result());*/

            /*-----------------------------------------------
               Chapter 15 :: Inheritance การสืบทอดอำนาจ
           ------------------------------------------------*/
            /*Console.WriteLine("--------Chapter 15 :: Inheritance----------");

            //สร้าง obj ใหม่จาก Class Polymorphism_15_0
            Polymorphism_15_0 polymorphism = new Polymorphism_15_0();
            //เรียกใช้ Method PolomorphismMove
            polymorphism.PolomorphismMove();

            Console.WriteLine("------------------");
            //เรียกใช้ Method PolomorphismMoveArray
            polymorphism.PolomorphismMoveArray();*/

            /*-----------------------------------------------
                Chapter 16 :: Interfaces
            ------------------------------------------------*/
            Console.WriteLine("--------Chapter 16 :: Interfaces----------");
            Interfaces_16_12_Cars car = new Interfaces_16_12_Cars();
            car.StartEngine();
            car.Move();

            Console.WriteLine("------------------");
            Interfaces_16_13_Boat boat = new Interfaces_16_13_Boat();
            boat.StartEngine();
            boat.Move();

            //ทำให้หน้าจอค้างไว้ เมื่อประมวนผลเสร็จ
            Console.ReadKey();
        }
    }
}