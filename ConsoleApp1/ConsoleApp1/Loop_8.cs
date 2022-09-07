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
            while(n <= 10)
            {
                Console.WriteLine("Loop" + n);
                n++;
            }
            Console.WriteLine("Loop ended");
        }

        public void DoWhile()
        {
            int n;
            Console.WriteLine("Enter 0 to exit the loop");
            do
            {
                Console.Write("Your number: ");
                int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("Number your entered is "+n);
            }while(n != 0);
            Console.WriteLine("Loop Ended");
        }

        public void ForLoop()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ForLoop2()
        {
            int i = 1;
            for (;i <= 10;)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void ForeachLoop()
        {
            int[] numbers = {2, 4, -1, 5, 0, 8, 9};
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }    
        }

        public void Break()
        {
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
                if(i ==5) break;
            }
        }

        public void Continue()
        {
            for (int i = 0; i <= 10; i++)
			{
                if(i % 2 == 0) continue;
                Console.WriteLine(i);
			}
        }

    }
}
