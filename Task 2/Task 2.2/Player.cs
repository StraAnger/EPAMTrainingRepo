namespace Task_2_1;

public class Player : Character
{
    // Player character in Game

    public string PlayerName { get; set; }

    public Player(int CoordinateX = 5, int CoordinateY = 5)
    {
        Health = 100;
        Force = 50;
        PlayerName = "Mike Oldman";
        this.CoordinateX = CoordinateX;
        this.CoordinateY = CoordinateY;
    }

}




