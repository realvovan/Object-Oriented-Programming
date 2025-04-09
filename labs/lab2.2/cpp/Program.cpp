#include "MyString.cpp"
#include "iostream"

using namespace Lab2_2;
using std::cout;

int main() {
    MyString str1("Hello world");
    MyString str2 = "What's poppin";
    string castedToString = (string)str2;
    cout << "String 1:" << str1.GetValue()
        << " String 2:" << str2.GetValue()
        << " MyString casted to string type: " << castedToString
        << '\n';
    
    Numbers num1("12345");
    Numbers num2(420);
    int castedToInt = (int)num1;
    num1.RemoveSymbol('5');
    cout << "Number 1:" << num1.GetValue()
        << " Number 2:" << num2.GetValue()
        << " Numbers casted to int type: " << castedToInt
        << '\n';

    
    Lowercased lower1("hallo");
    Lowercased lower2 = Lowercased::ToLowercased("YOLO FELLOW KIDS");
    lower1.RemoveSymbol('a');
    cout << "Lowercase string 1:" << lower1.GetValue()
        << " Lowercase string 2:" << lower2.GetValue()
        << '\n';
    return 0;
}