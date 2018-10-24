// <copyright file="ChessCellTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoardModel.Tests
{
    /// <summary>
    /// tests the ChessCell class
    /// </summary>
    [TestClass]
    public class ChessCellTests
    {
        /// <summary>
        /// Tests the cell initialization
        /// </summary>
        [TestMethod]
        public void CellInitializationTest()
        {
            //Arrange
            Colors expectedColour = Colors.Black;
            ICell actualCell;

            // Act
            actualCell = new ChessCell(Colors.Black);

            //Assert
            Assert.AreEqual(expectedColour, actualCell.Colour);
        }
    }
}