

using System;
using System.Collections.Generic;

// Определяем интерфейс для холодильника
public interface IRefrigerator
{
    void AddProduct(string productName); // Метод для добавления продукта в холодильник
    void RemoveProduct(string productName); // Метод для удаления продукта из холодильника
    void DisplayProducts(); // Метод для отображения списка продуктов в холодильнике
}

// Реализация класса холодильника
public class Refrigerator : IRefrigerator
{
    private List<string> products; // Поле для хранения списка продуктов

    public Refrigerator()
    {
        products = new List<string>(); // Инициализация списка продуктов
    }

    // Реализация метода добавления продукта в холодильник
    public void AddProduct(string productName)
    {
        products.Add(productName); // Добавляем продукт в список
    }

    // Реализация метода удаления продукта из холодильника
    public void RemoveProduct(string productName)
    {
        products.Remove(productName); // Удаляем продукт из списка
    }

    // Реализация метода отображения списка продуктов в холодильнике
    public void DisplayProducts()
    {
        Console.WriteLine("Продукты в холодильнике:");
        foreach (var product in products)
        {
            Console.WriteLine(product); // Выводим каждый продукт на отдельной строке
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр холодильника
        IRefrigerator refrigerator = new Refrigerator();

        // Добавляем продукты в холодильник
        refrigerator.AddProduct("Молоко");
        refrigerator.AddProduct("Яйца");
        refrigerator.AddProduct("Овощи");

        // Удаляем продукт из холодильника
        refrigerator.RemoveProduct("Яйца");

        // Отображаем список продуктов в холодильнике
        refrigerator.DisplayProducts();

        Console.ReadKey(); // Ждем нажатия клавиши, чтобы консоль не закрылась сразу
    }
}
