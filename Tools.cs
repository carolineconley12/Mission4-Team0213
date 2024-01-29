﻿class Board
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

    public bool IsValidMove(char[] board, int choice)
    {
        return board[choice - 1] == '1' || board[choice - 1] == '2' || board[choice - 1] == '3' ||
               board[choice - 1] == '4' || board[choice - 1] == '5' || board[choice - 1] == '6' ||
               board[choice - 1] == '7' || board[choice - 1] == '8' || board[choice - 1] == '9';
    }

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
        // Check if the board is full
        foreach (var cell in board)
        {
            if (cell != 'X' && cell != 'O')
                return false;
        }
        return true;
    }
}
