namespace Task_2_1;

class Circle : RoundShape
{

    public Circle(int cx = 0, int cy = 0, int radius = 1) : base(cx, cy, radius)
    {

    }
    public double GetCirleLength() => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"Окружность: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Радиус: {Radius}, Длина окружности: {Math.Round(GetCirleLength(),2)}";
    }

}

