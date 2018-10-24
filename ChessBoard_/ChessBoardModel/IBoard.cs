// <copyright file="IBoard.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    /// <summary>
    /// Defines the interface for boards
    /// </summary>
    public interface IBoard
    {
        /// <summary>
        /// Gets the height of the board
        /// </summary>
        /// <value>
        /// The height
        /// </value>
        byte Height
        {
            get;
        }

        /// <summary>
        /// Gets the width of the board
        /// </summary>
        /// <value>
        /// The width
        /// </value>
        byte Width
        {
            get;
        }

        /// <summary>
        /// Gets the <see cref="ICell"/> with the specified i
        /// </summary>
        /// <value>
        /// The <see cref="ICell"/>
        /// </value>
        /// <param name="line">The line of the cell</param>
        /// <param name="column">The column of the cell</param>
        /// <returns>The cell of the board</returns>
        ICell this[int line, int column]
        {
            get;
        }
    }
}