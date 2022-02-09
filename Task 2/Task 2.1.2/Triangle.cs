namespace Task_2_1;

class Triangle : PlaneFigure
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }

    public Triangle(int cx = 0, int cy = 0, int SideA = 1, int SideB = 1, int SideC = 1)
    {
        CenterCoordinateX = cx;
        CenterCoordinateY = cy;
        this.SideA = SideA;
        this.SideB = SideB;
        this.SideC = SideC;
    }

    public double GetArea()
    {
        // Herone's method

        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public override string ToString()
    {
        return $"Треугольник: Координаты центра: {CenterCoordinateX}:{CenterCoordinateY}, Длины сторон: {SideA},{SideB},{SideC}, Площадь: {Math.Round(GetArea(),5)}";
    }

}

