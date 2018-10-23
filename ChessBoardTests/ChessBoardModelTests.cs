// <copyright file="ChessBoardModelTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;
using ChessBoardModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftAssert;

namespace ChessBoardTests
{
    [TestClass]
    public class ChessBoardModelTests
    {    
        [TestMethod]
        public void ChessBoard_InitializeTest_CorrectInput_ReturnNewChessBoardWithCorrectProperties()
        {
            // Arrange
            byte height = 5;
            byte width = 10;

            // Act
            ICellInitializer initializer = new ChessBoardCellInitializer();

            Board chessBoard = new Board(width, height, initializer);

            // Assert
            AssertAll.Succeed(
            () => Assert.IsNotNull(chessBoard),
            () => Assert.IsInstanceOfType(chessBoard, typeof(IBoard)),
            () => Assert.AreEqual(height, chessBoard.Height),
            () => Assert.AreEqual(width, chessBoard.Width)            
                );
        }



        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ChessBoard_InitializeTest_TestForIncorrectIndex_ExpectedIndexOutOfRangeException()
        {
            // Arrange
            byte width = 10;
            byte height = 5;
            int xPosition = 9;
            int yPosition = 6;

            // Act
            ICellInitializer initializer = new ChessBoardCellInitializer();
            Board chessBoard = new Board(width, height, initializer);

            // Assert
            Assert.AreEqual(Colors.White, chessBoard[xPosition, yPosition].Colour);
        }


        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(0, 2)]
        public void ChessBoard_InitializeTest_IncorrectInput_ExpectedArgumentException(
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