// Фігури:
// координати вершин,
// конструктор з параметрами,
// метод обчислення довжини
// сторони
#pragma once
#include "vector"
#include "Vertex.h"
#include "string"

using namespace std;

class Shape2D {
private:
    const string NOT_ENOUGH_VERTICES = "Not enough vertcies, any shape must have at least 3";
    vector<Vertex> vertcies;
public:
    Shape2D();
    Shape2D(const vector<Vertex> &vertices);
    Shape2D(const Shape2D &other);

    Vertex GetVertex(int index) const;
    double GetSideLength(int vertexAIndex, int vertexBIndex) const;
    string ToString() const;
    virtual double GetPerimeter() const;
    virtual double GetArea() const;
};