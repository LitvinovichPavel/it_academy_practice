using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lecture_07.Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        {
            int[] arrayNull = new int[0]; //пустой массив
            foreach (var item in arrayNull)
            {
                Console.WriteLine(item); //ничего не выводит
            }
        }
        static void Task2()
        {
            Console.WriteLine("Задача 2.");
            string[] array1 = new[] { "32", "A", "Hello" };

            Console.WriteLine("Исходный массив: ");

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            int num1 = int.Parse(array1[0]);
            int sum1 = 10 + num1;
            string sum2 = sum1.ToString();
            array1[0] = sum2;
            string guys = ", guys!";
            array1[2] = array1[2] + guys;
            Console.WriteLine("Конечный массив: ");

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Task3()
        {
            Console.WriteLine("Задача 3.");

            int[] arrayMinMax = new int[13];               //массив случайных чисел
            for (int cell = 0; cell < 13; cell++)
            {
                int ran = new Random().Next(-10, 10);
                arrayMinMax[cell] = ran;
            }
            Console.Write("Массив: ");

            foreach (var item in arrayMinMax)
            {
                Console.Write(item + " ");
            }

            int min, max;
            min = arrayMinMax.Min();
            max = arrayMinMax.Max();
            Console.WriteLine();
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine();
        }
        static void Task4()
        {
            Console.WriteLine("Задача 4.");
            /*
            //Выдает ошибку!!!
            short box = 3;
            object obj = box;  //boxing
            sbyte unBox =(sbyte) obj;  //unboxing
            //Console.WriteLine(unBox);
            */
        }
    }
}
