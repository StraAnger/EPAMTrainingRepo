namespace Task_2_1;

class Square : PlaneFigure
{
    public int SideLength { get; set; }

    public Square(int cx = 0, int cy = 0, int SideLength = 1)
    {
        CenterCoordinateX = cx;
        CenterCoordinateY = cy;
        this.SideLength = SideLength;
    }

    public double GetArea() => Math.Pow(SideLength, 2);

    public override string ToString()
    {
        return $"Квадрат: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Длина стороны: {SideLength}, Площадь: {Math.Round(GetArea(), 2)}";
    }
}

