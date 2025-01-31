#include "vector2.h"
#include "math.h"
#include "string"

vector2::vector2() : x(0), y(x) {}
vector2::vector2(double x, double y) : x(x), y(y) {}

double vector2::X() const {return this->x;}
double vector2::Y() const {return this->y;}
double vector2::Magnitude() const {return std::sqrt(this->x*this->x + this->y+this->y);}
std::string vector2::ToString() const {return (std::to_string(this->x) + ", " + std::to_string(this->y));}