#pragma once

#include "TextLine.h"
#include "vector"

using std::vector;

class TextContainer : public IWhiteSpaceRemover {
private:
    vector<TextLine> lines;
public:
    TextContainer();
    TextContainer(const string &line);
    TextContainer(const TextLine &line);
    TextContainer(const vector<string> &lines);
    TextContainer(const vector<TextLine> &lines);
    TextContainer(const TextContainer &other);
    void Append(const string &line);
    void Append(const TextLine &line);
    void Clear();
    void RemoveLine(int line);
    int LineCount() const;
    int CharCount() const;
    TextLine GetShortestLine() const;
    float ConsonantRatio() const;
    string ToString() const;
    void RemovePrefixWhiteSpace() override;
    void RemovePostfixWhiteSpace() override;
    void RemoveExtraSpaces() override;
    TextLine& operator[](int key);
};