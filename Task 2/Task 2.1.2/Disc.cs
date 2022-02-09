namespace Task_2_1;

class Disc : RoundShape
{
    public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    public double GetCirleLength() => 2 * Math.PI * Radius;

    public Disc(int cx = 0, int cy = 0, int radius = 1) : base(cx, cy, radius)
    {

    }

    public override string ToString()
    {
        return $"Круг: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Радиус: {Radius}, Длина окружности: {Math.Round(GetCirleLength(),2)}, Площадь: {Math.Round(GetArea(),2)}";
    }

}

