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
