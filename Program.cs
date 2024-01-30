using System;
using System.Security.Cryptography.X509Certificates;
using Mission4_Team0213;
class Game
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Initialize the game board
        char[] board = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

        char[] choices = { };

        int turn = 1;

        string strboard = new string(board);

        bool play = true;

        Game game = new Game();

        do
        {
            for (int i = 0; i < board.Length; i++)
            {

                if (turn % 2 != 0)
                {
                    Console.WriteLine("Player 1, enter your position choice (1-9):");
                    char guess = char.Parse(Console.ReadLine());
                    choices[i] = guess;

                    game.ValidGuess(guess, choices);

                    char symbol = 'X';

                    strboard = strboard.Replace(guess, symbol);

                    board = strboard.ToCharArray();
                    turn++;


                }

                else
                {
                    Console.WriteLine("Player 2, enter your position choice (1-9):");
                    char guess = char.Parse(Console.ReadLine());
                    choices[i] = guess;

                    game.ValidGuess(guess, choices);

                    char symbol = 'O';

                    strboard = strboard.Replace(guess, symbol);

                    board = strboard.ToCharArray();

                    turn++;
                }
            }

        } while (play == true);
    }

    public bool ValidGuess(char guess, char[] choices)
    {
        bool result = true;
        int guessNumber = int.Parse(guess.ToString());

        if (!Char.IsNumber(guess))
        {
            Console.WriteLine("Input must be a number. Try again");
            result = false;
        }
        else if ((guessNumber) is < 1 or > 9)
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
