using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_Team0213
{
    internal class Board
    {
        // create the inital blank board
        public void PrintBoard(char[] board)
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        // makes sure that the move is valid and goes into the correct box
        public bool IsValidMove(char[] board, int choice)
        {
            return board[choice - 1] == '1' || board[choice - 1] == '2' || board[choice - 1] == '3' ||
                   board[choice - 1] == '4' || board[choice - 1] == '5' || board[choice - 1] == '6' ||
                   board[choice - 1] == '7' || board[choice - 1] == '8' || board[choice - 1] == '9';
        }

        // this method checks to make sure that the guess is valid
        public bool ValidGuess(char guess, char[] choices)
        {
            if (!IsValidMove(choices, guess))
            {
                Console.WriteLine("The guess must be a number between 1-9. Please try again.");
                return false;
            }
            else if (guess < '1' || guess > '9')
            {
                Console.WriteLine("The guess must be between 1-9. Please try again.");
                return false;
            }
            else if (choices.Contains(guess))
            {
                Console.WriteLine("This position already has a guess. Please choose a new one:");
                return false;
            }
            return true;
        }

        // this method determies the winner of the game
        public bool IsWinner(char[] board)
        {
            // Check rows, columns, and diagonals for a win
            return (board[0] == board[1] && board[1] == board[2]) ||
                   (board[3] == board[4] && board[4] == board[5]) ||
                   (board[6] == board[7] && board[7] == board[8]) ||
                   (board[0] == board[3] && board[3] == board[6]) ||
                   (board[1] == board[4] && board[4] == board[7]) ||
                   (board[2] == board[5] && board[5] == board[8]) ||
                   (board[0] == board[4] && board[4] == board[8]) ||
                   (board[2] == board[4] && board[4] == board[6]);
        }

        public bool IsBoardFull(char[] board)
        {
            // Check if the board is full -- game will end if it is
            foreach (var cell in board)
            {
                if (cell != 'X' && cell != 'O')
                    return false;
            }
            return true;
        }
    }
}
