using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Constants_4
    {
        public void ConstantsDeclaration()
        {
            //กำหนดค่าคงที่ 3.14 ให้ตัวแปร PI Type float
            const float PI = 3.14f;
            //กำหนด 4 ให้ตัวแปร r Type float
            float r = 4;

            //กำหนด PI * r * r ให้ตัวแปร area Type float
            float area = PI * r * r;
            //กำหนด 2 * PI * r ให้ตัวแปร circumference Type float
            float circumference = 2 * PI * r;
            //กำหนด (4/3.0f) * PI * r * r * r ให้ตัวแปร volumn Type float
            float volumn = (4/3.0f) * PI * r * r * r;
            //กำหนด 4 * PI * r * r ให้ตัวแปร surface Type float
            float surface = 4 * PI * r * r;

            //แสดงค่า Circle radius = 4
            Console.WriteLine("Circle radius = {0}",r);
            //แสดงค่า Circle are = 50.24
            Console.WriteLine("Circle are = {0}",area);
            //แสดงค่า Circle circumference = 25.12
            Console.WriteLine("Circle circumference = {0}",circumference);
            //แสดงค่า Circle volumn = 267.9467
            Console.WriteLine("Circle volumn = {0}",volumn);
            //แสดงค่า Circle surface = 200.96
            Console.WriteLine("Circle surface = {0}",surface);
            
        }

        public void ConstantsArray()
        {
            //กำหนดค่าคงที่ 3 ให้ตัวแปร SIZE Type int
            const int SIZE = 3;

            //กำหนดขนาด 3 ให้ตัวแปร names Type string
            string[] names = new string[SIZE];
            //กำหนดขนาด 3 ให้ตัวแปร scores Type int
            int[] scores = new int[SIZE];

            //แสดงค่า Enter name and score of 3 players
            Console.WriteLine("Enter name and score of {0} players",SIZE);
            //กำหนด Loop 
            for(int i = 0; i < SIZE; i++)
            {
                //แสดงค่า Player + i+1 + name
                Console.Write("Player {0} name: ",i+1);
                //รับค่า name จาก Keyboard
                names[i] = Console.ReadLine();
                //แสดงค่า Player + i+1 + score
                Console.Write("Player {0} score: ",i+1);
                //รับค่า scores จาก Keyboard
                scores[i] = Int32.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            //กำหนด Loop 
            for (int i =0; i < SIZE; i++)
            {
                //ใส่เงื่อนไข ถ้าหากค่าของ score ในตำแหน่ง i มากกว่า score ในตำแหน่ง maxIndex
                if (scores[i] > scores[maxIndex])
                {
                    //ให้ maxIndex = i
                    maxIndex = i;
                }
            }
            //แสดงค่า (แสดชื่อที่มีงคะแนนที่สูงที่สุด) is the winner with score (แสดงคะแนนที่สูงที่สุด)
            Console.WriteLine("{0} is the winner with score {1}", names[maxIndex], scores[maxIndex]);
        }
    }
}
