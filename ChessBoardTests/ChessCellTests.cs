// <copyright file="ChessCellTests.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using ChessBoardModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoardTests
{
    /// <summary>
    /// Summary description for ChessCellTest
    /// </summary>
    [TestClass]
    public class ChessCellTests
    {
        [TestMethod]
        public void Cell_CellInitialization()
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
