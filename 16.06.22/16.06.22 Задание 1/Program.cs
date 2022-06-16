using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._06._22_Задание_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int V;
            int Z;
            Console.WriteLine("Введите количество строк: ");
            V = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Введите количество столбцов: ");
            Z = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            MyMatrix matrix = new MyMatrix(V, Z);
            Console.WriteLine("Введите элементы матрицы: ");
            matrix.SetElement();
            matrix.ShowMatrix();
            matrix.ChangeMatrix(10, 12);
            matrix.ShowMatrix();
            Console.ReadKey();
        }
    }
}
