// <copyright file="Board.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    /// <summary>
    /// Class for board with cells
    /// </summary>
    /// <seealso cref="ChessBoardModel.IBoard" />
    public class Board : IBoard
    {
        /// <summary>
        /// The array of cells
        /// </summary>
        private readonly ICell[,] cells;

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class
        /// </summary>
        /// <param name="width">The width of the board</param>
        /// <param name="height">The height of the board</param>
        /// <param name="initializer">The initializer for board cells</param>
        public Board(byte width, byte height, ICellInitializer initializer)
        {
            this.Height = height;
            this.Width = width;
            this.cells = new ICell[height, width];
            initializer.Initialize(this.cells);
        }

        /// <summary>
        /// Gets the height. of the board
        /// </summary>
        /// <value>
        /// The height
        /// </value>
        public byte Height
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the width of the board
        /// </summary>
        /// <value>
        /// The width
        /// </value>
        public byte Width
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the <see cref="ICell"/> of the board
        /// </summary>
        /// <value>
        /// The <see cref="ICell"/>
        /// </value>
        /// <param name="line">The line of the cell</param>
        /// <param name="column">The column of the cell</param>
        /// <returns>The cell of the board</returns>
        public ICell this[int line, int column]
        {
            get
            {
                return this.cells[line, column];
            }
        }        
    }
}