using System;
using CSI_Utilities;

namespace Sorting_algorithms
{
    public class BubbleSort
    {
        // Worst case time complexity of O(N^2)

        public static int[] SortAcending(int[] targetArray)
        {
            for (int i = 0; i < targetArray.Length; i++)
            {
                for (int j = 0; j < targetArray.Length - 1; j++)
                {
                    if (targetArray[i] < targetArray[j])
                    {
                        UtilityMethods.SwapArrayElementValues(targetArray, i, j);
                    }
                }
            }

            Console.WriteLine(" ");

            foreach (int element in targetArray)
            {
                Console.Write(" " + element);
            }

            return targetArray;
        }

        public static int[] SortDecending(int[] targetArray)
        {
            for(int i = 0; i < targetArray.Length; i++)
            {
                for (int j = 0; j < targetArray.Length-1; j++)
                {
                    if(targetArray[i] > targetArray[j])
                    {
                        UtilityMethods.SwapArrayElementValues(targetArray, i, j);
                    }
                }
            }

            Console.WriteLine(" ");

            foreach (int element in targetArray)
            {
                Console.Write(" " + element);
            }

            return targetArray;
        }
    }
}
