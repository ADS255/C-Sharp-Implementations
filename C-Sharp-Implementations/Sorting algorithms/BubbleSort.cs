using System;
using ImpUtils.UtilityMethods;

namespace C_Sharp_Implementations.Sorting_algorithms
{
    // Time complexity O(N^2)

    // Compares adjacent elements and swaps their position if one is greater than the other.

    public class BubbleSort
    {
        public static int[] Sort(int[] arrayToSort)
        {
            for (int j = 0; j<arrayToSort.Length; j++)
            {
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i+1])
                    {
                        Utilities.SwapElementValues(arrayToSort, i, i+1);
                    }
                }
            }

            Utilities.PrintArray(arrayToSort);
            return arrayToSort;
        }
    }
}
