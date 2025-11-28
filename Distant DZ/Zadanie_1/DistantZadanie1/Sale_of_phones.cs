using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistantZadanie1
{
    internal class Sale_of_phones
    {
        public DateTime Date;     // Дата продажи (метка времени)
        public string PhoneModel; // Модель телефона
        public int Quantity;      // Количество проданных единиц
        public double Price;      // Цена за единицу для клиента

        // Вычисление дохода магазина
        public double Revenue => Price * Quantity;
    }
}

