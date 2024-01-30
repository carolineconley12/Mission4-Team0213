using System;

Tools t = new Tools();

class Game
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] choices = new char[board.Length];

        int turn = 1;
        bool play = true;

        Game game = new Game();

        while (play)
        {
            game.DisplayBoard(board); //change later to Tools.PrintBoard(board)

            Console.WriteLine($"Player {(turn % 2 != 0 ? 1 : 2)}, enter your position choice (1-9):");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guessNumber) || !game.ValidGuess((char)(guessNumber + '0'), choices))
            {
                continue;
            }

            char symbol = turn % 2 != 0 ? 'X' : 'O';
            board[guessNumber - 1] = symbol;
            choices[guessNumber - 1] = symbol;

            // Add win condition check here
            // Set play to false if someone wins or if it's a tie

            turn++;
        }
    }

    public void DisplayBoard(char[] board)
    {
        for (int i = 0; i < board.Length; i += 3)
        {
            Console.WriteLine($"{board[i]} | {board[i + 1]} | {board[i + 2]}");
            if (i < 6)
            {
                Console.WriteLine("--+---+--");
            }
        }
    }

    public bool ValidGuess(char guess, char[] choices)
    {
        if (!Char.IsDigit(guess))
        {
            Console.WriteLine("Input must be a number. Try again.");
            return false;
        }
        else if (guess < '1' || guess > '9')
        {
            Console.WriteLine("The guess must be between 1-9. Try again.");
            return false;
        }
        else if (choices.Contains(guess))
        {
            Console.WriteLine("This position already has a guess. Please choose a new one:");
            return false;
        }
        return true;
    }
}