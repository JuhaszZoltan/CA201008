using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA201008
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            Hello(10, 10);
            Kilepes();
        }

        static void Hello(int szinKod, int db)
        {
            Console.ForegroundColor = (ConsoleColor)szinKod;
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.ResetColor();
        }

        static void Kilepes()
        {
            Console.WriteLine("nyod meg az Esc-t a kilépéshez!");
            ConsoleKey c = Console.ReadKey(true).Key;
            while (c != ConsoleKey.Escape)
            {
                c = Console.ReadKey(true).Key;
            }
            Console.Clear();
            for (int i = 3; i >= 1; i--)
            {
                Console.Write(i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
            }
            Console.WriteLine("Viszont látásra!");
            Thread.Sleep(2000);
        }
    }
}
