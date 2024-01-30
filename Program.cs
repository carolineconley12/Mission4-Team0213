﻿using System;
using System.Security.Cryptography.X509Certificates;
using Mission4_Team0213;
using Tools.cs;

// please please
class Game
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Initialize the game board
        int[] board = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int[] choices = { };

        int turn = 1;

        bool play = true;



        do
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (turn % 2 != 0)
                {
                    Console.WriteLine("Player 1, enter your position choice (1-9):");
                    char guess = Console.ReadLine();

                    choices[i] = char.Parse(Console.ReadLine());

                }
            }

        } while (play == true);





    }

    public bool ValidGuess(string guess, string choices)
    {
        bool result = true;
        if (!Char.IsNumber(guess[0]))
        {
            Console.WriteLine("Input must be a number. Try again");
            result = false;
        }
        else if ((int.Parse(guess) < 1) || int.Parse(guess) > 9)
        {
            Console.WriteLine("The guess must be between 1-9. Try again");
            result = false;
        }
        else if (choices.Contains(guess))
        {
            Console.WriteLine("This position already has a guess. Please choose a new one: ");
        }

        return result;
    }
}
