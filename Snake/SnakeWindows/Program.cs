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

            //Initialise the snake grid
            int[,] snakeGrid = new int[15,15];
            for (int i = 0; i < 15; i++)
            { for(int j = 0; j < 15; j++)
                {
                    snakeGrid[i,j] = 0;
                }
            }

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
                    for (int i = 0; i < 15; i++) { 
                        for(int j = 0; j < 15; j++) {
                            
                            
                        }
                    }
                    
                    //Initialise the length to 3.
                    snakeGrid[7,7] = 3;
                    snakeGrid[7,6] = 2;
                    snakeGrid[7,5] = 1;

                    //Update the snake grid
                    for (int i = 0; i < 15; i++)
                    { for(int j = 0; j < 15; j++)
                        {
                            //Console.Write(snakeGrid[i,j]);
                            //Format this properly
                            if (snakeGrid[i,j] > 0) {
                                Console.Write("+");
                            } else if (snakeGrid[i,j] < 0) {
                                Console.Write("x");
                            } else {
                                Console.Write(".");
                            }
                        }
                        Console.Write("\n");
                    }
                }
            }
        }


    }
}
