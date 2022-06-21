using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._06._22_Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Информация о клиенте: ");
            string client = Console.ReadLine();
            Console.Write("Информация о поставщике: ");
            string postav = Console.ReadLine();
            Console.Write("Выставленный счет: ");
            int summa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Информация о товаре: ");
            string tovar = Console.ReadLine();
            Console.Write("Количество товара: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Invoice invoice = new Invoice(summa, client, postav, tovar, k);
            invoice.Show();
            Console.ReadKey();
        }
    }
}
    
