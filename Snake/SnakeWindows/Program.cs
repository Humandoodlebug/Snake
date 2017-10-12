using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWindows
{

    class Program
    {
        
        enum Direction { Right, Down, Up, Left };

        static void Main(string[] args)
        {
            Direction direction;
            (int row, int column) snakePosition = (0, 0);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.RightArrow:
                            direction = Direction.Right;
                            break;
                        case ConsoleKey.DownArrow:
                            direction = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            direction = Direction.Left;
                            break;
                        case ConsoleKey.UpArrow:
                            direction = Direction.Up;
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }


                if (Environment.TickCount % 400 == 0)
                {
                    //Move snake
                }
            }
        }


    }
}
