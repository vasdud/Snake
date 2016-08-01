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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sumb = '*';
            p1.Draw(p1.x, p1.y, p1.sumb);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sumb = '#';
            p2.Draw(p2.x, p2.y, p2.sumb);

            Console.ReadLine();
        }
    }
}
