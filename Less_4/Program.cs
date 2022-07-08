using System;

namespace Less_4
{
    class Program
    {
        static void Main(string[] args)
        {
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


            Console.WriteLine($"Высота этажа: {building.FloorHeingt()}");
            Console.WriteLine($"Квартир в подъезде: {building.FlatsInEntrance()}");
            Console.WriteLine($"Квартир на этаже: {building.FlatsInFloor()}");

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


            Console.WriteLine($"Высота этажа: {building2.FloorHeingt()}");
            Console.WriteLine($"Квартир в подъезде: {building2.FlatsInEntrance()}");
            Console.WriteLine($"Квартир на этаже: {building2.FlatsInFloor()}");
        }
    }
}