using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array_9
    {
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
    }
}
