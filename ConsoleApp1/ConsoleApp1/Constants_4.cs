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

            Console.WriteLine("Circle radius = {0}",r);
            Console.WriteLine("Circle are = {0}",area);
            Console.WriteLine("Circle circumference = {0}",circumference);
            Console.WriteLine("Circle volumn = {0}",volumn);
            Console.WriteLine("Circle surface = {0}",surface);
            
        }

        public void ConstantsArray()
        {
            const int SIZE = 3;

            string[] names = new string[SIZE];
            int[] scores = new int[SIZE];

            Console.WriteLine("Enter name and score of {0} players",SIZE);
            for(int i = 0; i < SIZE; i++)
            {
                Console.Write("Player {0} name: ",i+1);
                names[i] = Console.ReadLine();
                Console.Write("Player {0} score: ",i+1);
                scores[i] = Int32.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            for(int i =0; i < SIZE; i++)
            {
                if (scores[i] > scores[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine("{0} is the winner with score {1}", names[maxIndex], scores[maxIndex]);
        }
    }
}
