using System;

class Rectangle
{
    private double side1;
    private double side2;

    // Constructor to initialize side1 and side2
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Method to calculate the perimeter of the rectangle
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Property to get the area of the rectangle
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Property to get the perimeter of the rectangle
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

