#include "headers/TextLine.h"
#include "algorithm" // for std::find
#include "sstream" // for std::ostringstream

bool contains(const string &arr, char element) {
    return std::find(arr.begin(),arr.end(),element) != arr.end();
}

TextLine::TextLine() : value("") {}
TextLine::TextLine(const string &text) : value(text) {
    for (char i : text) {
        if (contains(CONSONANTS,std::tolower(i))) {
            this->consonants++;
        }
    }
}
TextLine::TextLine(const TextLine &other) : value(other.value), consonants(other.consonants) {}
float TextLine::ConsonantRatio() const {
    return (float)this->consonants / this->value.length();
}
string TextLine::ToString() const {
    return this->value;
}
void TextLine::RemovePrefixWhiteSpace() {
    int i;
    for (i = 0; i < this->value.length(); i++) {
        if (this->value[i] != ' ') break;
    }
    this->value = this->value.substr(i);
}
void TextLine::RemovePostfixWhiteSpace() {
    int i;
    for (i = this->value.length() - 1; i > -1; i--) {
        if (this->value[i] != ' ') break;
    }
    this->value = this->value.substr(0,i);
}
void TextLine::RemoveExtraSpaces() {
    std::ostringstream result;
    bool isWord = false;
    for (int i = 0; i < this->value.length(); i++) {
        char currentChar = this->value[i];
        if (currentChar == ' ') {
            char nextCharacter = '\0';
            for (int j = i + 1; j < this->value.length(); j++) {
                if (this->value[j] != ' ') {
                    nextCharacter = this->value[j];
                    i = j - 1;
                    break;
                }
            }
            if (isWord && nextCharacter != '\0' && !contains(PUNCTUATION,nextCharacter)) {
                result << ' ';
                isWord = false;
            }
        } else {
            result << currentChar;
            isWord = true;
        }
    }
    this->value = result.str();
}
char TextLine::operator[](int key) const {
    return this->value[key];
}
TextLine& TextLine::operator=(const TextLine &other) {
    return *this;
}

//getters
int TextLine::GetConsonantCount() const { return this->consonants; }
int TextLine::Length() const { return this->value.length(); }