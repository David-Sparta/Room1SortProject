using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class RandomGenerator
    {
        public static int[] GetRandomArray(int size)
        {
            var arr = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(int.MinValue, int.MaxValue);
            }

            return arr;
        }

        public static void show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
    }
}
