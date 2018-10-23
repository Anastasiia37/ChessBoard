// <copyright file="ChessСell.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    public class ChessCell : ICell
    {                
        public ChessCell(Colors colour)
        {
            this.Colour = colour;
        }

        public Colors Colour
        {
            get;
            private set;
        }
    }
}