#pragma once

#include "string"

using namespace std;

class myString {
public:
    string Value;
    
    myString();
    myString(const string &text);
    myString(char text[]);
    myString(const myString &other);

    int Length();
    myString operator+(const string &other);
    myString operator+(const myString &other);
    myString operator+(const char *other);
    myString operator+(char other);

    myString operator-(const string &other);
    myString operator-(const myString &other);
    myString operator-(const char *other);
    myString operator-(char other);

    bool operator==(const myString &other);
    bool operator!=(const myString &other);
};