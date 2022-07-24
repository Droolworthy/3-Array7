using System;

namespace CS26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "You. Win. Some. You. Lose. Some";

            string[] substring = text.Split(' ' , '.');

            foreach (var line in substring)
            {
                Console.WriteLine($"Substring: {line}");
            }
        }
    }
}
