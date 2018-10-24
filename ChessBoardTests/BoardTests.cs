// <copyright file="ChessBoardModelTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftAssert;

namespace ChessBoardModel.Tests
{
    /// <summary>
    /// Tests the Board class
    /// </summary>
    [TestClass]
    public class BoardTests
    {
        /// <summary>
        /// Tests the Initialize method for correct input
        /// Expected new instance of Board with correct properties
        /// </summary>
        [TestMethod]
        public void Board_InitializeTest_CorrectInput_ReturnNewChessBoardWithCorrectProperties()
        {
            // Arrange
            byte height = 5;
            byte width = 10;
            ICellInitializer initializer = new ChessBoardCellInitializer();

            // Act
            Board chessBoard = new Board(width, height, initializer);

            // Assert
            AssertAll.Succeed(
            () => Assert.IsNotNull(chessBoard),
            () => Assert.IsInstanceOfType(chessBoard, typeof(IBoard)),
            () => Assert.AreEqual(height, chessBoard.Height),
            () => Assert.AreEqual(width, chessBoard.Width)            
                );
        }

        /// <summary>
        /// Tests the Indexer for incorrect indexes
        /// Expected IndexOutOfRangeException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Board_IndexerTest_TestForIncorrectIndex_ExpectedIndexOutOfRangeException()
        {
            // Arrange
            byte width = 10;
            byte height = 5;
            int line = 9;
            int column = 6;
            Colors expectedColour = Colors.White;
            ICellInitializer initializer = new ChessBoardCellInitializer();
            Board chessBoard = new Board(width, height, initializer);

            // Act
            Colors actualColour = chessBoard[line, column].Colour;

            // Assert
            Assert.AreEqual(expectedColour, actualColour);
        }
        
        /// <summary>
        /// Tests the Initialize method for zero incorrect input, expected argument exception
        /// </summary>
        /// <param name="width">The width</param>
        /// <param name="height">The height</param>
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(0, 2)]
        [DataRow(2, 0)]
        public void Board_InitializeTest_IncorrectInput_ExpectedArgumentException(
            byte width, byte height)
        {
            // Arrange
            Board chessBoard;

            // Act
            ICellInitializer initializer = new ChessBoardCellInitializer();
            chessBoard = new Board(width, height, initializer);

            // Assert
            AssertAll.Succeed(
            () => Assert.IsNotNull(chessBoard),
            () => Assert.IsInstanceOfType(chessBoard, typeof(IBoard)),
            () => Assert.AreEqual(height, chessBoard.Height),
            () => Assert.AreEqual(width, chessBoard.Width)
                );
        }
    }
}