using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Implementations.Search_algorithms
{
    //Time complexity 0(log n)

    //Checks mid point value of a sorted array if the value to search is smaller checks lower half of array,
    //else checks other half, process repeated until value to search is at the midpoint of the array.
    //returns -1 if value not present in array.

    public class BinarySearch
    {
        public static int Search(int[] targetArray, int valueToSearch)
        {
            int min = 0;
            int max = targetArray.Length;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                
                if(targetArray[mid] == valueToSearch)
                {
                    Console.WriteLine(mid);
                    return mid;
                }
                if(valueToSearch < targetArray[mid])
                {
                    max = mid - 1;
                }
                if (valueToSearch > targetArray[mid])
                {
                    min = mid + 1;
                }
            }

            Console.WriteLine("Value doesn't exist");
            return -1;
        }
    }
}
