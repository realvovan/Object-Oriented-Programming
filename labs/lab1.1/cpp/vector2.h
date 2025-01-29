#ifndef VECTOR2_H
#define VECTOR2_H

#include "math.h"
#include "string.h"

class vector2 {
    double x,y;
    public:
        vector2(): x(0), y(0) {}
        vector2(double x, double y) : x(x), y(y) {}
        double X() {return this->x;}
        double Y() {return this->y;}
        double Magnitude() {return std::sqrt(this->x*this->x + this->y*this->y);}
        std::string ToString() {return (std::to_string(this->x) + ", " + std::to_string(this->y));}
};

#endif