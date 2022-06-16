using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._06._22_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            Console.Write("Длинна масива: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[X];
            Console.WriteLine("Элементы масива: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Масив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }

            Console.WriteLine();
            arr.SortItOut();

            Console.Write("Отсортироыванный масива: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }
            Console.ReadKey();
        }
    }
}
