using System;

namespace CS26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "You. Win. Some. You. Lose. Some";

            string[] subs = text.Split(' ' , '.');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }
    }
}