using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Polymorphism_15_0
    {
        public void PolomorphismMove()
        {
            //สร้าง obj ใหม่จาก Class Polymorphism_15_2_Dog
            Polymorphism_15_1_Animals dog = new Polymorphism_15_2_Dog();
            //สร้าง obj ใหม่จาก Class Polymorphism_15_3_Fish
            Polymorphism_15_1_Animals fish = new Polymorphism_15_3_Fish();
            //สร้าง obj ใหม่จาก Class Polymorphism_15_4_Bird
            Polymorphism_15_1_Animals bird = new Polymorphism_15_4_Bird();

            //เรียกใช้ Method Move จาก Class Polymorphism_15_2_Dog
            dog.Move();
            //เรียกใช้ Method Move จาก Class Polymorphism_15_3_Fish
            fish.Move();
            //เรียกใช้ Method Move จาก Class Polymorphism_15_4_Bird
            bird.Move();
        }

        public void PolomorphismMoveArray()
        {
            //กำหนด Array ขนาด 3 ให้ตัวแปร animalArray
            Polymorphism_15_1_Animals[] animalArray = new Polymorphism_15_1_Animals[3];
            //กำหนดค่า Polymorphism_15_2_Dog ใน index ที่ 0 ลงใน animalArray
            animalArray[0] = new Polymorphism_15_2_Dog();
            //กำหนดค่า Polymorphism_15_3_Fish ใน index ที่ 1 ลงใน animalArray
            animalArray[1] = new Polymorphism_15_3_Fish();
            //กำหนดค่า Polymorphism_15_4_Bird ใน index ที่ 2 ลงใน animalArray
            animalArray[2] = new Polymorphism_15_4_Bird();

            //แสดงค่า C# Arrays
            Console.WriteLine("C# Arrays");
            //วนลูป foreach animalArray
            foreach (Polymorphism_15_1_Animals animal in animalArray)
            {
                //เรียกใช้ Method AnimalMove โดยรับค่า parameter animal
                AnimalMove(animal);
            }

            //สร้าง obj ใหม่จาก Class Polymorphism_15_1_Animals
            List<Polymorphism_15_1_Animals> animallist = new List<Polymorphism_15_1_Animals>();
            //เพิ่ม obj Polymorphism_15_2_Dog ลงใน animallist
            animallist.Add(new Polymorphism_15_2_Dog());
            //เพิ่ม obj Polymorphism_15_3_Fish ลงใน animallist
            animallist.Add(new Polymorphism_15_3_Fish());
            //เพิ่ม obj Polymorphism_15_4_Bird ลงใน animallist
            animallist.Add(new Polymorphism_15_4_Bird());

            //แสดงผล C# Generic
            Console.WriteLine("\nC# Generic");
            //วนลูป foreach animalArray
            foreach (Polymorphism_15_1_Animals animal in animallist)
            {
                //เรียกใช้ Method AnimalMove โดยรับค่า parameter animal
                AnimalMove(animal);
            }
        }

        //กำหนด Method AnimalMove โดยรับค่า Parameter
        public void AnimalMove(Polymorphism_15_1_Animals animal)
        {
            //เรียกใช้ Method Move จาก Class Polymorphism_15_1_Animals
            animal.Move();
        }
    }
}