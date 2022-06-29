using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._22_Задание_3_Full_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Укажите цвет: (0 - синий, 1 - красный, 2 - зелёный, 3 - жёлтый)");
            int color = Convert.ToInt32(Console.ReadLine());
            ColorPrint.Print(stroka, color);
            Console.ReadKey();
        }
    }
}
