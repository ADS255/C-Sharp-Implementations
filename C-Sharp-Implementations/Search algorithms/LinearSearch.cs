using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_algorithms
{
    public class LinearSearch
    {
        public static int Search(int[] targetArray,int valueToSearch)
        {
            for (int i = 0;i < targetArray.Length; i++)
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
