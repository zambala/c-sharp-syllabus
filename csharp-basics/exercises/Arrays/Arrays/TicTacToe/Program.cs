using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
        }

        private static void InitBoard()
        {
            char player = 'O';

            Console.WriteLine("First player " + player);

            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

            DisplayBoard(player);
        }

        private static void DisplayBoard(char player)
        {
            Console.WriteLine("  0  " + " 1  " + "2  ");
            Console.WriteLine("     " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");

            Game(player);
        }

        private static void Game(char player)
        {
            Console.WriteLine("Hi player, " + "you need choose Row from 0-2 ");
            int inputRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose a Column from 0-2 ");
            int inputColumn = int.Parse(Console.ReadLine());

            for (int r = inputRow; r <= inputRow; r++)
            {
                for (int c = inputColumn; c <= inputColumn; c++)

                    if (board[r, c] == ' ')
                    {
                        board[r, c] = player;
                        player = player == 'X' ? 'O' : 'X';
                    }
            }

            char winner = GetWin();

            if (winner != ' ')
            {
                Console.WriteLine("  0  " + " 1  " + "2  ");
                Console.WriteLine("     " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
                Console.WriteLine("    --+-+--");
                Console.WriteLine("The winner is" + winner);
                Restart();
            }

            DisplayBoard(player);
            Draw();
        }

        private static char GetWin()
        {
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
            {
                return board[0, 0];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
            {
                return board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
            {
                return board[2, 0];
            }
            else if (board[2, 2] == board[1, 1] && board[2, 2] == board[0, 0])
            {
                return board[2, 2];
            }
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                return board[0, 2];
            }
            else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
            {
                return board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
            {
                return board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
            {
                return board[0, 2];
            }
            return ' ';
        }

        private static void Draw()
        {
            int move = 0;

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] == 'X' || board[r, c] == 'O')
                        move++;

                    if (move == 9)
                    {
                        Console.WriteLine("  0  " + " 1  " + "2  ");
                        Console.WriteLine("     " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
                        Console.WriteLine("    --+-+--");
                        Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
                        Console.WriteLine("    --+-+--");
                        Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
                        Console.WriteLine("    --+-+--");

                        Console.WriteLine("The game is over and it's a draw");
                        Restart();
                    }
                }
            }
        }

        private static void Restart()
        {
            Console.Write("Wanna play again? yes/no : ");
            string answer = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "yes":
                    Console.Clear();
                    InitBoard();
                    break;
                case "no":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Try again");
                    Restart();
                    break;
            }
        }
    }
}
