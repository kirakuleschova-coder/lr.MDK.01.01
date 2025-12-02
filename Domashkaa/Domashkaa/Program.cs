using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashkaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: "); // Вывод приглашения для пользователя в консоль
            string input = Console.ReadLine();  // Чтение введённой пользователем строки с консоли
            input = input.Trim(); // Удаление начальных и конечных пробельных символов из строки
            bool isNumber = true;
            // Флаг, указывающий, является ли введённая строка числом
            char[] numberSymbols = new char[13] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', ',', '.' };// Массив допустимых символов для числа:
                                                                                                                    // цифры 0-9, пробел, запятая и точка
            for (int index = 0; index < input.Length; index++)// Цикл для проверки каждого символа в строке
            {
                char symbol = input[index];// Получение текущего символа
                if (numberSymbols.Contains(symbol)) // Проверка, содержится ли символ в массиве допустимых символов
                {
                    isNumber = true;// Если символ допустимый, устанавливаем флаг в true
                }
                else
                {
                    isNumber = false;// Если найден недопустимый символ, устанавливаем флаг в false
                    index = input.Length;// Принудительный выход из цикла, устанавливая индекс равным длине строки
                }
            }

            if (!isNumber)// Проверка, не является ли строка числом
            {
                Console.WriteLine("Введите пожалуйста, число"); // Если строка содержит недопустимые символы, выводим сообщение об ошибке
                return; // Завершение выполнения текущего метода или блока кода
            }
            string zapatay = input.Replace(",", ".").Replace(",", ".").Replace(" ", "");// Замена разделителей: запятых на точки и удаление пробелов
                                                                                        // (обратите внимание на ошибку: .Replace(",", ".") вызывается дважды подряд)
            input = NewMethod(input); // Вызов неопределённого метода NewMethod с параметром input
                                      // Этот метод не описан в предоставленном коде, поэтому его действие неизвестно
            try // Блок обработки исключений
            {
                double number = double.Parse(zapatay, System.Globalization.CultureInfo.InvariantCulture);// Парсинг строки в число типа double с использованием инвариантной культуры
                                                                                                         // (точка как десятичный разделитель)
                Console.WriteLine("Число = " + number);// Вывод результата преобразования
            }
            catch
            {
                Console.WriteLine("Ошибка");// Обработка любой ошибки, возникающей при парсинге
            }
        }

        private static string NewMethod(string input)
        {
            return input.Replace(" ", "");
        }
    }
    }

