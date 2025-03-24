#pragma once

class Vertex {
private:
    double e[2];
public:
    Vertex(double x, double y) : e{x,y} {};
    double X() {return this->e[0];}
    double Y() {return this->e[1];}
};