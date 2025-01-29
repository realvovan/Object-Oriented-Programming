#ifndef RECTANGLE_H
#define RECTANGLE_H

#include "vector2.h"
#include "stdexcept"

class rectangle {
    double width,height;
    vector2 topLeft, topRight, bottomLeft, bottomRight;
    public:
        rectangle(vector2 topLeft, double width, double height) {
            if(width <= 0) throw std::invalid_argument("Width must be positive");
            if(height <= 0) throw std::invalid_argument("Height must be positive");

            this->width = width;
            this->height = height;
            this->topLeft = topLeft;
            this->topRight = vector2(topLeft.X() + width, topLeft.Y());
            this->bottomLeft = vector2(topLeft.X(), topLeft.Y() + height);
            this->bottomRight = vector2(topLeft.X() + width, topLeft.Y() + height);
        }
        double Width() {return this->width;}
        double Height() {return this->height;}
        vector2 TopLeft() {return this->topLeft;}
        vector2 TopRight() {return this->topRight;}
        vector2 BottomLeft() {return this->bottomLeft;}
        vector2 BottomRight() {return this->bottomRight;}

        double GetPerimeter() {return 2 * (this->width + this->height);}
        double GetArea() {return this->width * this->height;}
};

#endif