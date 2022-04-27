using System;

namespace Polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Console.WriteLine(CheckPolyndrom(Console.ReadLine()));
        }

        static bool CheckPolyndrom(string text)
        {
            bool flag = true;

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    flag = false;
                }
            }

            return flag;
        }
    }
}