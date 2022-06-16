using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFFFFFF_2
{
    class Figure
    {
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Point p5;

        public Figure(Point P1, Point P2, Point P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }

        public Figure(Point P1, Point P2, Point P3, Point P4)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
            p4 = P4;
        }

        public Figure(Point P1, Point P2, Point P3, Point P4, Point P5)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
            p4 = P4;
            p5 = P5;
        }

        public double LenghtSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.iks - b.iks, 2) + Math.Pow(a.igrek - b.igrek, 2));

        }

        public void PerimeterCalculator()
        {
            double res;
            if (p4 == null)
            {
                res = LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p1);
            }
            else
            {
                if (p5 == null)
                {
                    res = LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p4) + LenghtSide(p4, p1);
                }
                else
                {
                    res = LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p4) + LenghtSide(p4, p5) + LenghtSide(p5, p1);
                }
            }
            Console.WriteLine("Периметр: " + res);
        }
    }
}

