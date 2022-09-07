using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VariableAndDataType_3
    {
        public void VariableDeclaration()
        {
            int year = 2022;
            string name = "Thomas";
            string nationality = "American";

            Console.WriteLine("His name is {0}", name);
            Console.WriteLine("He was born in {0}",year);
            Console.WriteLine("He is {0}",nationality);
        }

        public void Boolean()
        {
            bool isDay = true;
            if(isDay)
            {
                Console.WriteLine("Good morning");
            }
            else
            {
                Console.WriteLine("Good night");
            }

            bool gameOver = false;
            Console.WriteLine("Game over = {0}",gameOver);
        }

        public void IntegerNumberType()
        {
            int apple = 10;
            int mango = 5;
            int totalFruit = apple + mango;

            Console.WriteLine("We have {0} fruits in the basket",totalFruit);

            byte month = 12;
            byte day = 20;
            short year = 2016;

            Console.WriteLine("Date {0}/{1}/{2}",month,day,year);

            decimal bigNumber = 9460730472580800;
            Console.WriteLine(bigNumber.ToString("0.00000E0"));

            int max = Int32.MaxValue;
            Console.WriteLine(max);
            max = max + 1;
            Console.WriteLine(max);
        }

        public void DoubleNumberType()
        {
            float speed = 8.3f;
            float time = 10.25f;
            float distance = speed * time;

            Console.WriteLine("Metro runs at speed {0} m/s in {1} seconds", speed, time);
            Console.WriteLine("Total run distance {0} meters",distance);

            float lightSpeed = 5.8786E12f;
            Console.WriteLine("Light can travel {0} miles in 1 year",lightSpeed);

            double day = 365.25;
            double neutroMass = 1.674927471E-27;
            double pi = 22 / 7.0f;
            Console.WriteLine("Earth take about {0} day to orbit the sun", day);
            Console.WriteLine("PI value = {0}",pi);
            Console.WriteLine("Neutron Mass = {0} kg", neutroMass);

        }
    }
}
