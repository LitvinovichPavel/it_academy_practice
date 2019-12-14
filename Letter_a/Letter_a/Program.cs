using System;

namespace Letters_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите слово: ");
            string word;
            word = Console.ReadLine();
            string letter_a = "а";
            int count = 0;
            int i = 0;

            while ((i = word.IndexOf(letter_a, i)) != -1)
            {
                i += letter_a.Length;
                count++;
            }

            Console.WriteLine($"В слове {word} буква а встречается {count} раз");
            Console.ReadLine();
        }
    }
}
