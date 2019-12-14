using System;

namespace Lecture._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Спомощью оператора if-else-if
            int real_hour = Convert.ToInt32(DateTime.Now.Hour);
            if (real_hour >= 9 && real_hour < 12)
            {
                Console.WriteLine("Good morning, guys!");
            }
            else if (real_hour >= 12 && real_hour < 15)
            {
                Console.WriteLine("Good day, guys!");
            }
            else if (real_hour >= 15 && real_hour < 22)
            {
                Console.WriteLine("Good evening, guys!");
            }
            else
            {
                Console.WriteLine("Go to sleep!!!");
            }

            //с помощью оператора switch
            switch (real_hour)
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Good day, guys!");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine("Good evening, guys!");
                    break;
                case 22:
                case 23:
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Go to sleep!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
