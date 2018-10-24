// <copyright file="ChessBoardCellInitializer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    /// <summary>
    /// Initializes cells for chess board with black and white colors
    /// </summary>
    /// <seealso cref="ChessBoardModel.ICellInitializer" />
    public class ChessBoardCellInitializer : ICellInitializer
    {
        /// <summary>
        /// Defines if the white cell goes first on the board
        /// </summary>
        private bool isWhiteCellFirst = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChessBoardCellInitializer"/> class
        /// </summary>
        /// <param name="isWhiteCellFirst">If set to <c>true</c> [Defines if the white cell goes first]</param>
        public ChessBoardCellInitializer(bool isWhiteCellFirst = false)
        {
            this.isWhiteCellFirst = isWhiteCellFirst;
        }

        /// <summary>
        /// Initializes the specified cells with black and white colors
        /// </summary>
        /// <param name="cells">The array of cells</param>
        public void Initialize(ICell[,] cells)
        {
            if (this.isWhiteCellFirst == false)
            {
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        cells[i, j] = new ChessCell((Colors)((i + j) & 1));
                    }
                }
            }
            else
            {
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        cells[i, j] = new ChessCell((Colors)(((i + j) & 1) ^ 1));                        
                    }
                }
            }
        }
    }
}