#include "Triangle.h"
#include "stdexcept"
#include "math.h"

Triangle::Triangle() : Shape2D({Vertex(0,0),Vertex(1,0),Vertex(0,1)}) {}
Triangle::Triangle(const Vertex &vertex1,const Vertex &vertex2,const Vertex &vertex3) : Shape2D({vertex1,vertex2,vertex3}) {}
Triangle::Triangle(const vector<Vertex> &vertices) : Shape2D(vertices) {
    if (vertices.size() != 3) throw invalid_argument(this->TOO_MANY_VERTICES);
}
Triangle::Triangle(const Triangle &other) : Shape2D(other) {}

Vertex Triangle::VertexA() const {return this->GetVertex(0);}
Vertex Triangle::VertexB() const {return this->GetVertex(1);}
Vertex Triangle::VertexC() const {return this->GetVertex(2);}
double Triangle::SideA() const {return this->GetSideLength(1,2);}
double Triangle::SideB() const {return this->GetSideLength(0,2);}
double Triangle::SideC() const {return this->GetSideLength(0,1);}

double Triangle::GetArea() const {
    //area of a triangle as per Heron's formula
    double semipertimeter = this->GetPerimeter() / 2;
    return sqrt(semipertimeter*(semipertimeter - this->SideA())*(semipertimeter - this->SideB())*(semipertimeter - this->SideC()));
}
double Triangle::GetPerimeter() const {
    return this->SideA() + this->SideB() + this->SideC();
}