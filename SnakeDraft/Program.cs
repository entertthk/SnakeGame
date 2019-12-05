using System;

namespace SnakeDraft
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.SetWindowSize(25, 25);
            Console.SetBufferSize(25, 25);*/

            //Declare point coordinates
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Point p1 = new Point(10, 10, '*');
            p1.Draw();
            /*int x1 = 10;
            int y1 = 10;
            char symbol1 = '*';*/
            //Draw(p1.x, p1.y, p1.symbol);
            /*Console.SetCursorPosition(x1, y1);
            Console.Write(symbol1);*/

            Point p2 = new Point(5, 5, '#');
            p2.Draw();
            /*int x2 = 5;
            int y2 = 5;
            char symbol2 = '#';
            Draw(x2, y2, symbol2);*/
            /* Console.SetCursorPosition(x2, y2);
             Console.Write(symbol2);*/
            Console.ReadLine();
        }

        public static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

    }
}
