namespace Task_2_1;

public class Enemy : Character
{
    // Enemy character in Game
    public string EnemyName { get; set; }

    public Enemy(int CoordinateX = 7, int CoordinateY = 7)
    {
        Health = 100;
        Force = 20;
        EnemyName = "Gosha";
        this.CoordinateX = CoordinateX;
        this.CoordinateY = CoordinateY;
    }
}




