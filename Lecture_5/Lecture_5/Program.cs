using System;

namespace Lecture._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int real_hour = Convert.ToInt32(DateTime.Now.Hour);

            if (real_hour >= 9 && real_hour < 12)
            {
                Console.WriteLine("Good morning, guys!");
            }
            if (real_hour >= 12 && real_hour < 15)
            {
                Console.WriteLine("Good day, guys!");
            }
            if (real_hour >= 15 && real_hour < 22)
            {
                Console.WriteLine("Good evening, guys!");
            }
            if (real_hour >= 22 && real_hour < 9)
            {
                Console.WriteLine("Go to sleep!!!");
            }
            Console.ReadKey();
        }
    }
}
