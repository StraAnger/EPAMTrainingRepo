namespace Task_2_1;

public class GameField
{
    // Properties

    public int Height { get; set; }
    public int Width { get; set; }

    public char[,] GameFieldMatrix { get; set; }

    // Constructors

    public GameField(int height, int width)
    {
        this.Height = height;
        this.Width = width;

        GameFieldMatrix = new char[Height, Width];

    }

    public GameField(char[,] inputGameFieldMatrix)
    {
        GameFieldMatrix = inputGameFieldMatrix;
    }

}




