﻿using System;

namespace Aufgabe8_OXO
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] matchfield = new char[3, 3];
            Initialize(matchfield);
            int counter = 0;
            int row = ' ';
            int col = ' ';
            int input = ' ';
            
            while (true)
            {
                Console.Clear();
                Print(matchfield);

                Console.Write("Please enter your Pick on the Numpad 1-9  and Press ENTER \n\n Order of the matchfield numbers: \n\n 7 8 9 \n 4 5 6 \n 1 2 3  ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    row = 2;
                    col = 0;
                }

                if (input == 2)
                {
                    row = 2;
                    col = 1;
                }

                if (input == 3)
                {
                    row = 2;
                    col = 2;
                }

                if (input == 4)
                {
                    row = 1;
                    col = 0;
                }

                if (input == 5)
                {
                    row = 1;
                    col = 1;
                }

                if (input == 6)
                {
                    row = 1;
                    col = 2;
                }

                if (input == 7)
                {
                    row = 0;
                    col = 0;
                }

                if (input == 8)
                {
                    row = 0;
                    col = 1;
                }

                if (input == 9)
                {
                    row = 0;
                    col = 2;
                }


                matchfield[row, col] = player;

                if (player == matchfield[0,0] && player == matchfield[0,1] && player == matchfield[0,2])
                {
                    break;
                }

                if (player == matchfield[1,0] && player == matchfield[1,1] && player == matchfield[1,2])
                {
                    break;
                }

                if (player == matchfield[2,0] && player == matchfield[2,1] && player == matchfield[2,2])
                {
                    break;
                }

                if (player == matchfield[0,0] && player == matchfield[1,0] && player == matchfield[2,0])
                {
                    break;
                }

                if (player == matchfield[0,1] && player == matchfield[1,1] && player == matchfield[2,1])
                {
                    break;
                }

                if (player == matchfield[0,2] && player == matchfield[1,2] && player == matchfield[2,2])
                {
                    break;
                }

                if (player == matchfield[0,0] && player == matchfield[1,1] && player == matchfield[2,2])
                {
                    break;
                }

                if (player == matchfield[2,0] && player == matchfield[1,1] && player == matchfield[0,2])
                {
                    break;
                }

                counter = counter + 1;

                if (counter == 9)
                {
                    break;
                }
                
                player = ChangeTurn(player);
                
            }  

            

            Console.Clear();
            Print(matchfield);
            Console.WriteLine("!!  " + player + "  has won the Game  !!");

            if (counter == 9)
            {
                Console.Clear();
                int madebyTimG = ' ';
                Print(matchfield);
                Console.WriteLine("!!  DRAW  !!");
                    
            }
        }


        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X' )
                {
                    return 'O';
                }
                else
                {
                    return 'X';
                }
        }


        static void Initialize(char[,] matchfield)
        {
            for (int row = 0; row < 3; row++)
            {                
                for (int col = 0; col < 3; col++)
                {
                    matchfield[row, col] = ' ';
                }
            }
        }


        static void Print(char[,] matchfield)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matchfield[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
