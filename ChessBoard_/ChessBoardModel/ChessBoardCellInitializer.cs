// <copyright file="ChessBoardCellInitializer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    public class ChessBoardCellInitializer : ICellInitializer
    {
        private bool isWhiteCellFirst = false;

        public ChessBoardCellInitializer(bool isWhiteCellFirst = false)
        {
            this.isWhiteCellFirst = isWhiteCellFirst;
        }

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