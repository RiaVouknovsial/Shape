class Triangle : Shape
{
    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }


    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double Perimeter
    {
        get { return Side1 + Side2 + Side3; }
    }
    public override double Area
    {
        get { return Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - Side1) * ((Perimeter / 2) - Side2) * ((Perimeter / 2) - Side3)); }
    }
    public override string ToString()
    {
        return $"Площадь треугольника равна {Area}. Периметр тругольника равен {Perimeter}";
    }
}