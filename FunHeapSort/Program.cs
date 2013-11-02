using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace FunHeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 350000;
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(n*rand.Next(50));
            }
            Console.WriteLine("-----------HeapSort-------------");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " | ");
            Console.WriteLine();

            DateTime startTime;
            startTime = DateTime.Now;
            HeapSort HS = new HeapSort();
            HS.sort(array);

            DateTime endTime = DateTime.Now;
            TimeSpan diff = endTime - startTime;

            Console.WriteLine("-----------Result-------------");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " | ");
            Console.WriteLine();
            Console.WriteLine("-----------Finish-------------");
            Console.WriteLine((int)Math.Round((double)diff.Seconds, 0, MidpointRounding.AwayFromZero) + ":" + (int)Math.Round((double)diff.Milliseconds, 0, MidpointRounding.AwayFromZero));
            Console.ReadLine();
        }
    }
}
