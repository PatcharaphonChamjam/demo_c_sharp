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
            int a = 10;
            int b = 3;
            float c = 2.0f;

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));

        }

        public void RelationComparison()
        {
            int n = 10;
            if(n%2 == 0)
            {
                Console.WriteLine("n is even number");
            }

            int x = 6, y = 2;
            if(x < y)
            {
                Console.WriteLine("x is less than y");
            }
        }

        public void LogicalOperation()
        {
            bool a = (3 == 4);
            bool b = (3 != 4);
            bool c = (3 < 5);
            bool d = a && b;
            bool e = !d;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
        }

        public void LogicalOperation2()
        {
            int age = 20;
            int money = 100;

            if(age >= 18 && money >=120)
            {
                Console.WriteLine("You can buy a game.");
            }

            if(age >= 18 || money >=500)
            {
                Console.WriteLine("You can buy a movie.");
            }
        }

        public void TernaryOperator()
        {
            string cc = "NY";
            Console.WriteLine(cc == "NY"? "New York" : "Other states");
        }
    }
}
