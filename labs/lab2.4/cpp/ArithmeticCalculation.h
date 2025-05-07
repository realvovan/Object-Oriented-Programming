#pragma once
#include <functional>

using std::function;

class ArithmeticCalculation {
private:
    function<double(double, double, double)> calculation;
public:
    double varA, varB, varC;
    
    ArithmeticCalculation(function<double(double,double,double)> calc);
    ArithmeticCalculation(double a,double b,double c,function<double(double, double, double)> calc);

    double Calculate() const;
    void ChangeCalculationMethod(function<double(double, double, double)> calc);

    static double Log(double n);
};