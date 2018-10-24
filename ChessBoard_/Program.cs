// <copyright file="Program.cs" company="Peretiatko Anastasiia">
// Copyright (c) Peretiatko Anastasiia. All rights reserved.
// </copyright>

namespace ChessBoardUI
{   
    /// <summary>
    /// Contains the Main function from where the program starts its execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main function from where the program starts its execution
        /// </summary>
        /// <param name="args">The arguments from command line</param>
        /// <returns>Return code: 0 if success, 1 if error occurred</returns>
        public static int Main(string[] args)
        {
            ChessBoardApplication myApplication = new ChessBoardApplication();
            return myApplication.Run(args);
        }
    }    
}