using System;
using CSI_Utilities;

namespace Sorting_algorithms
{
    public class BubbleSort
    {
        // Add time complexity of algorithm.
        public static int[] SortDecending(int[] arrayToSort)
        {
            for(int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j < arrayToSort.Length-1; j++)
                {
                    if(arrayToSort[i] > arrayToSort[j])
                    {
                        UtilityMethods.SwapArrayElementValues(arrayToSort, i, j);
                    }
                }
            }

            return arrayToSort;
        }

        public static int[] SortAcending(int[] arrayToSort)
        {
            // Implement
            return null;
        }
    }
}
