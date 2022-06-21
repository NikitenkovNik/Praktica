using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._06._22_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd;
            double eur;
            double rub;
            Console.Write("Курс доллара к гривне: ");
            usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Курс евро к гривне: ");
            eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Курс рубля к гривне: ");
            rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Converter converter = new Converter(usd, eur, rub);
            Console.WriteLine("Какое действие вы хотите произвести:");
            Console.WriteLine("1 - гривны в доллары");
            Console.WriteLine("2 - гривны в евро");
            Console.WriteLine("3 - гривны в рубли");
            Console.WriteLine("4 - доллары в гривны");
            Console.WriteLine("5 - евро в гривны");
            Console.WriteLine("6 - рубли в гривны");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum;
            switch (x)
            {
                case 1:
                    Console.Write("Сумма в гривнах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.UAH_USD(sum));
                    break;
                case 2:
                    Console.Write("Сумма в гривнах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.UAH_EUR(sum));
                    break;
                case 3:
                    Console.Write("Сумма в гривнах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.UAH_RUB(sum));
                    break;
                case 4:
                    Console.Write("Сумма в долларах: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.USD_UAH(sum));
                    break;
                case 5:
                    Console.Write("Сумма в евро: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.EUR_UAH(sum));
                    break;
                case 6:
                    Console.Write("Сумма в рублях: ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("результат: " + converter.RUB_UAH(sum));
                    break;
            }
            Console.ReadKey();
        }
    }
}
    

