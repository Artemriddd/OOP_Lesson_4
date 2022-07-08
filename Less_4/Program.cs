using System;
using System.Collections;

namespace Less_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(); // Хэш таблица

            Building building3 = Creator.CreateBuild(200, 10, 50, 5); // Заполнение через фабричный метод Creator

            // Проверка методов по вычислению высоты этажа, кол-ва квартир в подъезде и кол-ва квартир на этаже
            Console.WriteLine($"Высота этажа: {building3.FloorHeingt()}");
            Console.WriteLine($"Квартир в подъезде: {building3.FlatsInEntrance()}");
            Console.WriteLine($"Квартир на этаже: {building3.FlatsInFloor()}");
            hashtable.Add(building3.Id, building3);  //Добавление здания в хэш таблицу

            Building building4 = Creator.CreateBuild(200, 10, 5); // Заполнение через перегруженный фабричный метод Creator

            building4.Flats = 50; // Заполняем кол-во квартир через свойство

            // Проверка методов по вычислению высоты этажа, кол-ва квартир в подъезде и кол-ва квартир на этаже
            Console.WriteLine($"Высота этажа: {building4.FloorHeingt()}");
            Console.WriteLine($"Квартир в подъезде: {building4.FlatsInEntrance()}");
            Console.WriteLine($"Квартир на этаже: {building4.FlatsInFloor()}");
            hashtable.Add(building4.Id, building4);  //Добавление здания в хэш таблицу

            foreach (DictionaryEntry elem in hashtable) // Провека хэш-таблицы
            {
                Console.WriteLine($"Ключ {elem.Key} и значение {elem.Value}");
            }
        }
    }
}
