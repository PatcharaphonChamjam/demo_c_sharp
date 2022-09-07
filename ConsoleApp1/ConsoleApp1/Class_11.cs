using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class_11
    {
        public int energyUserPerRun =3;
        //String color;

        public float enegy =10;
        public int speed = 0;
        public int distance = 0;

       // public Car(string c,float e,int s,int d)
        //{
            //color = c;
            //enegy = e;
            //speed = s;
            //distance = d;
        //}

        public void AddEnegy()
        {
            enegy += 10;
        }

        public void Run ()
        {
            if(enegy < speed * energyUserPerRun)
            {
                Console.WriteLine("No enough enegy to run.");
            }
            else
            {
                distance += (speed * energyUserPerRun);
                enegy -= energyUserPerRun;
            }
        }

        public void ShowDistance()
        {
            Console.WriteLine("Distance runned "+distance);
        }
    }
}
