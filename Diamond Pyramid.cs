using System;

namespace Aufgaben
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie die Höhe des Pyramids: ");
            int Höhe = int.Parse(Console.ReadLine());

            static void Pyramid (int a)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int h  = a; h >= i; h--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*" + " ");
                    }

                    Console.WriteLine();
                }
            }

            Pyramid(Höhe);

            static void ReversePyramid(int a)
            {
                for (int i = a-2; i >= 0; i--)
                {
                    for (int j = a; j >= i ; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int l = 0; l <= i; l++)
                    {
                        Console.Write("*" + " ");
                    }

                    Console.WriteLine();
                }
            }

            ReversePyramid(Höhe);

            Console.ReadKey();
        }
    }
}
