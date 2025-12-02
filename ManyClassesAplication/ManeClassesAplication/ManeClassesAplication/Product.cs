using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManeClassesAplication
{
    public class Product
    {
        private string name_;// Приватное поле для хранения названия товара
                             // Символ '_' в конце имени - соглашение об именовании приватных полей
        private double price_;// Приватное поле для хранения цены товара
                              // Тип double используется для чисел с плавающей точкой (дробные значения)
        public string GetName()// Публичный метод для получения названия товара
                               // Возвращает значение приватного поля name_
        {
            return name_; // Возвращает текущее значение поля name_
        }
        public double GetPrice()// Публичный метод для получения цены товара
                                // Возвращает значение приватного поля price_
        {
            return price_;// Возвращает текущее значение поля price_
        }
        public void SetName(string name)// Публичный метод для установки названия товара
                                        // Принимает строковый параметр name
        {
            name_ = name;// Присваивает переданное значение приватному полю name_
        }
        public void SetPrice(double price)// Публичный метод для установки цены товара
                                          // Принимает числовой параметр price типа double
        {
            price_ = price;// Присваивает переданное значение приватному полю price_
        }
    }
}
