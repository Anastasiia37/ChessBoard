// <copyright file="Parser.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

using System;

namespace ChessBoardUI
{
    /// <summary>
    /// Parses arguments of command line
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// The board size
        /// </summary>
        public const int MAXIMUM_BOARD_SIZE = 79;

        /// <summary>
        /// The no arguments in command line
        /// </summary>
        private const int NO_ARGUMENTS = 0;

        /// <summary>
        /// The minimum valid count of arguments in command line
        /// </summary>
        private const int ARGUMENTS_MIN_COUNT = 2;

        /// <summary>
        /// The maximum valid count of arguments in command line
        /// </summary>
        private const int ARGUMENTS_MAX_COUNT = 3;

        /// <summary>
        /// Parses the specified arguments
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <param name="width">The width of the board</param>
        /// <param name="height">The height of the board</param>
        /// <param name="isWhiteCellFirst">Set to <c>true</c> [if the white cell displays first]</param>
        /// <exception cref="ArgumentException">
        /// There are too few arguments in command line!
        /// or
        /// There are too many arguments in command line!
        /// </exception>
        public static void Parse(string[] args, out byte width, out byte height, out bool isWhiteCellFirst)
        {
            width = 0;
            height = 0;
            isWhiteCellFirst = false;

            if (args.Length == NO_ARGUMENTS)
            {
                Console.WriteLine(ChessBoard_.Properties.Resources.ReadMe);
                Console.ReadKey();
            }

            if (args.Length > NO_ARGUMENTS & args.Length < ARGUMENTS_MIN_COUNT)
            {
                throw new ArgumentException("There are too few arguments in command line!");
            }

            if (args.Length == ARGUMENTS_MIN_COUNT)
            {
                Parser.ParseWidthHeight(args, out width, out height);
                isWhiteCellFirst = false;
            }

            if (args.Length == ARGUMENTS_MAX_COUNT)
            {
                Parser.ParseWidthHeight(args, out width, out height);
                Parser.ParseIsWhiteCellFirst(args, out isWhiteCellFirst);
            }

            if (args.Length > ARGUMENTS_MAX_COUNT)
            {
                throw new ArgumentException("There are too many arguments in command line!");
            }
        }

        /// <summary>
        /// Parses the is the white cell first
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <param name="isWhiteCellFirst">Set to <c>true</c> [if the white cell displays first]</param>
        /// <exception cref="ArgumentException">Can't recognize last parameter!</exception>
        private static void ParseIsWhiteCellFirst(string[] args, out bool isWhiteCellFirst)
        {
            if (!bool.TryParse(args[2], out isWhiteCellFirst))
            {
                throw new ArgumentException("Can't recognize last parameter!");
            }
        }

        /// <summary>
        /// Parses the height and the width. of the board
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <param name="width">The width of the board</param>
        /// <param name="height">The height of the board</param>
        /// <exception cref="ArgumentException">
        /// Your arguments are not a number or is a very big number!
        /// or
        /// Can`t display such a big board!
        /// or
        /// Your arguments can not be less or equal to zero!
        /// </exception>
        private static void ParseWidthHeight(string[] args, out byte width, out byte height)
        {
            int intWidth;
            int intHeight;
            if (!int.TryParse(args[0], out intWidth) || !int.TryParse(args[1], out intHeight))
            {
                throw new ArgumentException("Your arguments are not a number or is a very big number!");
            }

            if (intWidth > MAXIMUM_BOARD_SIZE || intHeight > MAXIMUM_BOARD_SIZE)
            {
                throw new ArgumentException("Can`t display such a big board!");
            }

            if (intWidth <= 0 || intHeight <= 0)
            {
                throw new ArgumentException("Your arguments can not be less or equal to zero!");
            }

            width = (byte)intWidth;
            height = (byte)intHeight;
        }
    }
}