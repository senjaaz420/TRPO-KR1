using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp10
{
    interface IDrawable
    {
        void Draw();
    }

    class Gamemap : IDrawable
    {
        static int n = 120;
        protected char[,] myArr = new char[n, n];
        void IDrawable.Draw()
        {
            Console.CursorVisible = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //        myArr[i, j] = (char)1;// заполнить массив
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(myArr[i, j]);
                }
            }
        }
    }
    class Cell : Gamemap, IDrawable
    {
        int x = 0;
        int y = 0;
        char Cursor = 0;
        void IDrawable.Draw()
        {
            if (myArr[x, y] == '0')
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine((char)2); // смайлик
            }
            if (myArr[x, y] == '1')
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("#");
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gamemap gamemap = new Gamemap();
            IDrawable d = gamemap;
            d.Draw();

            Console.ReadKey();
        }
    }
}
