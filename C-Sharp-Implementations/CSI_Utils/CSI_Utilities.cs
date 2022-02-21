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

        /// <summary>
        /// Returns array of unsorted integers
        /// </summary>
        /// <param name="elementsInArray">Size of the array</param>
        /// <param name="maxValue">Maximum value elements in array can't exceed</param>
        /// <returns></returns>
        public static int[] GenerateUnSortedArray(int elementsInArray,int maxValue)
        {
            int[] array = new int[elementsInArray];
            
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int num = rnd.Next();
                array[i] = rnd.Next(maxValue);
            }

            foreach (int element in array)
            {
                Console.Write(" " + element);
            }

            return array;
        }
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
