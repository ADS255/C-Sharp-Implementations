using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Implementations.Search_algorithms
{
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
