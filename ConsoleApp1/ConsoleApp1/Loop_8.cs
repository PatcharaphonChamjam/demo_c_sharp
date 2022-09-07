using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Loop_8
    {
        public void WhileLoop()
        {
            int n = 1;
            //กำหนด Loop while โดยมีเงื่อนไข น้อยกว่าหรือเท่ากับ 10
            while(n <= 10)
            {
                //แสดงค่า Loop + n เช่น Loop 1 
                Console.WriteLine("Loop " + n);
                //ให้เพิ่มค่า n เรื่อยๆ
                n++;
            }
            //แสดงค่า Loop ended
            Console.WriteLine("Loop ended");
        }

        public void DoWhile()
        {
            int n;
            //แสดงค่า Enter 0 to exit the loop
            Console.WriteLine("Enter 0 to exit the loop");
            do
            {
                //แสดงค่า Your number:
                Console.Write("Your number: ");
                //รับค่าจาก integer จาก Keyboard 
                int.TryParse(Console.ReadLine(), out n);
                //แสดงค่า "Number your entered is + n
                Console.WriteLine("Number your entered is "+n);
            //ใส่เงื่อน n ต้องไม่เท่ากับ 0
            }while(n != 0);
            //แสดงค่า Loop Ended:
            Console.WriteLine("Loop Ended");
        }

        public void ForLoop()
        {
            //กำหนด Loop 
            for(int i = 0; i < 10; i++)
            {
                //แสดงค่า Loop ตามที่กำหนด 0 - 9
                Console.WriteLine(i);
            }
        }

        public void ForLoop2()
        {
            int i = 1;
            //กำหนดเงื่อนไข ให้ i น้อยกว่าหรือเท่ากับ 10
            for (;i <= 10;)
            {
                //แสดงค่า Loop ตามที่กำหนด 1 - 10
                Console.WriteLine(i);
                //ให้เพิ่มค่า i เรื่อยๆ
                i++;
            }
        }

        public void ForeachLoop()
        {
            //กำหนด ค่าใน Array numbers
            int[] numbers = {2, 4, -1, 5, 0, 8, 9};
            foreach(int i in numbers)
            {
                //แสดงค่า i
                Console.WriteLine(i);
            }    
        }

        public void Break()
        {
            //กำหนด Loop 
            for (int i = 1; i<=10; i++)
            {
                //แสดงค่า i
                Console.WriteLine(i);
                //ใส่เงื่อนไข ถ้า i เท่ากับ 5 ให้หยุด
                if(i ==5) break;
            }
        }

        public void Continue()
        {
            //กำหนด Loop 
            for (int i = 0; i <= 10; i++)
			{
                //ใส่เงื่อนไข ถ้า i % 2 ลงตัว ให้ข้าม ออกจาก Loop
                if (i % 2 == 0) continue;
                //แสดงค่า i
                Console.WriteLine(i);
			}
        }

    }
}
