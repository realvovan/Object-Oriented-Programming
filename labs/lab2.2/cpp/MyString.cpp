// Базовий клас "Рядки": віртуальні функції обчислення довжини
// і видалення символу. Похідний клас "Цифри": значення рядка,
// конструктор з параметром, віртуальні функції обчислення
// довжини і видалення символу ‘5’. Похідний клас "Літери":
// значення рядка, конструктор з параметром, віртуальні функції
// обчислення довжини і видалення символу ‘a’.

#include "MyString.h"
#include "stdexcept"

using namespace Lab2_2;

MyString::MyString() : value("") {}
MyString::MyString(const string &str) : value(str) {}
MyString::MyString(const char str[]) : value(string(str)) {}

string MyString::GetValue() const {return this->value;}
int MyString::GetLength() const {return this->value.length();}
void MyString::RemoveSymbol(char symbol) {
    std::size_t pos = this->value.find(symbol);
    while (pos != string::npos) {
        this->value.erase(pos,1);
        pos = this->value.find(symbol);
    }
}
MyString::operator string() const {return this->value;}


Numbers::Numbers() : MyString("") {}
Numbers::Numbers(const string &str) {
    for (char i : str) {
        if (!std::isdigit(i)) throw std::runtime_error(this->INVALID_STRING_MESSAGE);
    }
    this->value = str;
}
Numbers::Numbers(int number) : MyString(std::to_string(number)) {}
Numbers::operator int() const {return std::stoi(this->value);}


Lowercased::Lowercased() : MyString("") {}
Lowercased::Lowercased(const string &str) {
    for (char i : str) {
        if (!std::islower(i)) throw std::runtime_error(this->INVALID_STRING_MESSAGE);
    }
    this->value = str;
}
Lowercased Lowercased::ToLowercased(string str) {
    Lowercased lwr;
    for (int i = 0; i < str.length(); i++) {
        str[i] = std::tolower(str[i]);
    }
    lwr.value = str;
    return lwr;
}