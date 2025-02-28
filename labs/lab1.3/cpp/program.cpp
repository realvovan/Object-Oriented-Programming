// Описати клас, три об'єкти S1, S2, S3,
// використовуючи різні конструктори;
// "вирахувати" з об’єкта S2 символ '#';
// "скласти" об'єкти S2, S3 і результат
// "помістити" до об’єкта S1; результат
// дій вивести на екран

#include "iostream"
#include "myString.cpp"

template <typename... Args>
void print(Args... args) {
    ((std::cout << args << " "), ...);
}

int main() {
    myString s1;

    string input;
    print("Enter a string: ");
    std::getline(std::cin,input);

    myString s2(input);
    myString s3(s2);

    s2 = s2 - '#';
    print("String s2 after removing '#' symbols:",s2.Value,'\n');
    s1 = s2+s3;
    print("s2 + s3 =",s1.Value,'\n');

    if(s2 == s3) print("Strings s2 and s3 are equal\n");
    else print("Strings s2 and s3 are NOT equal\n");

    return 0;
}