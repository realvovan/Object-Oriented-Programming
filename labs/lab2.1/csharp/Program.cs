// 3rd variant
// Описати класи, об’єкт
// похідного класу;
// вивести дані об’єкта;
// обчислити і вивести площу
// та периметр
static class Porgram {
    static void Main() {
        var triangle = new Triangle([0,0],[0.5,1],[3,0]);
        Console.WriteLine(triangle);
        Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}, area: {triangle.GetArea()}");
    }
}