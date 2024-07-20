using System;

namespace RuzgarGulu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uzunluk giriniz : ");
            int uzunluk = int.Parse(Console.ReadLine());
            int i, j;
            for (i = 0; i <= uzunluk / 2; i++)
            {
                for (j = 0; j < uzunluk; j++)
                {
                    if (i == j) Console.Write(" * ");
                    else if (i + j >= uzunluk - 1) Console.Write(" * ");
                    else if (i <= j && j <= uzunluk / 2) Console.Write(" * ");
                    else Console.Write("   ");
                }
                Console.WriteLine();

            }

            for (i = (uzunluk / 2) + 1; i < uzunluk; i++)
            {
                for (j = 0; j < uzunluk; j++)
                {
                    if (i + j <= uzunluk) Console.Write(" * ");
                    else if (j >= uzunluk / 2 && i >= j) Console.Write(" * ");
                    else Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }

    }
}
