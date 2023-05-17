//Создайте абстрактный класс "Фигура" (Shape) со следующими свойствами:

//Абстрактное свойство "Площадь" (Area) типа double (только для чтения).
//Абстрактное свойство "Периметр" (Perimeter) типа double (только для чтения).
//От абстрактного класса "Фигура" унаследуйте классы "Прямоугольник" (Rectangle) и "Круг" (Circle).

//В классе "Прямоугольник" добавьте следующие поля и методы:
//Поля "Ширина" (Width) и "Высота" (Height) типа double.
//Переопределенные свойства "Площадь" и "Периметр" для расчета значений на основе полей "Ширина" и "Высота".
//Метод "ToString()" для вывода информации о прямоугольнике в виде строки.

//В классе "Круг" добавьте следующие поля и методы:
//Поле "Радиус" (Radius) типа double.
//Переопределенные свойства "Площадь" и "Периметр" для расчета значений на основе поля "Радиуса".
//Метод "ToString()" для вывода информации о круге в виде строки.

//Создайте класс "Треугольник" (Triangle), который также наследует класс "Фигура" и
//имеет поля и методы аналогичные классам "Прямоугольник" и "Круг", с учетом особенностей треугольников.

//В основной программе создайте массив объектов типа "Фигура" и заполните его экземплярами
//классов "Прямоугольник", "Круг" и "Треугольник".

//Напишите метод "PrintShapesInfo", который принимает массив объектов типа "Фигура" и
//выводит информацию о каждой фигуре, используя метод "ToString()".

//В основной программе вызовите метод "PrintShapesInfo" и передайте ему массив объектов.

using System;

Shape rectangle = new Rectangle(3, 5);
Console.WriteLine(rectangle.ToString());

Shape circle = new Circle(5);
Console.WriteLine(circle.ToString());

Shape triangle = new Triangle(3.5, 5.2, 6.1);
Console.WriteLine(triangle.ToString());
Console.WriteLine();

Shape[] shapes = new Shape[3];

shapes[0] = new Rectangle(4, 6);
shapes[1] = new Circle(7);
shapes[2] = new Triangle(4.5, 6.2, 5.7);

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.ToString());
}
Console.WriteLine();
PrintShapesInfo(shapes);
Console.WriteLine();

static void PrintShapesInfo(Shape[] shapes)
{
    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape.ToString());
    }
}
Console.WriteLine();

//abstract class Shape
//{
//    public abstract double Area { get; }
//    public abstract double Perimeter { get; }
//}

//class Rectangle : Shape
//{
//    public double Width { get; }
//    public double Height { get; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override double Area
//    {
//        get { return Width * Height; }
//    }

//    public override double Perimeter
//    {
//        get { return 2 * (Width + Height); }
//    }

//    public override string ToString()
//    {
//        return $"Площадь прямоугольника равна {Area}. Периметр прямоугольника равен {Perimeter}";
//    }
//}
//class Circle : Shape
//{
//    public double Radius { get; }
    
//    public Circle(double radius)
//    {
//        Radius = radius;
       
//    }

//    public override double Area
//    {
//        get { return 3.14 * Radius * Radius; }
//    }

//    public override double Perimeter
//    {
//        get { return 2 * 3.14 * Radius; }
//    }

//    public override string ToString()
//    {
//        return $"Площадь круга равна {Area}. Периметр круга равен {Perimeter}";
//    }
//}

//class Triangle : Shape
//{
//    public double Side1 { get; }
//    public double Side2 { get; }
//    public double Side3 { get; }


//    public Triangle(double side1, double side2, double side3)
//    {
//       Side1 = side1;
//       Side2 = side2;
//       Side3 = side3;
//    }

//    public override double Perimeter
//    {
//        get { return Side1 + Side2 + Side3; }
//    }
//    public override double Area
//    {
//        get { return Math.Sqrt((Perimeter/2) * ((Perimeter / 2) - Side1) * ((Perimeter / 2) - Side2) * ((Perimeter / 2) - Side3)); }
//    }
//       public override string ToString()
//    {
//        return $"Площадь треугольника равна {Area}. Периметр тругольника равен {Perimeter}";
//    }
//}