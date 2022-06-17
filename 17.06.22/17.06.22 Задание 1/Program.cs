using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17._06._22_Задание_1
{
    public struct Train
    {
        public string name;
        public int number;
        public DateTime date;

        public Train(string name, int number, DateTime date)
        {
            this.name = name;
            this.number = number;
            this.date = date;
        }

        //public int CompareTo(object obj)
        //{
        //    Train a = (Train)obj;

        //    if (this.number.CompareTo(a.number) == -1) return -1;
        //    if (this.number.CompareTo(a.number) == 0) return 0;
        //    else return 1;
        //}

        public override string ToString()
        {
            return String.Format("Название пункта назначения " + this.name + " \nНомер поезда " + number + " \nВремя отправления " + date);
        }
    }

    class Program
    {
        static void Main()
        {
            ArrayList nL = new ArrayList();

            Train[] trains = new Train[2];
            string d;
            int n;
            DateTime t;
            for(int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите пункт назначения: ");
                d = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Введите номер поезда: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Введите дату оправления: ");
                t = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
                trains[i] = new Train(d, n, t);
            }

            Console.WriteLine("Введите номер поезда для поиска: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i ++)
            {
                if(trains[i].number == number)
                {
                    Console.WriteLine(trains[i].name + " " + trains[i].number + " " + trains[i].date + " ");
                }
                else
                {
                    Console.WriteLine("Поезд не найден");
                }
            }

            Console.ReadKey();
        }
    }
}
