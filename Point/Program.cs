using System;
using System.Threading;

namespace Point
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Start:
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(95, 25);
            Console.SetBufferSize(95, 25);

            Walls walls = new Walls(80, 25);
            walls.DrawWalls();

            int x1Offset = 81;
            int y1Offset = 1;
            
            Console.SetCursorPosition(x1Offset, y1Offset++);

            ShowMessage("POINTS:", x1Offset, y1Offset++);

            MyPoint tail = new MyPoint(6, 5, Convert.ToChar("\u2588"));
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.DrawFigure();
            

            FoodCatering foodCatered = new FoodCatering(80, 25, '$');
            MyPoint food = foodCatered.CaterFood();
            food.Draw();
            int points = 1;

            while(true)
            {
                if (walls.IsHitByFigure(snake))
                {
                    Console.Beep();
                    break;
                }
                
                if(snake.Eat(food))
                {
                    Console.Beep();
                    food = foodCatered.CaterFood();
                    int x11ffset = 89;
                    int y11ffset = 2;

                    Console.SetCursorPosition(x11ffset, y11ffset++);

                    Console.WriteLine($"{points}", x11ffset, y11ffset++);
                    points++;
                    food.Draw();
                }
                else
                {
                    snake.MoveSnake();
                }
                Thread.Sleep(100);
                
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReadUserKey(key.Key);
                }
  
            }
            WriteGameOver();
            int xxOffset = 52;
            int yyOffset = 10;
            Console.SetCursorPosition(xxOffset, yyOffset++);
            string userAnswer = Console.ReadLine();

            if (userAnswer == "y")
            {
                Console.Clear();
                goto Start;
            }
            else
            {
                int xOffset = 35;
                int yOffset = 8;
                Console.SetCursorPosition(xOffset, yOffset++);
                Console.Clear();
                ShowMessage("BYE!", xOffset, yOffset++);
            }

            Console.ReadLine();  
        }
        public static void GameStart()
        {
            Console.Clear();
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(xOffset, yOffset++);

            ShowMessage("GAME OVER", xOffset, yOffset++);


            ShowMessage("PLAY AGAIN? (y/n)", xOffset, yOffset++);


        }
        public static void WriteGameOver()
        {
            Console.Clear();
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(xOffset, yOffset++);
            
            ShowMessage("GAME OVER", xOffset, yOffset++);

            
            ShowMessage("PLAY AGAIN? (y/n)", xOffset, yOffset++);

        }

        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
