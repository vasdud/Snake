using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yBottom, int yTop, char sumb)
        {
            pList = new List<Point>();

            for (int i = yBottom; i < yTop; i++)
            {
                pList.Add(new Point(x, i, sumb));
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
