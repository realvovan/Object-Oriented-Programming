namespace Lab2_2;

static class Program {
    static void Main() {
        MyString str1 = new("Hello world!");
        MyString str2 = "What's poppin";
        string castedToString = (string)str1;
        Console.WriteLine($"String 1: {str1.Value}\nString 2: {str2.Value}\nString 1 casted to string type: {castedToString}");

        Numbers num1 = new("12345");
        Numbers num2 = new(420);
        int castedToInt = (int)num1;
        num1.RemoveSymbol(5);
        Console.WriteLine($"Number 1: {num1.Value}\nNumber 2: {num2.Value}\nNumber 1 casted to int type: {castedToInt}");
        Console.WriteLine("Looping over num1");
        foreach (char i in num1) Console.WriteLine(i);

        Lowercased lower1 = new("lowercase");
        Lowercased lower2 = Lowercased.ToLowercase("FROM UPPPERCASED");
        lower1.RemoveSymbol('a');
        Console.WriteLine($"Lower 1: {lower1.Value}\nLower 2: {lower2.Value}");
    }
}