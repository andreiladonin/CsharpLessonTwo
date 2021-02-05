using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sortArr = { 1, 2, 5, 10, 12, 33, 50 };
            Console.WriteLine(SearchIndexArray(sortArr,5));
            Console.ReadKey();

        }

        static int SearchIndexArray(int[] arr, int value)
        {
            int first = 0;
            int mid = arr.Length / 2;
            int last = arr.Length - 1;
            
            while (arr[mid] != value && first <= last)
            {
                if (value > arr[mid])
                {

                    first = first + mid;
                }

                else
                {
                    last = last - mid;
                }
                mid = (last + first) / 2;

            }

            return mid;
           
        }
    }
}
