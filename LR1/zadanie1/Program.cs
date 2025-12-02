using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в массиве: ");// Вывод приглашения для ввода количества чисел
            int n = int.Parse(Console.ReadLine());// Чтение ввода пользователя и преобразование строки в целое число
            int[] array = new int[n];// Создание массива целых чисел размером n
            int EvenCount = 0;// Переменные для подсчёта чётных и нечётных чисел
            int OddCount = 0;
            Console.WriteLine($"Введите " + n + " целых чисел: ");// Вывод приглашения для ввода n чисел
            for (int i = 0; i < n; i++)// Цикл для ввода n чисел
            {
                array[i] = int.Parse(Console.ReadLine());// Чтение и преобразование введённого числа
                if (array[i] % 2 == 0)// Проверка чётности числа
                {
                    EvenCount++;  // Увеличение счётчика чётных чисел
                }
                else
                {
                    OddCount++; // Увеличение счётчика нечётных чисел
                }
            }
            Console.WriteLine($"Количество четных элементов: " + EvenCount);// Вывод результатов
            Console.WriteLine($"Количество нечетных элементов: " + OddCount);// Вывод результатов
        }
    }
}
