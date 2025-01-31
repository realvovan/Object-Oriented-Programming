#ifndef VECTOR2_H
#define VECTOR2_H

#include "string"

class vector2 {
    double x,y;
    public:
        vector2();
        vector2(double x, double y);
        double X() const;
        double Y() const;
        double Magnitude() const;
        std::string ToString() const;
};

#endif