using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class FoodCatering
    {
        int MapWidth;
        int MapHeight;
        char Symbol;

        Random rnd = new Random();

        public FoodCatering(int _mapWidth, int _mapHeight, char _symbol)
        {
            MapWidth = _mapWidth;
            MapHeight = _mapHeight;
            Symbol = _symbol;
        }

        public MyPoint CaterFood()
        {
            int x = rnd.Next(2, MapWidth - 2);
            int y = rnd.Next(2, MapHeight - 2);
            return new MyPoint(x, y, Symbol);
        }
    }
}
