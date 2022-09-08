using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Interfaces_16_13_Boat : Interfaces_16_11
    {
        public void Move()
        {
            Console.WriteLine("Sailing on the water");
        }

        public void StartEngine()
        {
            Console.WriteLine("Boat engine started");
        }
    }
}