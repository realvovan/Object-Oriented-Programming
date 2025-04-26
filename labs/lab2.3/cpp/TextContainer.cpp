#include "headers/TextContainer.h"
#include "headers/TextLine.h"
#include "stdexcept"

TextContainer::TextContainer() : lines{} {};
TextContainer::TextContainer(const string &line) : lines{TextLine(line)} {}
TextContainer::TextContainer(const TextLine &line) : lines{line} {}
TextContainer::TextContainer(const vector<string> &lines) {
    for (const string &i : lines) this->lines.push_back(TextLine(i));
}
TextContainer::TextContainer(const vector<TextLine> &lines) : lines(lines) {}
TextContainer::TextContainer(const TextContainer &other) : lines(other.lines) {}
void TextContainer::Append(const string &line) {
    this->lines.push_back(TextLine(line));
}
void TextContainer::Append(const TextLine &line) {
    this->lines.push_back(line);
}
void TextContainer::Clear() {
    this->lines.clear();
}
void TextContainer::RemoveLine(int line) {
    if (line < 0 || line >= this->lines.size()) throw std::invalid_argument("Line is out of range");
    this->lines.erase(this->lines.begin() + line);
}
int TextContainer::LineCount() const { return this->lines.size(); }
int TextContainer::CharCount() const {
    int count = 0;
    for (TextLine i : this->lines) count += i.Length();
    return count;
}
float TextContainer::ConsonantRatio() const {
    int consonantCount = 0;
    for (TextLine i : this->lines) consonantCount += i.GetConsonantCount();
    return (float)consonantCount / this->CharCount();
}
TextLine TextContainer::GetShortestLine() const {
    TextLine shortest = this->lines[0];
    for (int i = 1; i < this->lines.size(); i++) {
        if (this->lines[i].Length() < shortest.Length()) shortest = this->lines[i];
    }
    return shortest;
}
void TextContainer::RemovePrefixWhiteSpace() {
    for (TextLine &i : this->lines) i.RemovePrefixWhiteSpace();
}
void TextContainer::RemovePostfixWhiteSpace() {
    for (TextLine &i : this->lines) i.RemovePostfixWhiteSpace();
}
void TextContainer::RemoveExtraSpaces() {
    for (TextLine &i : this->lines) i.RemoveExtraSpaces();
}
string TextContainer::ToString() const {
    if (this->lines.size() == 0) return "";
    string result = this->lines[0].ToString();
    for (int i = 1; i < this->lines.size(); i++) {
        result += '\n' + this->lines[i].ToString();
    }
    return result;
}
TextLine& TextContainer::operator[](int key) { return this->lines[key]; }