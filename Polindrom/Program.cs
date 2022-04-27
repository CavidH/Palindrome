using System;

namespace Polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPolyndrom(Console.ReadLine()));

            //int input = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(input);
            // int[] arr = new int[] {4, 5, 6, 4, 7, 8, 9, 7};
            // int count = 0;
            // while (input > 0)
            // {
            //     input = input / 10;
            //     count++;
            // }
            //
            //
            // Console.WriteLine(count);

            // string inputText = Console.ReadLine();
            // bool Flag = true;
            //
            // for (int i = 0; i < inputText.Length/2; i++)
            // {
            //     if (inputText[i]!=inputText[inputText.Length-1-i])
            //     {
            //         Flag = false;
            //     }
            // }

        }

        static bool CheckPolyndrom(string text)
        {
            bool flag = true;

            for (int i = 0; i < text.Length/2; i++)
            {
                if (text[i]!=text[text.Length-1-i])
                {
                    flag = false;
                }
            }

            return flag;
        }
    }
}