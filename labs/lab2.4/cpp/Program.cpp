#include "iostream"
#include "ArithmeticCalculation.cpp"

void protectedCalculation(const ArithmeticCalculation &calc) {
    try {
        std::cout << calc.Calculate() << std::endl;
    } catch (const std::out_of_range& e) {
        std::cout << e.what() << std::endl;
    } catch (const std::runtime_error& e) {
        std::cout << e.what() << std::endl;
    }
}

int main() {
    ArithmeticCalculation calculations[] = {
        ArithmeticCalculation(2,3,4,[](double a,double b,double c) {
            return (2*b-ArithmeticCalculation::Log(c/4) / (a*a-1));
        }),
        ArithmeticCalculation(-1,2,6,[](double a,double b,double c) {
            return ArithmeticCalculation::Log(a*b*c);
        }),
        ArithmeticCalculation([](double a, double b,double c) {
            return a*b/c;
        })
    };
    for (const auto &i : calculations) protectedCalculation(i);
    return 0;
}