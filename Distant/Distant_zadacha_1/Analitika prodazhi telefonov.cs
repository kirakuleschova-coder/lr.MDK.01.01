using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant_zadacha_1
{
    internal class Analitika_prodazhi_telefonov
    {
        // Поле для списка объектов класса Sale_of_phones, salesData хранение всех данных о продажах
        private List<Rasprodazha_telefonov> salesData;
        // Конструктор класса, принимает список продаж
        public Analitika_prodazhi_telefonov(List<Rasprodazha_telefonov> data)
        {
            salesData = data;
        }

        // а) Метод для определения общей суммы проданного за период
        public double ReceivingTotalIncome(DateTime startDate, DateTime endDate)
        {
            // Фильтрование продаж по заданным периодам времени
            var periodSales = salesData.Where(sale => sale.Date >= startDate && sale.Date <= endDate);
            // Суммирование выручки от всех отфильтрованных продаж
            return periodSales.Sum(sale => sale.Revenue);
        }
        // б) Метод для определения самого продаваемого телефона и телефона с наименьшими продажами
        public void TheBestAndWorstPhone(out string BestPhone, out string WorstPhone)
        {
            // Группируем продажи по модели телефона
            var TelefonGroups = salesData.GroupBy(sale => sale.telefonModel);
            // Для каждой группы вычисляем общее количество проданных единиц
            var TelefonStats = TelefonGroups.Select(group => new
            {
                TelefonModel = group.Key,                   // Название модели
                TotalSold = group.Sum(s => s.kolichestvo)    // Сумма проданных единиц
            })
                .OrderByDescending(x => x.TotalSold)     // Сортировка по убыванию количества
                .ToList();                               // Преобразование его в список

            // Самый лучший телефон (первый в списке)
            BestPhone = TelefonStats.First().TelefonModel;
            // Самый худший телефон (последний в списке)
            WorstPhone = TelefonStats.Last().TelefonModel;
        }
        // в) Метод для определения двух телефонов, приносящих наибольшую прибыль
        public List<string> GetTopTwoProfitablePhones()
        {

            // Группируем продажи по модели телефона
            var TelefonGroups = salesData.GroupBy(sale => sale.telefonModel);

            // Для каждой группы вычисляем общую прибыль
            var ProfitablePhones = TelefonGroups.Select(group => new
            {
                TelefonModel = group.Key,                    // Название модели
                TotalProfit = group.Sum(s => s.Profit)    // Суммарная прибыль
            })
                .OrderByDescending(x => x.TotalProfit)   // Сортировка по убыванию прибыли
                .Take(2)                                 // Выдаем две первые записи
                .Select(x => x.TelefonModel)               // Выдача только названия моделей
                .ToList();                               // Преобразование в список
            return ProfitablePhones;
        }
        // Метод представления данных как временной ряд
        public void DisplayTimeSeries()
        {
            // Сортируем данные по дате для представления как временного ряда
            var timeSeries = salesData.OrderBy(sale => sale.Date);
            Console.WriteLine("Дата\t\tМодель\t\t\tКоличество\tВыручка");
            Console.WriteLine("---------------------------------------------------------------------");
            // Выводим каждую запись в формате временного ряда
            foreach (var sale in timeSeries)
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}\t{sale.telefonModel,-20}\t{sale.kolichestvo}\t\t{sale.Revenue} рублей");
            }

        }
    }
}
