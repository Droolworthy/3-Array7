//Дана строка с текстом, используя метод строки String.Split() получить массив слов, 
//которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки..
using System;

namespace CS26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "You. Win. Some. You. Lose. Some";

            string[] stringArray = text.Split(' ' , '.');

            foreach (string word in stringArray)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}
