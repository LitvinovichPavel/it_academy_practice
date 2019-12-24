using System;


namespace Lecture_07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNull = new int [0]; // задача1. пустой массив               

            Console.WriteLine("Задача 2.");
            string[] array1 = new[] { "32", "A", "Hello" }; //задача 2
            
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
            Console.WriteLine("Конечный массив");
            
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Задача 3."); //Задача 3

            
            int[] arrayMinMax = new int[13];               //массив случайных чисел
                    for (int cell = 0; cell < 13; cell++)
                    {
                        int ran = new Random().Next(-10, 10);
                        arrayMinMax[cell] = ran;
                        Console.WriteLine($"Значение {cell} элемента массива случайных чисел = {ran}");
                    }

        }
    }
}
