#pragma once

#include "IWhiteSpaceRemover.h"
#include "string"

using std::string;

class TextLine : public IWhiteSpaceRemover{
private:
    const string CONSONANTS = "qwrtypsdfghjklzxcvbnm";
    const string PUNCTUATION = ".,!?&:;";

    string value;
    int consonants = 0;
public:
    TextLine();
    TextLine(const string &text);
    TextLine(const TextLine &other);
    float ConsonantRatio() const;
    string ToString() const;
    void RemovePrefixWhiteSpace() override;
    void RemovePostfixWhiteSpace() override;
    void RemoveExtraSpaces() override;
    char operator[](int key) const;
    TextLine& operator=(const TextLine &other);

    //getters
    int GetConsonantCount() const;
    int Length() const;
};