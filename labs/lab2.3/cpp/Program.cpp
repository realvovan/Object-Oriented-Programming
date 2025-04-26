#include "TextContainer.cpp"
#include "TextLine.cpp"
#include "iostream"

using std::cout;

int main() {
    vector<string> lines = {
        "Lorem  ipsum dolor       sit amet consectetur    adipiscing elit .",
        "Consectetur adipiscing elit quisque faucibus ex sapien vitae.        ",
        "      Ex sapien vitae pellentesque sem placerat in id."
    };
    TextContainer text(lines);
    text[1].RemovePostfixWhiteSpace();
    text[2].RemovePrefixWhiteSpace();
    cout << text.ToString() << "\n------------------------\n";
    text.Append(TextLine("   Placerat    in  id cursus mi pretium tellus duis ."));
    text.Append("Hello");
    text.RemoveLine(4);
    text.RemoveExtraSpaces();
    cout << text.ToString() << '\n';
    cout << "Number of lines: " << text.LineCount()
        << ", number of characters: " << text.CharCount()
        << ", consonant ratio: " << text.ConsonantRatio()
        << "\n------------------------\n";
    
    return 0;
}