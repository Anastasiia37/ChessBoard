// <copyright file="ChessСell.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    /// <summary>
    /// The cell for chess board
    /// </summary>
    /// <seealso cref="ChessBoardModel.ICell" />
    public class ChessCell : ICell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChessCell"/> class
        /// </summary>
        /// <param name="colour">The colour of the cell</param>
        public ChessCell(Colors colour)
        {
            this.Colour = colour;
        }

        /// <summary>
        /// Gets the colour of the cell
        /// </summary>
        /// <value>
        /// The colour from <see cref="Colors"/>
        /// </value>
        public Colors Colour
        {
            get;
            private set;
        }
    }
}