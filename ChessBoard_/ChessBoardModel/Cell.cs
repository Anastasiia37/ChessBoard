namespace ChessBoardModel
{
    public class Cell : ICell
    {
        
        public Colors Colour
        {
            get;
            private set;
        }
        
        public Cell(Colors colour)
        {
            this.Colour = colour;
        }
    }
}
