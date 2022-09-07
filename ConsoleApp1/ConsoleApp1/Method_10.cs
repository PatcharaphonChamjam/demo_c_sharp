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
            string name = "Marcus";
            int sex = 0;
            string sport = "hockey";

            displayBio(name,sex,sport);
        }

        public void displayBio(string n,int s,string sp)
        {
            if(s == 0)
            {
                Console.WriteLine(n + " has " + sp + " as his favorite sport.");
            }
            else
            {
                Console.WriteLine(n + " has " + sp + " as her favorite sport.");
            }
        }

        public void CreatingMethod2()
        {
            int a = 10;
            int b = 25;
            Console.WriteLine(getText(a) + getSum(a));
            Console.WriteLine(getText(b) + getSum(b));
            Console.WriteLine(getEndText());
        }

        public string getText(int n)
        {
            return "Sum between 1-" +n+ " is ";
        }

        public int getSum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public string getEndText()
        {
            return "Program Ended";
        }
    }
}
