/*
    Done by:
    Student: Hordiienko Volodymyr
    Group: 123:2
    Lab 1.1
    Variant 4
*/

#include "iostream"
#include "rectangle.cpp"
#include "vector2.cpp"

using std::cin;
using std::cout;

int main() {
    double x,y,width,height;
    cout << "Enter the X coord of the top left vertex: ";
    cin >> x;
    cout << "Enter the Y coord of the top left vertex: ";
    cin >> y;
    cout << "Enther the width of the rectangle: ";
    cin >> width;
    cout << "Enther the height of the rectangle: ";
    cin >> height;

    rectangle rect(vector2(x,y),width,height);

    cout << "Top left: " << rect.TopLeft().ToString() << '\n';
    cout << "Top right: " << rect.TopRight().ToString() << '\n';
    cout << "Bottom left: " << rect.BottomLeft().ToString() << '\n';
    cout << "Bottom right: " << rect.BottomRight().ToString() << '\n';
    cout << "Perimeter: " << rect.GetPerimeter() << '\n';
    cout << "Area: " << rect.GetArea() << '\n';

    return 0;
}