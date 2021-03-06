﻿// <copyright file="ChessBoardCellInitializerTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoardModel.Tests
{
    /// <summary>
    /// Tests the ChessBoardCellInitializer class
    /// </summary>
    [TestClass]
    public class ChessBoardCellInitializerTests
    {
        /// <summary>
        /// Tests the Initialize method for correct input
        /// Expected einitialized cells with correct colors, black colour goes first 
        /// </summary>
        [TestMethod]
        public void InitializeTest_CorrectInputBlackFirst_ReturnedInitializedCellsWithCorrectColors()
        {
            // Arrange
            int width = 2;
            int height = 3;
            ICell[,] expectedCells = 
            {
                {new ChessCell(Colors.Black),  new ChessCell(Colors.White), new ChessCell(Colors.Black)},
                {new ChessCell(Colors.White),  new ChessCell(Colors.Black), new ChessCell(Colors.White)},
                {new ChessCell(Colors.Black),  new ChessCell(Colors.White), new ChessCell(Colors.Black)},
            };
            ICell[,] actualCells = new ChessCell[width, height];

            // Act
            ICellInitializer initializer = new ChessBoardCellInitializer();
            initializer.Initialize(actualCells);

            // Assert
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Assert.AreEqual(expectedCells[i, j].Colour, actualCells[i, j].Colour);
                }
            }
        }

        /// <summary>
        /// Tests the Initialize method for correct input
        /// Expected einitialized cells with correct colors, white colour goes first 
        /// </summary>        [TestMethod()]
        public void InitializeTest_CorrectInputWhiteFirst_ReturnedInitializedCellsWithCorrectColors()
        {
            // Arrange
            int width = 2;
            int height = 3;
            ICell[,] expectedCells =
            {
                {new ChessCell(Colors.White),  new ChessCell(Colors.Black), new ChessCell(Colors.White)},
                {new ChessCell(Colors.Black),  new ChessCell(Colors.White), new ChessCell(Colors.Black)},
                {new ChessCell(Colors.White),  new ChessCell(Colors.Black), new ChessCell(Colors.White)},
            };
            ICell[,] actualCells = new ChessCell[width, height];

            // Act
            ICellInitializer initializer = new ChessBoardCellInitializer(true);
            initializer.Initialize(actualCells);

            // Assert
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Assert.AreEqual(expectedCells[i, j].Colour, actualCells[i, j].Colour);
                }
            }
        }
    }
}