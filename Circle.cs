class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;

    }

    public override double Area
    {
        get { return 3.14 * Radius * Radius; }
    }

    public override double Perimeter
    {
        get { return 2 * 3.14 * Radius; }
    }

    public override string ToString()
    {
        return $"Площадь круга равна {Area}. Периметр круга равен {Perimeter}";
    }
}
