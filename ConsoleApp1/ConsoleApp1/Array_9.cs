using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array_9
    {

        public void Array1Dimention()
        {
            int[] array1 = new int[5];
            array1[0] = 2;
            array1[1] = 43;
            array1[2] = 54;

            float[] array2 = new float[] {1.2f,3.4f,5.0f,8.8f,10.5f};
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[4]);
        }

        public void ForLoopArray1Dimention()
        {
            int[] array1 = new int[10];
            for(int i = 0; i < 10; i++)
            {
                array1[i] = (i + 1) * 5;
                Console.Write(array1[i] +",");
            }
        }

        public void Array2Dimention()
        {
            int[,] array2 = new int[,] { {1, 2, 3}, {4, 5, 6} };
            Console.WriteLine(array2[0, 0]);
            Console.WriteLine(array2[0, 1]);
            Console.WriteLine(array2[0, 2]);
            Console.WriteLine(array2[1, 0]);
            Console.WriteLine(array2[1, 1]);
            Console.WriteLine(array2[1, 2]);
        }

        public void ForLoopArray2Dimention()
        {
            int[,] myArray = new int[,] { { 10, 43, -23, 5 }, { -5, 9, 15, 3 }, { 0,41,-30,-7} };

            for(int i=0; i<3; i++)
            {
                for(int j =0;j<4 ; j++)
                {
                    Console.Write("[{0},{1}] = {2}\t" ,i,j,myArray[i,j]);
                }
            }
            Console.WriteLine();
        }

        public void JaggedArray()
        {
            int[][] jaggedArray = new int[4][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[] { (i * 3) + 1, (i * 3) + 2, (i * 3) + 3 };
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("array[{0}][{1}] = {2}", i, j, jaggedArray[i][j]);
                }
            }
        }

        public void JaggedArray2()
        {
            int[][] jaggedArray = new int[][] {  
            new int[] { 1, 2, 3}, 
            new int[] { 4, 5, 6 }, 
            new int[] { 7, 8, 9 }, 
            new int[] { 10, 11, 12 }
        };


        for (int i = 0; i < jaggedArray.Length; i++) {
            for (int j = 0; j < jaggedArray[i].Length; j++) {
                Console.WriteLine("array[{0}][{1}] = {2}", i, j, jaggedArray[i][j]);
            }
        }
        }
    }
}
