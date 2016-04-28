using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 1, 1, 1 };
            int[] array1 = { 1, 3, 4, 5, 1, 0, 5 };

            Console.WriteLine(GetIndexOfFirstLargerIndex(array1));
            Console.WriteLine(GetIndexOfFirstLargerIndex(array));

        }

        public static int GetIndexOfFirstLargerIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    if (i < array.Length - 1)
                    {
                        if (array[i] > array[i + 1] && array[i] > array[i - 1])
                        {
                            return i;
                        }
                    }
                    else if (array[i] > array[i - 1])
                    {
                        return i;
                    }
                }
                else if (array[i] > array[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

//int[] array = { 1, 3, 4, 5, 1, 0, 5 };

//            for (int i = 0; i<array.Length; i++)
//            {
//                Console.WriteLine(IsLarger(array, i));
//            }
//        }

//        public static bool IsLarger(int[] array, int i)
//{
//    bool isLarger = false;

//    if (i > 0)
//    {
//        if (i < array.Length - 1)
//        {
//            if (array[i] > array[i + 1] && array[i] > array[i - 1])
//            {
//                isLarger = true;
//            }
//        }
//        else
//        {
//            isLarger = array[i] > array[i - 1];
//        }

//    }
//    else
//    {
//        isLarger = array[i] > array[i + 1];
//    }
//    return isLarger;
//}
//    }
//}