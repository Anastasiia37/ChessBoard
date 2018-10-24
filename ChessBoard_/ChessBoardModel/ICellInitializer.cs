// <copyright file="ICellInitializer.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    /// <summary>
    /// Interface for ICellInitializer
    /// </summary>
    public interface ICellInitializer
    {
        /// <summary>
        /// Initializes the specified cells with defined colors
        /// </summary>
        /// <param name="cells">The cells</param>
        void Initialize(ICell[,] cells);
    }
}