using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Interfaces_16_12_Cars : Interfaces_16_11
    {
        public void Move()
        {
            Console.WriteLine("Driving on the ground.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }
}