// <copyright file="ICell.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardModel
{
    /// <summary>
    /// Interface for cells
    /// </summary>
    public interface ICell
    {
        /// <summary>
        /// Gets the colour from the icell
        /// </summary>
        /// <value>
        /// The colour
        /// </value>
        Colors Colour
        {
            get;
        }
    }
}