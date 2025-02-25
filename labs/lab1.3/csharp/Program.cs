// Описати клас, три об'єкти S1, S2, S3,
// використовуючи різні конструктори;
// "вирахувати" з об’єкта S2 символ '#';
// "скласти" об'єкти S2, S3 і результат
// "помістити" до об’єкта S1; результат
// дій вивести на екран

namespace Program;

class Program {
    static void Main() {
        var s1 = new MyString();
        Console.Write("Enter a string: ");
        var s2 = new MyString(Console.ReadLine());
        var s3 = new MyString(s2);
        s2 -= '#';
        Console.WriteLine($"String s2 after removing '#' symbols: {s2}");
        s1 = s2+s3;
        Console.WriteLine($"s2 + s3 = {s1}");
    }
}