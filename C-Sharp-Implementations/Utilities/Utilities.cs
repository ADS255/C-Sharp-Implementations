using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpUtils.UtilityMethods
{
    public class Utilities
    {
        public static void SwapElementValues(int[] targetArray, int index1, int index2)
        {
            int temp = targetArray[index2];
            targetArray[index2] = targetArray[index1];
            targetArray[index1] = temp;
        }

        public static void PrintArray(int[] arrayToPrint)
        {
            Console.WriteLine("");

            foreach (int i in arrayToPrint)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
