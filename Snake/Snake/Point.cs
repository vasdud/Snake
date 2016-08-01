using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sumb;

        public Point()
        {
            x = 0;
            y = 0;
            sumb = ' ';
        }

        public Point(int _x, int _y, char _sumb)
        {
            x = _x;
            y = _y;
            sumb = _sumb;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sumb);
        }
    }
}
