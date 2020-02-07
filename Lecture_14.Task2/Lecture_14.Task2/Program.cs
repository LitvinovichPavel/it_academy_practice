using System;

namespace Lecture_14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, author;
            double time;
            int year;

            Console.Write("Укажите название песни: ");
            name = Console.ReadLine();
            Console.Write("Укажите длительность песни: ");
            time = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите автора песни: ");
            author = Console.ReadLine();
            Console.Write("Укажите год песни: ");
            year = Convert.ToInt32(Console.ReadLine());

            Song song = new Song(name, time, author, year);
            dynamic info = GetClass.GetSongData(song);
            Console.WriteLine($"{info.name}, {info.time}, {info.year}");
        }
    }
}
