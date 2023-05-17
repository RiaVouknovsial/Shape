class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area
    {
        get { return Width * Height; }
    }

    public override double Perimeter
    {
        get { return 2 * (Width + Height); }
    }

    public override string ToString()
    {
        return $"Площадь прямоугольника равна {Area}. Периметр прямоугольника равен {Perimeter}";
    }
}