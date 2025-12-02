using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManeClassesAplication
{
    public class Storage
    {
        private int id_;// Приватное поле для хранения идентификатора склада
        private string location_;// Приватное поле для хранения местоположения склада
        private Dictionary<Product, int> products_ = new Dictionary<Product, int>();// Приватное поле для хранения товаров на складе
                                                                                    // Dictionary<Product, int> - словарь, где ключ: объект Product, значение: количество

        public void SetId(int id)// Метод для установки идентификатора склада
        {
            id_ = id; // Присваивание переданного значения приватному полю id_
        }
        public void SetLocation(string location)// Метод для установки местоположения склада
        {
            location_ = location;// Присваивание переданного значения приватному полю location_
        }
        public void SetProductQuantity(Product product, int quantity)// Метод для установки количества товара на складе
        {
            products_.Add(product, quantity); // Добавление пары "товар-количество" в словарь
                                              // ВАЖНО: метод Add выбросит исключение, если товар уже есть в словаре
        }
        public void GetProductQuantity()// Метод для вывода информации о количестве всех товаров на складе
        {
            foreach (Product product in products_.Keys) // Цикл по всем ключам (товарам) в словаре
            {
                Console.WriteLine($"Товар: {product.GetName()}" + " - " + $"{products_[product]} шт."); // Вывод информации в формате: "Товар: Название - Количество шт."
                                                                                                        // products_[product] - получение количества по ключу (товару)
            }
        }
        public void CalculateMoney()// Метод для расчета общей стоимости товаров на складе
        {
            double sum = 0;// Переменная для накопления суммы
            foreach (Product product in products_.Keys)// Цикл по всем товарам в словаре
            {
                sum += product.GetPrice() * products_[product];// Расчет: цена товара × количество товара
                                                               // product.GetPrice() - получение цены товара
                                                               // products_[product] - получение количества товара
            }
            Console.WriteLine($"Общая сумма: {sum} руб.");// Вывод общей суммы
        }
    }
}


