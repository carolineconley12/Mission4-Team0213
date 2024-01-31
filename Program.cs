using System;
using Mission4_Team0213;

class Game
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] choices = new char[board.Length];

        int turn = 1;
        bool play = true;

        Board b = new Board();

        while (play)
        {
            b.PrintBoard(board);

            Console.WriteLine($"Player {(turn % 2 != 0 ? 1 : 2)}, enter your position choice (1-9):");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guessNumber) || !b.ValidGuess((char)(guessNumber + '0'), choices))
            {
                continue;
            }

            char symbol = turn % 2 != 0 ? 'X' : 'O';
            board[guessNumber - 1] = symbol;
            choices[guessNumber - 1] = char.Parse(input);


            b.IsBoardFull(board);

            b.IsWinner(board);


            if (b.IsWinner(board))
            {
                Console.WriteLine($"Player {(turn % 2 != 0 ? 1 : 2)} has won!");
                play = false;
            }

            if (b.IsBoardFull(board) && (!b.IsWinner(board)))
            {
                Console.WriteLine("You tied!");
                play = false;
            }
            

            turn++;
        }
    }

}