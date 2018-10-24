// <copyright file="ChessBoardConsoleViewer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using ChessBoardModel;

namespace ChessBoardUI
{
    /// <summary>
    /// Display the board on console
    /// </summary>
    public class ChessBoardConsoleViewer
    {
        /// <summary>
        /// The maximum board size
        /// </summary>
        public const int MAXIMUM_BOARD_SIZE = 79;

        /// <summary>
        /// The number of colors on the board
        /// </summary>
        public const int COLOUR_NUMBERS = 2;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChessBoardConsoleViewer"/> class
        /// </summary>
        public ChessBoardConsoleViewer()
        {
            this.Colour = new Dictionary<Colors, char>(COLOUR_NUMBERS)
            {
                { Colors.Black, '*' },
                { Colors.White, ' ' }
            };
        }

        /// <summary>
        /// Gets the symbol that corresponds to specified colour
        /// </summary>
        /// <value>
        /// The colour and the char for this colour
        /// </value>
        public Dictionary<Colors, char> Colour 
        {
            get;
        }

        /// <summary>
        /// Displays the board on the console
        /// </summary>
        /// <param name="chessBoard">The chess board for displaying</param>
        /// <exception cref="ArgumentException">Can`t display the board on the console!
        /// "Width of the board can`t be more than {MAXIMUM_BOARD_SIZE}</exception>
        public void DisplayBoard(IBoard chessBoard)
        {
            if (chessBoard.Width > MAXIMUM_BOARD_SIZE)
            {
                throw new ArgumentException("Can`t display the board on the console!"
                    + $"Widht of the board can`t be more than {MAXIMUM_BOARD_SIZE}!");
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