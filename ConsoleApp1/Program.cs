using System;
using System.Reflection.Metadata.Ecma335;

namespace Training
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 1, 2 };
            Console.WriteLine(arr[0].Length);
           /* for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j <3; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }*/
        }
    
    }
}
