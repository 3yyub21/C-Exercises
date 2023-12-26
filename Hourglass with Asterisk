using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie die Länge des Pyramids ein: ");
            int Länge = int.Parse(Console.ReadLine());
            Console.Clear();

            static void ReversePyramid (int a)
            {
                for (int i = a; i > 0; i--)
                {
                    for (int h = a; h >= i; h--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= 2*i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }

            ReversePyramid(Länge);

            static void Pyramid (int b)
            {
                for(int i = 0; i <= b; i++)
                {
                    for(int k = b; k >= i ; k--)
                    {
                        Console.Write(" ");
                    }

                    for( int j = 0; j <= 2*i; j++)
                    {                     
                       Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }

            Pyramid(Länge);

            Console.ReadLine();
        }
    }
}
