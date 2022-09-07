using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Method_10
    {
        public void CreatingMethod()
        {
            //กำหนดค่า Marcus ลงใน name ที่มี Type เป็น String
            string name = "Marcus";
            //กำหนดค่า 0 ลงใน sex ที่มี Type เป็น int 
            int sex = 0;
            //กำหนดค่า hockey ลงใน sport ที่มี Type เป็น String 
            string sport = "hockey";

            //เรียกใช้ Method โดย input ค่า name,sex,sport
            displayBio(name,sex,sport);
        }

        public void displayBio(string n,int s,string sp)
        {
            //ใส่เงื่อนไข ถ้าหาก S = 0 
            if(s == 0)
            {
                //จะแสดง ข้อความเป็น name + has + sport + as his favorite sport
                Console.WriteLine(n + " has " + sp + " as his favorite sport.");
            }
            else
            {
                //จะแสดง ข้อความเป็น name + has + sport + as her favorite sport
                Console.WriteLine(n + " has " + sp + " as her favorite sport.");
            }
        }

        public void CreatingMethod2()
        {
            int a = 10;
            int b = 25;

            //แสดงค่า เรียกหา Method getText และ Method getSum โดย Input ค่าจาก a
            Console.WriteLine(getText(a) + getSum(a));
            //แสดงค่า เรียกหา Method getText และ Method getSum โดย Input ค่าจาก b
            Console.WriteLine(getText(b) + getSum(b));
            //แสดงค่า เรียกหา Method getEndText 
            Console.WriteLine(getEndText());
        }

        public string getText(int n)
        {
            //เมื่อมีการใช้ Method จะแสดงค่า Sum between 1- +n+ is
            return "Sum between 1-" +n+ " is ";
        }

        public int getSum(int n)
        {
            //กำนนด sum เป็น Int มีค่าเท่ากับ 0
            int sum = 0;
            //วนลูป จนกว่าถึงค่าที่กำหนด (n)
            for (int i = 0; i <= n; i++)
            {
                //sum = sum + i
                sum += i;
            }
            //เมื่อมีการเรียกใช้ Method จะ Return ค่า sum
            return sum;
        }

        public string getEndText()
        {
            //เมื่อมีการใช้ Method จะแสดงค่า Program Ended
            return "Program Ended";
        }
    }
}
