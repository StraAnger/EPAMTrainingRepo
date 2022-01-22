namespace Task_2_1;

class Ring : RoundShape
{
    public int InnerCircleRadius { get; set; }

    public Ring(int cx = 0, int cy = 0, int radius = 2, int innerCircleRadius = 1)
    {
        CenterCoordinateX = cx;
        CenterCoordinateY = cy;
        if (radius > InnerCircleRadius)
        {
            this.Radius = radius;
            this.InnerCircleRadius = innerCircleRadius;
        }
    }

    public double GetArea() => Math.PI * (Math.Pow(Radius, 2) - Math.Pow(InnerCircleRadius, 2));

    public double GetSumInnerOuterCirleLength() => 2 * Math.PI * (Radius + InnerCircleRadius);

    public double GetWidth() => Radius - InnerCircleRadius;

    public override string ToString()
    {
        return $"Кольцо: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Внешний радиус: {Radius}, Внутренний радиус: {InnerCircleRadius}";
    }
}

