namespace Task_2_1;

class RoundShape : PlaneFigure
{
    public int Radius { get; set; }

    public RoundShape() : this(0, 0, 1)
    {

    }

    public RoundShape(int cx, int cy, int radius)
    {
        CenterCoordinateX = cx;
        CenterCoordinateY = cy;
        Radius = radius;
    }

}

