// Базовий клас "Рядки": віртуальні функції обчислення довжини
// і видалення символу. Похідний клас "Цифри": значення рядка,
// конструктор з параметром, віртуальні функції обчислення
// довжини і видалення символу ‘5’. Похідний клас "Літери":
// значення рядка, конструктор з параметром, віртуальні функції
// обчислення довжини і видалення символу ‘a’.
namespace Lab2_2;

class MyString {
    protected const string INVALID_STRING_MESSAGE = "Invalid string!";

    public string Value {get; protected set;}

    public MyString() => this.Value = "";
    public MyString(string str) => this.Value = str;

    public IEnumerator<char> GetEnumerator() {
        foreach (char i in this.Value) yield return i;
    }
    public virtual int GetLength() => this.Value.Length;
    public virtual void RemoveSymbol(char symbol) => this.Value = this.Value.Replace(symbol,'\0');

    public static explicit operator string(MyString source) => source.Value;
    public static implicit operator MyString(string source) => new MyString(source);
}

class Numbers : MyString {
    public Numbers() : base() {}
    public Numbers(string str) {
        foreach (char i in str) {
            if (!char.IsDigit(i)) throw new Exception(INVALID_STRING_MESSAGE);
        }
        this.Value = str;
    }
    public Numbers(int nums) => this.Value = nums.ToString();

    public void RemoveSymbol(int num) => this.Value = this.Value.Replace(num.ToString(),"");

    public static explicit operator int(Numbers source) => Convert.ToInt32(source.Value);
}

class Lowercased : MyString {
    public Lowercased() : base() {}
    public Lowercased(string str) {
        foreach (char i in str) {
            if (char.IsUpper(i)) throw new Exception(INVALID_STRING_MESSAGE);
        }
        this.Value = str;
    }

    public static Lowercased ToLowercase(string str) => new Lowercased() {Value = str.ToLower()};
}