// Рядки: значення рядка (символи), конструктор
// за умовчанням, конструктор з параметрами,
// конструктор копіювання, метод обчислення
// довжини рядка, метод отримання значення
// рядка, перевантаження операторів
// додавання, вирахування. Метод вирахування
// повинен передбачати можливість роботи з
// кількома рядками

namespace Program;

class MyString {
    public string Value {get;set;}

    public MyString() => this.Value = "";
    public MyString(string text) => this.Value = text;
    public MyString(char[] text) => this.Value = new String(text);
    public MyString(MyString other) => this.Value = other.Value;

    public int Length() => this.Value.Length;
    public override string ToString() => this.Value;

    public static MyString operator +(MyString a, MyString b) => new MyString(a.Value + b.Value);
    public static MyString operator -(MyString a, MyString b) => new MyString(a.Value.Replace(b.Value,""));
    public static MyString operator -(MyString a, string b) => new MyString(a.Value.Replace(b,""));
    public static MyString operator -(MyString a, char b) => new MyString(a.Value.Replace(b,'\0'));
}