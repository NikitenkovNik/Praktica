using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._06._22_Задание_3
{
    static public class ImyaClassa
    {
       public static int[] SortItOut(this int[] arr)
        {
            int temp;
            for(int i = 0; i< arr.Length; i++)
            {
                for(int j = 1; j< arr.Length; j++)
                {
                    if(arr[j] < arr[j-1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
