using System;
using System.Collections.Generic;

namespace ChessBoardModel
{
    public class ChessBoardConsoleViewer
    {
        public Dictionary<Colors, char> colour 
        {
            get;
        }

        public ChessBoardConsoleViewer()
        {
            this.colour = new Dictionary<Colors, char>(2)
            {
                { Colors.Black, '*'},
                { Colors.White, ' '}
            };
        }
  

        public void DisplayBoard(IBoard chessBoard)
        {
            if (chessBoard.Width > 80)
            {
                throw new ArgumentException("Widht of the board can`t be more than 80!");
            }

            for (int i = 0; i < chessBoard.Height; i++)
            {
                for (int j = 0; j < chessBoard.Width; j++)
                {                    
                    Console.WriteLine(colour[chessBoard[i, j].Colour]);
                }
                Console.WriteLine();
            }
        }
    }
}