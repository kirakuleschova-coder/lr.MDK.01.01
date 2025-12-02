using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManeClassesAplication
{
    public struct ReportRow
    {
        public string Product;// Публичное поле для хранения названия продукта
                              // Модификатор public означает, что поле доступно из любого места в коде
        public double Price;// Публичное поле для хранения цены продукта
                            // Тип double используется для дробных чисел (цена может быть нецелой)
        public int Quantity;// Публичное поле для хранения количества продукта
                            // Тип int используется для целых чисел (количество обычно целое)
    }
}
