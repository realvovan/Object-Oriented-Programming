/*
    Done by:
    Student: Hordiienko Volodymyr
    Group: 123:2
    Lab 1.2
    Variant 3
*/

namespace Program;

class Program {
    static void Main() {
        var emptyString = new MyString();

        Console.WriteLine("Enter a numeric string");
        var str1 = new MyString(Console.ReadLine());
        Console.WriteLine("Enter anoter numeric string");
        var str2 = new MyString(Console.ReadLine().ToCharArray());
    
        Console.WriteLine($"Empty string: \"{emptyString.Value}\", length: {emptyString.Lenght()}");
        Console.WriteLine($"String 1: {str1.Value}, lenght {str1.Lenght()}");
        Console.WriteLine($"String 2: {str2.Value}, lenght {str2.Lenght()}");
        str1.Value = "12345";
        str1.Inverse();
        Console.WriteLine($"Inveresed string 1: {str1.Value}");
        Console.WriteLine($"2nd element is {str1[1]}");
        MyString contatenated = str1 + str2;
        Console.WriteLine($"Concatenated strings: {contatenated.Value}");
        
        Console.WriteLine($"Looping over {str1.Value}");
        foreach(char c in str1) {
            Console.WriteLine(c);
        }
        str1.Value = "1a2"; // this will error
    }
}