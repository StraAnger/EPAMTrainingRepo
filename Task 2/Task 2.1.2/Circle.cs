namespace Task_2_1;

class Circle : RoundShape
{
    public double CirleLength { get => 2 * Math.PI * Radius; }
    public Circle(int cx = 0, int cy = 0, int radius = 1) : base(cx, cy, radius)
    {

    }

    public override string ToString()
    {
        return $"Окружность: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Радиус: {Radius}, Длина окружности: {Math.Round(CirleLength, 2)}";
    }

}

