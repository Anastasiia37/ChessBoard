// <copyright file="Board.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    public class Board : IBoard
    {
        private readonly ICell[,] cells;

        public Board(byte width, byte height, ICellInitializer initializer)
        {
            this.Height = height;
            this.Width = width;
            this.cells = new ICell[height, width];
            initializer.Initialize(this.cells);
        }

        public byte Height
        {
            get;
            private set;
        }

        public byte Width
        {
            get;
            private set;
        }
       
        public ICell this[int i, int j]
        {
            get
            {
                return this.cells[i, j];
            }
        }        
    }
}