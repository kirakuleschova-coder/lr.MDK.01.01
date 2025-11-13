using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant_zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------АНАЛИЗ ПРОДАЖ МОБИЛЬНЫХ ТЕЛЕФОНОВ------");
            var salesData = CreateSampleData();
            var analyzer = new Analitika_prodazhi_telefonov(salesData);
            DateTime startDate = new DateTime(2025, 09, 05);
            DateTime endDate = new DateTime(2025, 09, 08);
            double totalRevenue = analyzer.ReceivingTotalIncome(startDate, endDate);
            // а) Общая сумма проданного за период
            Console.WriteLine($"а) Общая сумма проданных телефонов за период {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}: {totalRevenue} рублей");
            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            analyzer.TheBestAndWorstPhone(out string BestPhone, out string WorstPhone);
            Console.WriteLine($"б) Результаты анализа продаж:");
            Console.WriteLine($"   • Самый продаваемый телефон: {BestPhone}");
            Console.WriteLine($"   • Самый непродаваемый телефон: {WorstPhone}");
            // в) Два телефона, приносящие наибольшую прибыль
            var topProfitablePhones = analyzer.GetTopTwoProfitablePhones();
            Console.WriteLine($"в) Телефоны с наибольшей прибылью:");
            for (int i = 0; i < topProfitablePhones.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {topProfitablePhones[i]}");
            }
            // Отображение временного ряда
            Console.WriteLine("4. Временной ряд продаж:");
            analyzer.DisplayTimeSeries();
        }

        // Метод для создания тестовых данных
        private static List<Rasprodazha_telefonov> CreateSampleData()
        {
            return new List<Rasprodazha_telefonov>
        {
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 09, 05),
                telefonModel = "Samsung galaxy s23+",
                kolichestvo = 12,
                Price = 95000,
               zatrat = 85000
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 09, 05),
                telefonModel = "Xiomi Redmi Note 14 Pro",
                kolichestvo = 6,
                Price = 25061,
                zatrat = 23600
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 11, 06),
                telefonModel = "Google Pixel 8 Pro",
                kolichestvo = 2,
                Price = 89900,
                zatrat = 65000
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 11, 06),
                telefonModel = "Samsung Galaxy S24 Ultra",
                kolichestvo = 4,
                Price = 119900,
                zatrat = 85000
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 11, 07),
                telefonModel = "OnePlus 12",
                kolichestvo = 6,
                Price = 69900,
                zatrat = 48000
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 11, 07),
                telefonModel = "Tecno Pova 6",
                kolichestvo = 7,
                Price = 19900,
                zatrat = 14000
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 11, 08),
                telefonModel = "Samsung Galaxy S24+",
                kolichestvo = 4,
                Price = 101000,
                zatrat = 85000
            },
            new Rasprodazha_telefonov {
                Date = new DateTime(2025, 11, 08),
               telefonModel = "IPhone 16 Pro",
                kolichestvo = 2,
                Price = 129000,
                zatrat = 95000
            }
        };
        }

    }
}

