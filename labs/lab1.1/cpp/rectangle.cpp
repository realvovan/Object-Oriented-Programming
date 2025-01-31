#include "rectangle.h"
#include "stdexcept"


rectangle::rectangle(vector2 topLeft, double width, double height) {
    if(width <= 0) throw std::invalid_argument("Width must be positive");
    if(height <= 0) throw std::invalid_argument("Height must be positive");
    this->width = width;
    this->height = height;
    this->topLeft = topLeft;
    this->topRight = vector2(topLeft.X() + width, topLeft.Y());
    this->bottomLeft = vector2(topLeft.X(), topLeft.Y() + height);
    this->bottomRight = vector2(topLeft.X() + width, topLeft.Y() + height);
}

double rectangle::Width() const {return this->width;}
double rectangle::Height() const {return this->height;}
vector2 rectangle::TopLeft() const {return this->topLeft;}
vector2 rectangle::TopRight() const {return this->topRight;}
vector2 rectangle::BottomLeft() const {return this->bottomLeft;}
vector2 rectangle::BottomRight() const {return this->bottomRight;}
double rectangle::GetPerimeter() const {return 2 * (this->width + this->height);}
double rectangle::GetArea() const {return this->width * this->height;}