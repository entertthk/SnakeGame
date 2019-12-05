using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class VerticalLine : Figure
    {
        

        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            
            for(int i = yTop; i <= yBottom; i++)
            {
                MyPoint newPoint = new MyPoint(x, i, symbol);
                pointList.Add(newPoint);

            }
        }

        public void DrawVerticalLine()
        {
            foreach(MyPoint point in pointList)
            {
                point.Draw();
            }
        }
    }
}
