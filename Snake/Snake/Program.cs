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
            HorizontalLine aLineH = new HorizontalLine(5, 10, 8, '_');
            aLineH.Draw();

            VerticalLine aLineV = new VerticalLine(5, 2, 7, '*');
            aLineV.Draw();

            Console.ReadLine();
        }
    }
}
