using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManeClassesAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mers = new Product(); // Создание нового объекта класса Product с именем mers (мерседес)
            mers.SetName("Мерседес"); // Вызов метода SetName для установки названия товара "Мерседес"
            mers.SetPrice(1000000);// Вызов метода SetPrice для установки цены товара 1,000,000

            Product yaz = new Product(); // Создание второго объекта класса Product с именем yaz (уазик)
            yaz.SetName("Уазик"); // Установка названия второго товара "Уазик"
            yaz.SetPrice(10000000);// Установка цены второго товара 10,000,000

            Storage storage = new Storage();// Создание объекта класса Storage (склад) для хранения товаров
            storage.SetId(123);// Установка идентификатора склада (123)
            storage.SetLocation("Торжок, Ул. Студенческая 3"); // Установка местоположения склада
            storage.SetProductQuantity(mers, 3); // Добавление на склад 3 единицы товара mers (Мерседес)
            storage.SetProductQuantity(yaz, 7); // Добавление на склад 7 единиц товара yaz (Уазик)

            storage.GetProductQuantity(); // Вызов метода GetProductQuantity для отображения информации о количестве товаров на складе
            storage.CalculateMoney(); // Вызов метода CalculateMoney для расчёта общей стоимости товаров на складе

            Console.WriteLine();// Вывод пустой строки для разделения вывода

            Report report = new Report(); // Создание объекта класса Report (отчёт) для формирования отчёта

            ReportRow row1 = new ReportRow();// Создание первой строки отчёта (структуры ReportRow)
            row1.Product = "Mers";// Установка названия продукта в первой строке отчёта (обратите внимание: "Mers" вместо "Мерседес")
            row1.Quantity = 3;// Установка количества в первой строке отчёта (3)
            row1.Price = 1000000;  // Установка цены в первой строке отчёта (1,000,000)

            ReportRow row2 = new ReportRow();// Создание второй строки отчёта
            row2.Product = "Vaz"; // Установка названия продукта во второй строке (обратите внимание: "Vaz" вместо "Уазик")
            row2.Quantity = 7;// Установка количества во второй строке отчёта (7)
            row2.Price = 10000000;// Установка цены во второй строке отчёта (10,000,000)


            report.AddRecord(row1);// Добавление первой строки в отчёт
            report.AddRecord(row2); // Добавление второй строки в отчёт

            Console.WriteLine("Содержимое отчета:"); // Вывод заголовка для содержимого отчёта
            Console.WriteLine(report);// Вывод содержимого отчёта (вероятно, переопределён метод ToString() в классе Report)
            report.CalculateSum();// Вызов метода CalculateSum для расчёта итоговой суммы отчёта
        }
    }
}
