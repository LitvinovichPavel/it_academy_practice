using System;
using System.Collections.Generic;
using System.Linq;


namespace Lecture_14.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeighbors = new List<Neighbor> { };

            floorNeighbors.Add(new Neighbor("Alcoholic", 1, 111111111));
            floorNeighbors.Add(new Neighbor("Petrovich", 2, 222222222));
            floorNeighbors.Add(new Neighbor("Malevich", 3, 333333333));
            floorNeighbors.Add(new Neighbor("Popovich", 4, 4444444));

            Console.Write("Введите номер квартиры (от 1 до 4): ");
            int numApartment;
            numApartment = Convert.ToInt32(Console.ReadLine());
            Neighbor result = floorNeighbors.Where(numAp => numAp.FlatNumber == numApartment).FirstOrDefault();
            Console.WriteLine($"Номер телефона: {result.PhoneNumber.ToString()}, имя: {result.FullName}");
        }
    }
}
