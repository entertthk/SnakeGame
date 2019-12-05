using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Point
{   
    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
            
    }
    class Snake : Figure
    {
        public Direction Direction;

        public Snake(MyPoint tail, int length, Direction _direction)
        {
            Direction = _direction;
            for(int i = 0; i < length; i++)
            {
                MyPoint newPoint = new MyPoint(tail);
                newPoint.MovePoint(i, Direction);
                pointList.Add(newPoint);
            }
        }

        public void MoveSnake()
        {
            MyPoint tail = pointList.First();
            pointList.Remove(tail);
            MyPoint head = GetNextPoint();
            pointList.Add(head);
            tail.Clear();
            head.Draw();

        }

        public MyPoint GetNextPoint()
        
        {
          
            {
                MyPoint head = pointList.Last();
                MyPoint nextPoint = new MyPoint(head);
                nextPoint.MovePoint(1, Direction);
                
                return nextPoint;
            }
        }

        public void ReadUserKey(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;
            }
            else if(key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;
            }
            else if(key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;

            }
        }

        public bool Eat(MyPoint food)
        {
            
            MyPoint head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.symbol = head.symbol;
                pointList.Add(food);
                
                
                return true;
                
            }
            else
            {
                return false;
            }
        }


    }
}
