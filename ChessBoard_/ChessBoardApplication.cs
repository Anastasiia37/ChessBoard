﻿// <copyright file="ChessBoardApplication.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using ChessBoardModel;

namespace ChessBoardUI
{
    /// <summary>
    /// Application for using chessboard
    /// </summary>
    public class ChessBoardApplication
    {
        /// <summary>
        /// Runs the application
        /// </summary>
        /// <param name="args">The arguments from command lines</param>
        /// <returns>Return code: 0 if success, 1 if error occurred</returns>
        public int Run(string[] args)
        {
            try
            {
                byte width;
                byte height;
                bool isWhiteCellFirst;
                Parser.Parse(args, out width, out height, out isWhiteCellFirst);
                ICellInitializer initializer = new ChessBoardCellInitializer(isWhiteCellFirst);
                IBoard chessBoard = new Board(height, width, initializer);
                ChessBoardConsoleViewer boardConsoleViewer = new ChessBoardConsoleViewer();
                boardConsoleViewer.DisplayBoard(chessBoard);
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
        /// Shows the instructions how to use the application
        /// </summary>
        private void ShowInstructions()
        {
            Console.WriteLine(Environment.NewLine 
                + "Input parameters: <width of chess board> <height of chess board>");
        }
    }
}