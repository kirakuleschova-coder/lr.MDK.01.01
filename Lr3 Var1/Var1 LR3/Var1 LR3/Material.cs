using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1_LR3
{
    public class Material
    {
        // Свойства, соответствующие столбцам CSV
        public string PartGroup { get; set; }       // Общая группа (для какой детали)
        public string Name { get; set; }            // Элемент (название материала)
        public decimal Cost { get; set; }           // Атрибут_1 (Стоимость)
        public string Supplier { get; set; }        // Атрибут_2 (Поставщик)
        public string NomenclatureGroup { get; set; } // Атрибут_3 (Номенклатурная группа)
        public string ImagePath { get; set; }        // Ссылка на картинку

        // Переопределим ToString() для красивого отображения в ComboBox
        public override string ToString()
        {
            return Name;
        }
    }
}