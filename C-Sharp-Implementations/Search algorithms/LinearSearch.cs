using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Implementations.Search_algorithms
{
    // Time complexity O(N), scales relative to number of inputs
    public class LinearSearch
    {
        public static int Search(int[] targetArray, int valueToSearch)
        {
            for (int i = 0; i < targetArray.Length; i++)
            {
                if (targetArray[i] == valueToSearch)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
