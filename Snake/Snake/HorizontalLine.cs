using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xReight, int y, char sumb)
        {
            pList = new List<Point>();

            for (int i = xLeft; i < xReight; i++)
            {
                pList.Add(new Point(i, y, sumb));
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
