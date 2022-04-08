namespace Task_2_1;

class Line : PlaneFigure
{
    public int StartCoordinateX { get; set; }
    public int StartCoordinateY { get; set; }
    public int EndCoordinateX { get; set; }
    public int EndCoordinateY { get; set; }


    public Line(int cx = 0, int cy = 0, int x1 = 1, int y1 = 1, int x2 = 1, int y2 = 1)
    {
        CenterCoordinateX = cx;
        CenterCoordinateY = cy;
        StartCoordinateX = x1;
        StartCoordinateY = y1;
        EndCoordinateX = x2;
        EndCoordinateY = y2;

    }

    public double GetLength()
    {
        if (StartCoordinateX == EndCoordinateX)
        {
            return Math.Abs(EndCoordinateY - StartCoordinateY);
        }
        else if (StartCoordinateY == EndCoordinateY)
        {
            return Math.Abs(EndCoordinateX - StartCoordinateX);
        }
        else
        {
            return Math.Sqrt(Math.Pow(EndCoordinateY - StartCoordinateY, 2) + Math.Pow(EndCoordinateX - StartCoordinateX, 2));
        }
    }
    public override string ToString()
    {
        return $"Линия: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Точка начала ({StartCoordinateX},{StartCoordinateY}), Точка конца ({EndCoordinateX},{EndCoordinateY}), Длина: {Math.Round(GetLength(),2)}";
    }
}

