using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ArrayUtils
    {
        private static Random _rnd = new Random();
        public static int[] GenerateRandomArray(int n, int rangeMin = -100, int rangeMax = 100)
        {
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = _rnd.Next(rangeMin, rangeMax);
            }
            return arr;
        }

        public static void ShuffleArray(int[] arr)
        {
            for(int i=0; i< arr.Length-1; i++)
            {
                int randomIndex = _rnd.Next(i + 1, arr.Length);

                Swap(ref arr[i], ref arr[randomIndex]);
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}
