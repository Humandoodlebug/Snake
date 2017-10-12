using System;
using System.Threading;
using System.Windows;

namespace Snake
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var key = Console.L

            while (true)
            {


                if (Environment.TickCount % 400 == 0)
                {
                    //Move snake

                    //Initialise the snake grid
                    int[,] snakeGrid = new int[15,15];
                    for (int i = 0; i < 15; i++)
                    { for(int j = 0; j < 15; j++)
                        {
                            snakeGrid[i,j] = 0;
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
                            if (snakeGrid[i,j] > 0)
                            {
                                Console.Write("+");
                            } else if (snakeGrid[i,j] < 0) {
                                Console.Write("x");
                            } else {
                                Console.Write(" ");
                            }

                        }
                        Console.Write("\n");
                    }
                }
            }
        }

        static void KeyDown(object sender)
    }
}
