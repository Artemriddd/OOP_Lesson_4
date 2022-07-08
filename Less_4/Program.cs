using System;
using System.Collections;

namespace Less_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(); // Хэш таблица

            Building building = new Building(); // Заполнение через методы
            Building.IdCreator();
            building.HeightSetter(100);
            building.FloorsSetter(5);
            building.EntranceSetter(5);
            building.FlatsSetter(50);
            Console.WriteLine($"Номер здания: {Building.IdGetter()}");
            Console.WriteLine($"Высота здания: {building.HeightGetter()}");
            Console.WriteLine($"Количество этажей: {building.FloorsGetter()}");
            Console.WriteLine($"Количество квартир: {building.FlatsGetter()}");
            Console.WriteLine($"Количество подъездов: {building.EntranceGetter()}");

            // Проверка методов по вычислению высоты этажа, кол-ва квартир в подъезде и кол-ва квартир на этаже
            Console.WriteLine($"Высота этажа: {building.FloorHeingt()}");
            Console.WriteLine($"Квартир в подъезде: {building.FlatsInEntrance()}");
            Console.WriteLine($"Квартир на этаже: {building.FlatsInFloor()}");

            hashtable.Add(building.Id, building); //Добавление здания в хэш таблицу

            Building building2 = new Building(); // Заполнение через свойства
            Building.IdCreator();
            building2.Height = 200;
            building2.Floors = 10;
            building2.Entrance = 5;
            building2.Flats = 50;
            Console.WriteLine($"Номер здания: {Building.IdGetter()}");
            Console.WriteLine($"Высота здания: {building2.Height}");
            Console.WriteLine($"Количество этажей: {building2.Floors}");
            Console.WriteLine($"Количество квартир: {building2.Flats}");
            Console.WriteLine($"Количество подъездов: {building2.Entrance}");


            // Проверка методов по вычислению высоты этажа, кол-ва квартир в подъезде и кол-ва квартир на этаже
            Console.WriteLine($"Высота этажа: {building2.FloorHeingt()}");
            Console.WriteLine($"Квартир в подъезде: {building2.FlatsInEntrance()}");
            Console.WriteLine($"Квартир на этаже: {building2.FlatsInFloor()}");

            hashtable.Add(building2.Id, building2); //Добавление здания в хэш таблицу

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
            hashtable.Remove(1); // Удаление по ключу "Уникальный номер здания" элемента из хэш-таблицы

            foreach (DictionaryEntry elem in hashtable) // Проверка что здание удалилось из хэш-таблицы
            {
                Console.WriteLine($"Ключ {elem.Key} и значение {elem.Value}");
            }
        }
    }
}