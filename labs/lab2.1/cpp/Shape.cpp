#include "math.h"
#include "stdexcept"
#include "sstream"
#include "Shape.h"

Shape2D::Shape2D() : vertcies{Vertex(0,0),Vertex(0,1),Vertex(1,0)} {}
Shape2D::Shape2D(const vector<Vertex> &vertices) {
    if (vertices.size() < 3) throw invalid_argument(this->NOT_ENOUGH_VERTICES);
    this->vertcies = vertices;
}
Shape2D::Shape2D(const Shape2D &other) : vertcies(other.vertcies) {}

Vertex Shape2D::GetVertex(int index) const {
    if (index < 0 || index >= this->vertcies.size()) throw invalid_argument("Index out of range");
    return this->vertcies[index];
}

double Shape2D::GetSideLength(int vertexAIndex, int vertexBIndex) const {
    if (vertexAIndex == vertexBIndex) throw new invalid_argument("Cannot get the side with the same vertices");
    Vertex v1 = this->GetVertex(vertexAIndex);
    Vertex v2 = this->GetVertex(vertexBIndex);
    return sqrt(pow(v2.X()-v1.X(),2) + pow(v2.Y()-v1.Y(),2));
}

string Shape2D::ToString() const {
    ostringstream stream;
    stream << typeid(this).name() << " with the following vertices:";
    for (Vertex i : this->vertcies) stream << " [" << i.X() << ", " << i.Y() << "]";
    return stream.str();
}

double Shape2D::GetArea() const {throw runtime_error("No implementation");}
double Shape2D::GetPerimeter() const {throw runtime_error("No implementation");}