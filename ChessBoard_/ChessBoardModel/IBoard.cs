namespace ChessBoardModel
{
    public interface IBoard
    {
        int Height
        {
            get;
        }

        int Width
        {
            get;
        }       

        ICell this[int i, int j]
        {
            get;
        }
    }
}