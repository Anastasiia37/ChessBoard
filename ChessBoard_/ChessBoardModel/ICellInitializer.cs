// <copyright file="ICellInitializer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    public interface ICellInitializer
    {
        void Initialize(ICell[,] cells);
    }
}