using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Figure
    {
        protected List<MyPoint> pointList = new List<MyPoint>();

        public void DrawFigure()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        }

        public bool IsHitByPoint(MyPoint point)
        {
            foreach(MyPoint p in pointList)
            {
                if(p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach(MyPoint point in pointList)
            {
                if(figure.IsHitByPoint(point))
                {
                    return true;
                }
            }
            return false;
        }


    }

    
}
