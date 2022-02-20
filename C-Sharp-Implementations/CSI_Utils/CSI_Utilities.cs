using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_Utilities
{
    public  class Test_Data
    {
        public static int[] UnSortedArray = {6,8,3,5,9,2,7,10,1,4};
        public static int[] Unsorted = {1,2,3,4,5,6,7,8,9,10};
    }

    public class UtilityMethods 
    {
        /// <summary>
        /// Swaps the values of two elements in array, given their indexes in the array.
        /// </summary>
        /// <param name="targetArray">Array to swap values in</param>
        /// <param name="index1">Array index of first element</param>
        /// <param name="index2">Array index of second element</param>
        public static void SwapArrayElementValues(int [] targetArray, int index1,int index2)
        {
            int tempInt = targetArray[index2];
            targetArray[index2] = targetArray[index1];
            targetArray[index1] = tempInt;
        }
    }
}
