namespace Task_2_1;

class Rectangle : PlaneFigure
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectangle(int cx = 0, int cy = 0, int Height = 1, int Width = 1)
    {
        CenterCoordinateX = cx;
        CenterCoordinateY = cy;
        this.Height = Height;
        this.Width = Width;
    }

    public double GetArea() => Height * Width;

    public override string ToString()
    {
        return $"Прямоугольник: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Ширина: {Height}, Высота: {Height}, Площадь: {Math.Round(GetArea(), 2)}";
    }
}

