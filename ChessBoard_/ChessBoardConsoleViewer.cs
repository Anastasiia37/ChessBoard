// <copyright file="ChessBoardConsoleViewer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using ChessBoardModel;

namespace ChessBoardUI
{
    public class ChessBoardConsoleViewer
    {
        public const int BOARD_SIZE = 79;

        public const int COLOUR_NUMBERS = 2;

        public ChessBoardConsoleViewer()
        {
            this.Colour = new Dictionary<Colors, char>(COLOUR_NUMBERS)
            {
                { Colors.Black, '*' },
                { Colors.White, ' ' }
            };
        }

        public Dictionary<Colors, char> Colour 
        {
            get;
        }

        public void DisplayBoard(IBoard chessBoard)
        {
            if (chessBoard.Width > BOARD_SIZE)
            {
                throw new ArgumentException("Can`t display the board on the console!"
                    + $"Widht of the board can`t be more than {BOARD_SIZE}!");
            }

            for (int i = 0; i < chessBoard.Height; i++)
            {
                for (int j = 0; j < chessBoard.Width; j++)
                {                    
                    Console.Write(this.Colour[chessBoard[i, j].Colour]);
                }

                Console.WriteLine();
            }
        }
    }
}