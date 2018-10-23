using System;

namespace ChessBoardModel
{
    public class ChessBoard : IBoard
    {
        public int Height
        {
            get;
            private set;
        }

        public int Width
        {
            get;
            private set;
        }
       
        private readonly ICell[,] cells;

        public ICell this[int i, int j]
        {
            get
            {
                return cells[i, j];
            }
        }

        private ChessBoard(int width, int height)
        {
            this.Height = height;
            this.Width = width;
            cells = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (((i + j) & 1) == 0)
                    {
                        cells[i, j] = new Cell(Colors.Black);
                    }
                    else
                    {
                        cells[i, j] = new Cell(Colors.White);
                    }
                }
            }
        }

        public static ChessBoard Initialize(int height, int width)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height of the board can`t be less or equal zero!");
            }

            if (width <= 0)
            {
                throw new ArgumentException("Widht of the board can`t be less or equal zero!");
            }


            return new ChessBoard(height, width);
        }
    }
}
