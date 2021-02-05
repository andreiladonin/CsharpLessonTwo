using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void method2()
        {
            int[] array = { 9, 6, 8, 3, 10, 4 };
            int summevent = 0;
            int mousecount = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    summevent += array[i];
                }

                if (mousecount > array[i])
                {
                    mousecount = array[i];
                }
            }
            Console.WriteLine(summevent);
            Console.WriteLine(mousecount);
            Console.ReadKey();
        }
        static void method1()
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void method3()
        {
            int[,] array =
            {
                {1, 2, 63, 90 },
                { 12, 2, 32, 97 }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
