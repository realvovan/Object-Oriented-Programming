#ifndef RECTANGLE_H
#define RECTANGLE_H

#include "vector2.h"

class rectangle {
    double width,height;
    vector2 topLeft, topRight, bottomLeft, bottomRight;
    public:
        rectangle(vector2 topLeft, double width, double height);
        double Width() const;
        double Height() const;
        vector2 TopLeft() const;
        vector2 TopRight() const;
        vector2 BottomLeft() const;
        vector2 BottomRight() const;
        double GetPerimeter() const;
        double GetArea() const;
};

#endif