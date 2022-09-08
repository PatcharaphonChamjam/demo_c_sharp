using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operators_5
    {
        public void ArithmeticOperators()
        {
            //กำหนดค่า 10 ให้ตัวแปร a Type int
            int a = 10;
            //กำหนดค่า 3 ให้ตัวแปร b Type int
            int b = 3;
            //กำหนดค่า 2.0 ให้ตัวแปร c Type float
            float c = 2.0f;

            //แสดงค่า a + b = 13
            Console.WriteLine("a + b = " + (a + b));
            //แสดงค่า a - b = 7
            Console.WriteLine("a - b = " + (a - b));
            //แสดงค่า a * c = 20
            Console.WriteLine("a * c = " + (a * c));
            //แสดงค่า a / c = 5
            Console.WriteLine("a / c = " + (a / c));
            //แสดงค่า a % c = 0
            Console.WriteLine("a % c = " + (a % c));

        }

        public void RelationComparison()
        {
            //กำหนดค่า 10 ให้ตัวแปร n Type int
            int n = 10;
            //กำหนดเงื่อนไข n%2 ลงตัว หรือเปล่าถ้าหากลงตัวจะเข้าเงื่อนไข
            if (n%2 == 0)
            {
                //แสดงค่า n is even number
                Console.WriteLine("n is even number");
            }
            //กำหนดค่า 6 ให้ตัวแปร x Type int
            //กำหนดค่า 2 ให้ตัวแปร y Type int
            int x = 6, y = 2;
            //กำหนดเงื่อนไขถ้าหาก x น้อยกว่า y
            if(x < y)
            {
                //แสดงค่า x is less than y
                Console.WriteLine("x is less than y");
            }
        }

        public void LogicalOperation()
        {
            //กำหนดค่า 3 == 4 ให้ตัวแปร a Type bool
            bool a = (3 == 4);
            //กำหนดค่า 3 != 4 ให้ตัวแปร b Type bool
            bool b = (3 != 4);
            //กำหนดค่า 3 < 5 ให้ตัวแปร c Type bool
            bool c = (3 < 5);
            //กำหนดค่า a && b ให้ตัวแปร d Type bool
            bool d = a && b;
            //กำหนดค่า !d ให้ตัวแปร e Type bool
            bool e = !d;

            //แสดงค่า a = False
            Console.WriteLine("a = " + a);
            //แสดงค่า b = True
            Console.WriteLine("b = " + b);
            //แสดงค่า c = True
            Console.WriteLine("c = " + c);
            //แสดงค่า d = False
            Console.WriteLine("d = " + d);
            //แสดงค่า e = True
            Console.WriteLine("e = " + e);
        }

        public void LogicalOperation2()
        {
            //กำหนดค่า 20 ให้ตัวแปร age Type int
            int age = 20;
            //กำหนดค่า 100 ให้ตัวแปร money Type int
            int money = 100;

            //กำหนดเงื่อนไขถ้าหาก age มากกว่าหรือเท่ากับ 18 และ money มากกว่าหรือเท่ากับ 120 
            if (age >= 18 && money >=120)
            {
                //แสดงผล You can buy a game.
                Console.WriteLine("You can buy a game.");
            }
            //กำหนดเงื่อนไขถ้าหาก age มากกว่าหรือเท่ากับ 18 หรือ money มากกว่าหรือเท่ากับ 500
            if (age >= 18 || money >=500)
            {
                //แสดงผล You can buy a movie.
                Console.WriteLine("You can buy a movie.");
            }
        }

        public void TernaryOperator()
        {
            //กำหนดค่า NY ให้ตัวแปร cc Type string
            string cc = "NY";
            //แสดงค่า โดยการกำหนดเงื่อนไข cc == "NY"? ถ้าหากเป็นจริงแสดง New York ถ้าหากไม่เป็นจริงแสดง Other states
            Console.WriteLine(cc == "NY"? "New York" : "Other states");
        }
    }
}
