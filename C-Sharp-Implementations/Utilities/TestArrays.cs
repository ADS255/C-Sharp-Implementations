using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpUtils.TestData
{
    public class TestArrays
    {
        public static int[] DefinedUnSorted = { 6, 8, 3, 5, 9, 2, 7, 10, 1, 4 };
        public static int[] DefinedSorted = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /// <summary>
        /// Returns array of unsorted integers
        /// </summary>
        /// <param name="elementsInArray">Size of the array</param>
        /// <param name="maxValue">Maximum value elements in array can't exceed</param>
        /// <returns></returns>
        public static int[] GenerateUnSorted(int elementsInArray, int maxValue)
        {
            int[] array = new int[elementsInArray];

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int num = rnd.Next();
                array[i] = rnd.Next(maxValue);
            }

            return array;
        }
    }
}
