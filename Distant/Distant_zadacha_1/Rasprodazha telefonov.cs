using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant_zadacha_1
{
    internal class Rasprodazha_telefonov
    {
        public DateTime Date { get; set; }     // Дата продажи (метка времени)
        public string telefonModel { get; set; } // Модель телефона
        public int kolichestvo { get; set; }      // Количество проданных единиц
        public double Price { get; set; }      // Цена за единицу для клиента
        public double zatrat { get; set; }       // Затраты магазина на телефоны

        // Вычисление выгоды магазина
        public double Profit => (Price - zatrat) * kolichestvo;

        // Вычисление дохода магазина
        public double Revenue => Price * kolichestvo;

    }
}
