/*
    Done by:
    Student: Hordiienko Volodymyr
    Group: 123:2
    Lab 1.1
    Variant 4
*/

namespace Program;

class Program {
    static void Main() {
        Console.Write("Enter the X coord of the top left vertex: ");
        float topLeftX = float.Parse(Console.ReadLine());
        Console.Write("Enter the Y coord of the top left vertex: ");
        float topLeftY = float.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        float height = float.Parse(Console.ReadLine());

        Rectangle rect = new(new Vector2(topLeftX,topLeftY),width,height);

        Console.WriteLine($"Top left: {rect.TopLeft}");
        Console.WriteLine($"Top right: {rect.TopRight}");
        Console.WriteLine($"Bottom left: {rect.BottomLeft}");
        Console.WriteLine($"Bottom right: {rect.BottomRight}");
        Console.WriteLine($"Height: {rect.Height}, width: {rect.Width}");
        Console.WriteLine($"Perimeter: {rect.GetPerimeter()}, area: {rect.GetArea()}");
    }
}