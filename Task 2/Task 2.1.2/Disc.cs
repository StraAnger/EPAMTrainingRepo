namespace Task_2_1;

class Disc : RoundShape
{
    public double CirleLength { get => 2 * Math.PI * Radius; }
    public double GetArea() => Math.PI * Math.Pow(Radius, 2);

    public Disc(int cx = 0, int cy = 0, int radius = 1) : base(cx, cy, radius)
    {

    }

    public override string ToString()
    {
        return $"Круг: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Радиус: {Radius}, Длина окружности: {Math.Round(CirleLength,2)}, Площадь: {Math.Round(GetArea(),2)}";
    }

}

