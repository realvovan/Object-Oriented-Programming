#include "ArithmeticCalculation.h"
#include "cmath"
#include "stdexcept"

ArithmeticCalculation::ArithmeticCalculation(double a,double b,double c,function<double(double, double, double)> calc)
    : varA(a), varB(b), varC(c), calculation(calc) {}
ArithmeticCalculation::ArithmeticCalculation(function<double(double,double,double)> calc)
    : ArithmeticCalculation(0.0,0.0,0.0,calc) {}

double ArithmeticCalculation::Calculate() const {
    double result = calculation(varA, varB, varC);
    if (std::isinf(result) || std::isnan(result)) throw std::runtime_error("Denominator cannot be equal to 0");
    return result;
}

void ArithmeticCalculation::ChangeCalculationMethod(std::function<double(double, double, double)> calc) {calculation = calc;}

double ArithmeticCalculation::Log(double n) {
    if (n <= 0) throw std::out_of_range("Domain of a logarithmic function is x > 0");
    return std::log10(n);
}