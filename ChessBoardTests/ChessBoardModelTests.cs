using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftAssert;
using ChessBoardModel;

namespace ChessBoardTests
{
    [TestClass]
    public class ChessBoardModelTests
    {
        [TestMethod]
        public void Cell_CellInitialization()
        {
            //Arrange
            Colors expectedColour = Colors.Black;
            ICell actualCell;
            
            // Act
            actualCell = new Cell(Colors.Black);

            //Assert
            Assert.AreEqual(expectedColour, actualCell.Colour);
        }

        [TestMethod()]
        public void ChessBoard_InitializeTest_CorrectInput_ReturnNewChessBoardWithCorrectProperties()
        {
            // Arrange
            int height = 5;
            int width = 10;            

            // Act
            ChessBoard chessBoard = ChessBoard.Initialize(width, height);

            // Assert
            AssertAll.Succeed(
            () => Assert.IsNotNull(chessBoard),
            () => Assert.IsInstanceOfType(chessBoard, typeof(IBoard)),
            () => Assert.AreEqual(height, chessBoard.Height),
            () => Assert.AreEqual(width, chessBoard.Width)            
                );
        }

        [DataTestMethod()]
        [DataRow(0, 0, Colors.Black)]
        [DataRow(0, 1, Colors.White)]
        [DataRow(1, 0, Colors.White)]
        [DataRow(4, 9, Colors.White)]
        public void ChessBoard_InitializeTest_TestForCorrectColour(int xPosition, int yPosition,
            Colors expectedColour)
        {
            // Arrange
            int height = 5;
            int width = 10;

            // Act
            ChessBoard chessBoard = ChessBoard.Initialize(width, height);

            // Assert
            Assert.AreEqual(expectedColour, chessBoard[xPosition, yPosition].Colour);
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ChessBoard_InitializeTest_TestForIncorrectIndex_ExpectedIndexOutOfRangeException()
        {
            // Arrange
            int width = 10;
            int height = 5;
            int xPosition = 9;
            int yPosition = 6;

            // Act
            ChessBoard chessBoard = ChessBoard.Initialize(width, height);

            // Assert
            Assert.AreEqual(Colors.White, chessBoard[xPosition, yPosition].Colour);
        }


        [DataTestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(5, -2)]
        [DataRow(0, 2)]
        public void ChessBoard_InitializeTest_IncorrectInput_ExpectedArgumentException(
            int width, int height)
        {
            // Arrange
            ChessBoard chessBoard;

            // Act
            chessBoard = ChessBoard.Initialize(width, height);

            // Assert
            AssertAll.Succeed(
            () => Assert.IsNotNull(chessBoard),
            () => Assert.IsInstanceOfType(chessBoard, typeof(IBoard)),
            () => Assert.AreEqual(height, chessBoard.Height),
            () => Assert.AreEqual(width, chessBoard.Width),
            () => Assert.AreEqual(Colors.Black, chessBoard[0, 0].Colour),
            () => Assert.AreEqual(Colors.White, chessBoard[0, 1].Colour)
                );

        }

        [DataTestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ChessBoardConsoleViewer_DisplayBoardTest_ExpectedArgumentException()
        {
            // Arrange
            int height = 5;
            int width = 81;

            // Act
            ChessBoard chessBoard = ChessBoard.Initialize(width, height);
            ChessBoardConsoleViewer consoleViewer = new ChessBoardConsoleViewer();
            consoleViewer.DisplayBoard(chessBoard);
        }
    }
}
