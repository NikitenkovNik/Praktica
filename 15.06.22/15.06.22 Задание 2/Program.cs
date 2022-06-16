using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFFFFFF_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int low;
            Console.Write("Количество точек (не менее трех): ");
            low = Convert.ToInt32(Console.ReadLine());
            List<Point> points = new List<Point>();
            Console.WriteLine();
            int x;
            int y;
            string z;
            for (int i = 0; i < low; i++)
            {
                Console.Write("Введите координату X: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите координату Y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите название точки: : ");
                z = (Console.ReadLine());
                Console.WriteLine();
                points.Add(new Point(x, y, z));
            }

            Figure figure = null;
            if(points.Count == 3)
            {
                figure = new Figure(points[0], points[1], points[2]);
            }
            else
            {
                if (points.Count == 4)
                {
                    figure = new Figure(points[0], points[1], points[2], points[4]);
                }
                else
                {
                    if (points.Count == 5)
                    {
                        figure = new Figure(points[0], points[1], points[2], points[4], points[5]);
                    }
                }
            }

            figure.PerimeterCalculator();
            Console.ReadKey();

        }
    }
}
