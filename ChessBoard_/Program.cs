﻿namespace ChessBoardUI
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
        /// <returns>Retrun code: 0 if success, 1 if error occured</returns>
        public static int Main(string[] args)
        {
            ChessBoardApplication myApplication = new ChessBoardApplication();
            return myApplication.Run(args);
        }
    }    
}