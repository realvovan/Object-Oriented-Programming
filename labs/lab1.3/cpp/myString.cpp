#include "myString.h"

myString::myString() {this->Value = "";}
myString::myString(const string &text) {this->Value = text;}
myString::myString(char text[]) {this->Value = string(text);}
myString::myString(const myString &other) {this->Value = other.Value;}

int myString::Length() {return this->Value.length();}

myString myString::operator+(const string &other) {return myString(this->Value + other);}
myString myString::operator+(const myString &other) {return myString(this->Value + other.Value);}
myString myString::operator+(const char *other) {return myString(this->Value + string(other));}
myString myString::operator+(char other) {return myString(this->Value + string(1,other));}

myString myString::operator-(const string &other) {
    string result = this->Value;
    size_t pos = result.find(other);
    while(pos != string::npos) {
        result.erase(pos, other.length());
        pos = result.find(other);
    }
    return myString(result);
}
myString myString::operator-(const myString &other) {
    return (*this) - other.Value;
}
myString myString::operator-(const char *other) {
    return (*this) - string(other);
}
myString myString::operator-(char other) {
    return (*this) - string(1,other);
}

bool myString::operator==(const myString &other) {return this->Value == other.Value;}
bool myString::operator!=(const myString &other) {return this->Value != other.Value;}