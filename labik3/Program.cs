class Program
{
    static void Main()
    {
        // Get input from the user for the sides of the rectangle
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Create an instance of the Rectangle class
        Rectangle rectangle = new Rectangle(side1, side2);

        // Display the perimeter and area of the rectangle
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
        Console.WriteLine($"Area: {rectangle.Area}");
    }
}
