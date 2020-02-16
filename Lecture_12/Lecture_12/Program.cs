using System;

namespace Lecture_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Figures[] arr = new Figures[5];

            arr[0] = new Circle("Circle", rand.Next(1, 10));
            arr[1] = new Square("Square", rand.Next(1, 10));
            arr[2] = new Triangle("Triangle", rand.Next(1, 10));
            arr[3] = new Triangle("Triangle", rand.Next(1, 10));
            arr[4] = new Square("Square", rand.Next(1, 10));

            Result(arr);
        }
        public static void Result(Figures[] mas)
        {
            foreach (var item in mas)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item}. Square is {item.figureArea()}");
            }
        }
    }
}
