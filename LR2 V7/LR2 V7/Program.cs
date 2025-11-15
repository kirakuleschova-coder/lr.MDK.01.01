using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лаб2. Вариант 7
            //Для магазина «Пятерочка» требуется разработать информационную систему учета продаж.
            //Сведения о товарах разнесены по категориям: крупы, овощи, фрукты  и т.д.
            //По каждому товару вносятся изменения его цены, история изменений сохраняется.
            //По запросу пользователя – «название товарной категории» - вывести на экран список товаров от дорогих к дешевым.
            //Стоимость определяется как среднее значение за весь период.
            {
                Console.WriteLine("Информационная система 'Пятёрочка'");
                string Product = Console.ReadLine();
                string Category = new string[] ("крупы, "овощи", "фрукты")
                List<UpravlenieDann> Category = new List<UpravlenieDann>();
                Category Add (new UpravlenieDann {PriceHistory = "1000", Product  = "980", Category = "крупы "} );

            }
        }
    }
}
