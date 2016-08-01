using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char c1 = '*';

            Draw(x1, y1, c1);

            int x2 = 4;
            int y2 = 5;
            char c2 = '#';

            Draw(x2, y2, c2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write( symb );
        }
    }
}
