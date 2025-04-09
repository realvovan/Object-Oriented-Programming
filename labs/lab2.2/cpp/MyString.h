// Базовий клас "Рядки": віртуальні функції обчислення довжини
// і видалення символу. Похідний клас "Цифри": значення рядка,
// конструктор з параметром, віртуальні функції обчислення
// довжини і видалення символу ‘5’. Похідний клас "Літери":
// значення рядка, конструктор з параметром, віртуальні функції
// обчислення довжини і видалення символу ‘a’.
#pragma once
#include "string"
using std::string;

namespace Lab2_2 {

class MyString {
protected:
    const string INVALID_STRING_MESSAGE = "Invalid string!";
    string value;
public:
    MyString();
    MyString(const string &str);
    MyString(const char str[]);
    string GetValue() const;
    virtual int GetLength() const;
    virtual void RemoveSymbol(char symbol);
    explicit operator string() const;
};

class Numbers : public MyString {
public:
    Numbers();
    Numbers(const string &str);
    Numbers(int number);
    explicit operator int() const;
};

class Lowercased : public MyString {
public:
    Lowercased();
    Lowercased(const string &str);
    static Lowercased ToLowercased(string str);
};

}