// <copyright file="IBoard.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    public interface IBoard
    {
        byte Height
        {
            get;
        }

        byte Width
        {
            get;
        }       

        ICell this[int i, int j]
        {
            get;
        }
    }
}