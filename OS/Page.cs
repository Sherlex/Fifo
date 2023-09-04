using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS

{ 
    public class Array
    {

        public int[] ArrayRandom(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);
            }
            return array;
        }

             
        
    }

   

    /*class ProgramM
    {
        static void Main(string[] args)
        {
            int[] arr = new int[16] { 7, 8, 9, 2, 1, 0, 8, 9, 2, 4, 6, 8, 2, 1, 8, 9 };

            FIFO f = new FIFO();
            f.block_4(arr);
            Console.WriteLine();

            f.block_5(arr);
            Console.WriteLine();

        }
    }*/
}
