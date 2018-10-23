using System;
using ChessBoardModel;

namespace ChessBoardUI
{
    public class ChessBoardApplication
    {
        private const int ARGUMENTS_COUNT = 2;

        public int Run(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    this.ShowAbout();
                    this.ShowInstructions();
                    Console.ReadKey();
                }

                if (args.Length > 0 & args.Length < ARGUMENTS_COUNT)
                {
                    throw new ArgumentException("There are too few arguments in command line!");
                }

                if (args.Length == ARGUMENTS_COUNT)
                {
                    int width;
                    int height;
                    if (!int.TryParse(args[0], out width) || !int.TryParse(args[1], out height))
                    {
                        throw new ArgumentException("Your arguments are not a number!");
                    }

                    if (width <= 0 || height <= 0)
                    {
                        throw new ArgumentException("Your arguments can not be less or equal to zero!");
                    }

                    IBoard chessBoard = ChessBoard.Initialize(height, width);
                    ChessBoardConsoleViewer boardConsoleViewer = new ChessBoardConsoleViewer();
                    boardConsoleViewer.DisplayBoard(chessBoard);
                }

                if (args.Length > ARGUMENTS_COUNT)
                {
                    throw new ArgumentException("There are too many arguments in command line!");
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                this.ShowInstructions();
                return (int)ReturnCode.Error;
            }

            return (int)ReturnCode.Success;
        }

        /// <summary>
        /// Shows the information about the application
        /// </summary>
        private void ShowAbout()
        {
            Console.WriteLine(ChessBoard_.Properties.Resources.ReadMe);
        }

        /// <summary>
        /// Shows the instructions how to use the application
        /// </summary>
        private void ShowInstructions()
        {
            Console.WriteLine(Environment.NewLine + "Input parameters: <width of chess board> <height of chess board>");
        }
    }
}