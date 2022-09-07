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
            const float PI = 3.14f;
            float r = 4;

            float area = PI * r * r;
            float circumference = 2 * PI * r;
            float volumn = (4/3.0f) * PI * r * r * r;
            float surface = 4 * PI * r * r;

            //แสดงค่า Circle radius + r
            Console.WriteLine("Circle radius = {0}",r);
            //แสดงค่า Circle are + area
            Console.WriteLine("Circle are = {0}",area);
            //แสดงค่า Circle circumference + circumference
            Console.WriteLine("Circle circumference = {0}",circumference);
            //แสดงค่า Circle volumn + volumn
            Console.WriteLine("Circle volumn = {0}",volumn);
            //แสดงค่า Circle surface + surface
            Console.WriteLine("Circle surface = {0}",surface);
            
        }

        public void ConstantsArray()
        {
            const int SIZE = 3;

            string[] names = new string[SIZE];
            int[] scores = new int[SIZE];

            //แสดงค่า Enter name and score of +SIZE+ players
            Console.WriteLine("Enter name and score of {0} players",SIZE);
            //กำหนด Loop 
            for(int i = 0; i < SIZE; i++)
            {
                //แสดงค่า Player + i+1 + name
                Console.Write("Player {0} name: ",i+1);
                //รับค่า
                names[i] = Console.ReadLine();
                Console.Write("Player {0} score: ",i+1);
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

            Console.WriteLine("{0} is the winner with score {1}", names[maxIndex], scores[maxIndex]);
        }
    }
}
