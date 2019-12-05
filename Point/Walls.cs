using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Walls
    {
        List<Figure> wallList;
        List<Figure> wallList2;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, Convert.ToChar("\u2588"));
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, Convert.ToChar("\u2588"));
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, Convert.ToChar("\u2588"));
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth -2, Convert.ToChar("\u2588"));

            Random rnd = new Random();
            
            HorizontalLine newLine = new HorizontalLine(rnd.Next(5, 70), rnd.Next(5, 70), rnd.Next(0, 25), Convert.ToChar("\u2588"));
            VerticalLine newLine2 = new VerticalLine(rnd.Next(1, 23), rnd.Next(1, 23), rnd.Next(0, 24), Convert.ToChar("\u2588"));

            
            wallList.Add(newLine2);
            wallList.Add(newLine);
            
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }


        public void DrawWalls()
        {
            foreach(Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach(Figure wall in wallList)
            {
                if(wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
