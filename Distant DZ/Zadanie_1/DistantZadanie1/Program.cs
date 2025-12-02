using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistantZadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------АНАЛИЗ ПРОДАЖ МОБИЛЬНЫХ ТЕЛЕФОНОВ------"); // Вывод заголовка программы в консоль
            // Создал список и заполнил его данными
            List<Sale_of_phones> Phone = new List<Sale_of_phones>();// Создание пустого списка объектов типа Sale_of_phones и присвоение его переменной Phone
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 12), PhoneModel = "Iphone 16", Quantity = 7, Price = 89900 });// Добавление в список первой записи о продаже:
                                                                                                                                       // Дата: 12.11.2025, Модель: Iphone 16, Количество: 7, Цена: 89900
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 12), PhoneModel = "Samsung Galaxy A51", Quantity = 4, Price = 69900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 13), PhoneModel = "IPhone Pro 15", Quantity = 5, Price = 119000 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 13), PhoneModel = "Samsung Galaxy A51", Quantity = 1, Price = 55900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 14), PhoneModel = "Samsung Galaxy S27", Quantity = 3, Price = 81900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 14), PhoneModel = "Iphone 16", Quantity = 2, Price = 99000 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 15), PhoneModel = "Samsung Galaxy S27", Quantity = 2, Price = 89900 });
            Phone.Add(new Sale_of_phones { Date = new DateTime(2025, 11, 15), PhoneModel = "IPhone Pro 15", Quantity = 5, Price = 99000 });
            // Задаем временной диапазон для анализа данных
            DateTime startDate = new DateTime(2025, 11, 12);// Создание переменной startDate и инициализация её датой начала анализируемого периода (12.11.2025)
            DateTime endDate = new DateTime(2025, 11, 15);// Создание переменной endDate и инициализация её датой конца анализируемого периода (15.11.2025)
            // а) Общая сумма проданного за период
            Console.WriteLine($"а) Общая сумма проданных телефонов за период: " + Functions.FindSalesPrice(Phone, startDate, endDate) + " рублей");   // Вывод пункта "а" с заголовком и результатом вызова функции FindSalesPrice
                                                                                                                                                      // Функция получает список продаж, дату начала и конца периода, возвращает общую сумму
            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            string bestSellingPhone = Functions.FindBestPhoneModel(Phone);// Вызов функции FindBestPhoneModel для определения самой продаваемой модели телефона
                                                                          // Результат сохраняется в переменную bestSellingPhone
            string worstSellingPhone = Functions.FindWorstPhoneModel(Phone);// Вызов функции FindWorstPhoneModel для определения наименее продаваемой модели телефона
                                                                            // Результат сохраняется в переменную worstSellingPhone
            Console.WriteLine("б) Самый продаваемый телефон и телефон с наименьшими продажами");// Вывод заголовка для пункта "б"
            Console.WriteLine($"       Самый продаваемый телефон: {bestSellingPhone}");// Вывод результата поиска самой продаваемой модели
            Console.WriteLine($"       Телефон с наименьшими продажами: {worstSellingPhone}");// Вывод результата поиска наименее продаваемой модели
            // в) Два телефона, приносящие наибольшую прибыль
            // Вызывает функцию и сохраняет результат массива
            string[] profitablePhones = Functions.FindProfitablePhones(Phone);// Вызов функции FindProfitablePhones для поиска двух самых прибыльных моделей телефонов
                                                                              // Функция возвращает массив строк, который сохраняется в переменную profitablePhones
            Console.WriteLine("в) Два телефона, приносящие наибольшую прибыль:");// Вывод заголовка для пункта "в"
            Console.WriteLine($"       1. {profitablePhones[0]}");// Вывод первой самой прибыльной модели (первый элемент массива с индексом 0)
            Console.WriteLine($"       2. {profitablePhones[1]}");// Вывод второй самой прибыльной модели (второй элемент массива с индексом 1)
            // Отображение временного ряда, сортировка по дате
            Console.WriteLine("Временной ряд продаж:");// Вывод заголовка для раздела временного ряда
            Console.WriteLine("Дата            Модель                  Количество      Выручка");// Вывод заголовков колонок таблицы
            Console.WriteLine("---------------------------------------------------------------------");// Вывод разделительной линии для таблицы
            var timeSeries = Phone.OrderBy(sale => sale.Date);              // Сортировка всех продаж по дате в порядке возрастания с помощью метода OrderBy LINQ
                                                                            // Результат сортировки сохраняется в переменную timeSeries   // сортировка всех продаж по дате
            foreach (var sale in timeSeries)// Начало цикла foreach для перебора всех отсортированных продаж
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}      {sale.PhoneModel,-20}    {sale.Quantity}               {sale.Revenue} рублей");// Вывод строки таблицы для каждой продажи:
                                                                                                                                               // - Дата в формате "дд.мм.гггг" с отступом
                                                                                                                                               // - Модель телефона с выравниванием по левому краю на 20 символов
                                                                                                                                               // - Количество проданных единиц
                                                                                                                                               // - Выручка (предположительно свойство Revenue объекта sale)
            }
        }
    }
}

