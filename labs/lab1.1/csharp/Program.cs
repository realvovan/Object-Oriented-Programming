/*
    Done by:
    Student: Hordiienko Volodymyr
    Group: 123:2
    Lab 1.1
    Variant 4
*/

namespace Program;

class Program {
    static float getInputAsFloat(string query) {
        float f = 0;
        while(true) {
            Console.Write(query);
            if(float.TryParse(Console.ReadLine(), out f)) return f;
            else Console.WriteLine("Please enter a valid number!");
        }
    }

    static void Main() {
        float topLeftX = getInputAsFloat("Enter the X coord of the top left vertext: ");
        float topLeftY = getInputAsFloat("Enter the Y coord of the top left vertex: ");
        float width = getInputAsFloat("Enter the width of the rectangle: ");
        float height = getInputAsFloat("Enter the height of the rectangle: ");

        Rectangle rect = new(new Vector2(topLeftX,topLeftY),width,height);

        Console.WriteLine($"Top left: {rect.TopLeft}");
        Console.WriteLine($"Top right: {rect.TopRight}");
        Console.WriteLine($"Bottom left: {rect.BottomLeft}");
        Console.WriteLine($"Bottom right: {rect.BottomRight}");
        Console.WriteLine($"Height: {rect.Height}, width: {rect.Width}");
        Console.WriteLine($"Perimeter: {rect.GetPerimeter()}, area: {rect.GetArea()}");
    }
}