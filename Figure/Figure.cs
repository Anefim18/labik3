using System;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    // Constructor to initialize X, Y, and Name
    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    // Constructor to create a figure with 3 to 5 points
    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    // Method to calculate the length of a side between two points
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Method to calculate the perimeter of the figure
    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }

        // Add the last side connecting the last and first points
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Figure Perimeter: {perimeter}");
    }
}

