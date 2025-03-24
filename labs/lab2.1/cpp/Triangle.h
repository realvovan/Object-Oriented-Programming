// Трикутники:
// конструктор з параметрами,
// методи обчислення площі та
// периметра, методи отримання
// даних об’єкту

#pragma once
#include "Shape.cpp"

class Triangle : public Shape2D {
private:
    const string TOO_MANY_VERTICES = "Too many vertices, a triangle must only have 3";
public:
    Triangle();
    Triangle(const Vertex &vertex1,const Vertex &vertex2,const Vertex &vertex3);
    Triangle(const vector<Vertex> &vertices);
    Triangle(const Triangle &other);

    Vertex VertexA() const;
    Vertex VertexB() const;
    Vertex VertexC() const;
    double SideA() const;
    double SideB() const;
    double SideC() const;
    double GetArea() const override;
    double GetPerimeter() const override;
};