#include "iostream"
#include "Triangle.cpp"

int main() {
    vector<Vertex> vertices = {Vertex(0,0),Vertex(2,1),Vertex(3,-2)};
    Triangle triangle1(vertices);
    cout << triangle1.ToString() << '\n';
    cout << triangle1.GetArea() << ' ' << triangle1.GetPerimeter() << '\n';

    Triangle copiedTriangle(triangle1);
    cout << copiedTriangle.ToString() << '\n';
    return 0;
}