using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3000];// Создание массива из 3000 элементов
            Random random = new Random();// Создание объекта Random для генерации случайных чисел
            for (int i = 0; i < array.Length; i++)// Заполнение массива случайными числами от 10 до 9999
            {
                array[i] = random.Next(10, 10000);
            }
            Console.WriteLine("Исходные данные: ");// Вывод исходного массива (ВНИМАНИЕ: выведет 3000 чисел в одну строку!)
            Console.WriteLine("[" + string.Join(", ", array) + "]");
            List<int> Summa = new List<int>();// Создание списка для хранения сумм
            for (int i = 0; i < array.Length - 2; i += 2)// Цикл с шагом 2: суммирование array[i] + array[i+2]
                                                         // Условие i < array.Length - 2 предотвращает выход за границы массива
            {
                int sum = array[i] + array[i + 2];// Сумма текущего элемента и элемента через один
                Summa.Add(sum);
            }
            Console.WriteLine("Результат: ");// Вывод результата
            Console.WriteLine("[" + string.Join(", ", Summa) + "]");// Вывод результата
        }
    }
}
