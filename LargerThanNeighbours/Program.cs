using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(IsLarger(array, i));
            }
        }

        public static bool IsLarger(int[] array, int i)
        {
            bool isLarger = false;

            if (i > 0)
            {
                if (i < array.Length - 1)
                {
                    if (array[i] > array[i + 1] && array[i] > array[i - 1])
                    {
                        isLarger = true;
                    }
                }
                else
                {
                    isLarger = array[i] > array[i -1];
                }

            }
            else
            {
                isLarger = array[i] > array[i + 1];
            }
            return isLarger;
        }
    }
}