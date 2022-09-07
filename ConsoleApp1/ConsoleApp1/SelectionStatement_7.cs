using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SelectionStatement_7
    {
        //ประกาศ public Property เป็น int มีค่าเท่ากับ 10
        public int MyPropertyTest { get; set; } = 10;

        public void IfElse()
        {
            //การประกาศค่าตัวแปร 
            int score;
            //การแสดงค่า Enter your score 
            Console.Write("Enter your score: ");
            //การรับค่าจาก Keyboard แสดงผลเป็น int
            int.TryParse(Console.ReadLine(), out score);

            //ใช้เงื่อนไข ถ้าหากคะแนนมากกว่าหรือเท่ากับ 80
            if (score >= 80)
            {
                //แสดงค่า Your grade is A ถ้าหากคะแนนมากกว่า 80
                Console.WriteLine("Your grade is A");
            }
            //ใช้เงื่อนไข ถ้าหากคะแนนมากกว่าหรือเท่ากับ 70
            else if (score >= 70)
            {
                //แสดงค่า Your grade is B ถ้าหากคะแนนมากกว่า 70
                Console.WriteLine("You grade is B");
            }
            //ใช้เงื่อนไข ถ้าหากคะแนนมากกว่าหรือเท่ากับ 60
            else if (score >= 60)
            {
                //แสดงค่า Your grade is C ถ้าหากคะแนนมากกว่า 60
                Console.WriteLine("Your grade id C");
            }
            //ใช้เงื่อนไข ถ้าหากคะแนนมากกว่าหรือเท่ากับ 50
            else if (score >= 50)
            {
                //แสดงค่า Your grade is D ถ้าหากคะแนนมากกว่า 50
                Console.WriteLine("Your grade is D");
            }
            //ใช้เงื่อนไข ถ้าหากไม่เข้าเงื่อนไขด้านบน
            else
            {
                //แสดงค่า "You Fall
                Console.WriteLine("You Fall");
            }
        }

        public void SwitchCase()
        {
            //การประกาศค่าตัวแปร
            int n = 1;
            //เข้าเงื่อนไข switch โดยมี inputValue เท่ากับ n ซึ่งเท่ากับ 1
            switch (n)
            {
                //ถ้าหาก n=1 
                case 1:
                    //แสดงค่า Case 1
                    Console.WriteLine("Case 1");
                    //หยุดการดำเนินการ
                    break;
                //ถ้าหาก n=2
                case 2:
                    //แสดงค่า Case 2
                    Console.WriteLine("Case 2");
                    //หยุดการดำเนินการ
                    break;
                //ถ้าหากไม่เข้าเงื่อนไขด้านบนจะเข้า case default 
                default:
                    //แสดงค่า Default case
                    Console.WriteLine("Default case");
                    //หยุดการดำเนินการ
                    break;
            }
        }





    }
    
}
