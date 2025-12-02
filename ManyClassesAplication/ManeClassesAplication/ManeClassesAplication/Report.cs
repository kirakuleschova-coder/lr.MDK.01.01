using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManeClassesAplication
{
    public class Report
    {
        private List<ReportRow> rows_ = new List<ReportRow>();// Приватное поле для хранения списка строк отчета
                                                              // Инициализируется новым пустым списком при создании объекта Report
        public void AddRecord(ReportRow row) // Публичный метод для добавления строки в отчет
                                             // Принимает параметр типа ReportRow
        {
            rows_.Add(row); // Добавление переданной строки в конец списка rows_
        }
        public string ConvertReportToString(ReportRow row)// Приватный или публичный метод для преобразования одной строки отчета в строковый формат
                                                          // Возвращает строку в формате "Продукт;Количество;Цена"
        {
            return row.Product + ";" + row.Quantity + ";" + row.Price;// Конкатенация свойств строки отчета через точку с запятой
        }
        public string ConvertAllToString() // Метод для преобразования всего отчета в строковый формат
        {
            if (rows_.Count == 0)// Проверка, пуст ли отчет
                return "Отчет пуст";// Возвращаем сообщение, если отчет пуст
            StringBuilder sb = new StringBuilder(); // Создание объекта StringBuilder для эффективной работы со строками
            foreach (ReportRow row in rows_)// Цикл по всем строкам отчета
            {
                sb.AppendLine(ConvertReportToString(row));// Добавление преобразованной строки в StringBuilder с переводом строки
            }
            return sb.ToString();// Возврат собранной строки
        }
        public override string ToString()// Переопределение стандартного метода ToString()
                                         // Позволяет использовать Console.WriteLine(report) для вывода отчета
        {
            return ConvertAllToString(); // Вызов метода ConvertAllToString для получения строкового представления
        }
        public void CalculateSum()// Метод для расчета и вывода общей суммы отчета
        {
            double sum = 0;// Переменная для накопления суммы
            foreach (ReportRow row in rows_)// Цикл по всем строкам отчета
            {
                sum += row.Quantity * row.Price; // Расчет суммы: количество × цена и добавление к общей сумме
            }
            Console.WriteLine("Сумма: " + sum + "руб.");  // Вывод результата в консоль
        }
    }
}
