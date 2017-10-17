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

        static (int row, int column) GetRandomFoodPosition(int[,] grid)
        {
            Random random = new Random();
            (int row, int column) pos;
            do
            {
                pos.row = random.Next(grid.GetLength(0));
                pos.column = random.Next(grid.GetLength(1));
            }
            while (grid[pos.row, pos.column] != 0);
            return pos;
        }

        static void Main(string[] args)
        {
            Direction direction = default(Direction);
            int snakeLength = 3;


            //Initialise the snake grid
            int[,] snakeGrid = new int[15, 15];
            //Initialise the length to 3.
            snakeGrid[8, 8] = 3;
            snakeGrid[8, 7] = 2;
            snakeGrid[8, 6] = 1;
            var preTickCount = 0;

            (int row, int column) snakePosition = (8, 8);
            (int row, int column) foodPosition = GetRandomFoodPosition(snakeGrid);
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

                

                if (Environment.TickCount % 60 < 2)
                {
                    //Draw board
                    switch (direction)
                    {
                        case Direction.Right:
                            snakePosition.column++;
                            break;
                        case Direction.Down:
                            snakePosition.row++;
                            break;
                        case Direction.Left:
                            snakePosition.column--;
                            break;
                        case Direction.Up:
                            snakePosition.row--;
                            break;

                    }
                    //Detecting snake collisions
                    if (snakePosition.row < 0 || snakePosition.column >= snakeGrid.GetLength(1) || snakePosition.column < 0 || snakePosition.column >= snakeGrid.GetLength(1) || snakeGrid[snakePosition.row, snakePosition.column] > 0)
                        break;


                    //Moves snake tail
                    for (int i = 0; i < 15; i++)
                        for (int j = 0; j < 15; j++)
                            if (snakeGrid[i, j] > 0)
                                snakeGrid[i, j]--;


                    if (snakePosition.row == foodPosition.row && snakePosition.column == foodPosition.column)
                    {
                        snakeLength++;
                        foodPosition = GetRandomFoodPosition(snakeGrid);
                    }

                    snakeGrid[snakePosition.row, snakePosition.column] = snakeLength;


                    //Display grid
                    Console.Clear();
                    for (int i = 0; i < snakeGrid.GetLength(0); i++)
                    {
                        for (int j = 0; j < snakeGrid.GetLength(1); j++)
                        {
                            //Console.Write(snakeGrid[i,j]);
                            //Format this properly

                            if (i == snakePosition.row && j == snakePosition.column)
                            {
                                Console.Write(" O");
                            }
                            else if (snakeGrid[i, j] > 0)
                            {
                                Console.Write(" +");
                            }
                            else if (i == foodPosition.row && j == foodPosition.column)
                            {
                                Console.Write(" x");
                            }
                            else
                            {
                                Console.Write(" .");
                            }
                        }
                        Console.Write("\n");
                    }
                }

            }

            Console.WriteLine("\n\nGame over...");

            while (true)
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    Environment.Exit(0);
        }


    }
}
