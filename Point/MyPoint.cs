using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class MyPoint
    {
            public int x;
            public int y;
            public char symbol;
            public MyPoint(int _x, int _y, char _symbol)
            {
                x = _x;
                y = _y;
                symbol = _symbol;
            }

            public MyPoint(MyPoint _p)
            {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;
            }

            public void Draw()
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        
            public void Clear()
            {
            symbol = ' ';
            Draw();
            }

            public void MovePoint(int offset, Direction direction)

            { 
                if(direction == Direction.RIGHT)
                {
                    x = x + offset;
                    
                }
                else if(direction == Direction.LEFT)
                {
                x = x - offset;
                }

                else if (direction == Direction.UP)
                {
                     y = y - offset;
                }
                else if (direction == Direction.DOWN)
                {
                     y = y + offset;
                }


        }

        public bool IsHit(MyPoint point)
        {
            return point.x == x && point.y == y;
        }

    }
}
