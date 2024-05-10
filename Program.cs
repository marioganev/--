using System;

public abstract class ColoredFigure
{
    protected string color;
    protected double size;

    protected ColoredFigure(string color, double size)
    {
        this.color = color;
        this.size = size;
    }

    public void Show()
    {
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Size: {size}");
    }

    public abstract double GetArea();
    public abstract string GetName();
}

public class Triangle : ColoredFigure
{
    public Triangle(string color, double size) : base(color, size) { }

    public override double GetArea()
    {
        return (Math.Pow(size, 2.0) * Math.Sqrt(3)) / 4.0;
    }

    public override string GetName()
    {
        return "Triangle";
    }
}

public class Square : ColoredFigure
{
    public Square(string color, double size) : base(color, size) { }

    public override double GetArea()
    {
        return Math.Pow(size, 2.0);
    }

    public override string GetName()
    {
        return "Square";
    }
}

public class Circle : ColoredFigure
{
    public Circle(string color, double size) : base(color, size) { }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(size, 2.0);
    }

    public override string GetName()
    {
        return "Circle";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var cmd = Console.ReadLine().Split();
            switch (cmd[0])
            {
                case "Circle":
                    {
                        Circle circle = new Circle(cmd[1], double.Parse(cmd[2]));
                        Console.WriteLine($"Name: {circle.GetName()}");
                        circle.Show();
                        Console.WriteLine($"Area: {circle.GetArea():f2}");
                        break;
                    }
                case "Square":
                    {
                        Square square = new Square(cmd[1], double.Parse(cmd[2]));
                        Console.WriteLine($"Name: {square.GetName()}");
                        square.Show();
                        Console.WriteLine($"Area: {square.GetArea():f2}");
                        break;
                    }
                case "Triangle":
                    {
                        Triangle triangle = new Triangle(cmd[1], double.Parse(cmd[2]));
                        Console.WriteLine($"Name: {triangle.GetName()}");
                        triangle.Show();
                        Console.WriteLine($"Area: {triangle.GetArea():f2}");
                        break;
                    }
            }
        }
    }
}
