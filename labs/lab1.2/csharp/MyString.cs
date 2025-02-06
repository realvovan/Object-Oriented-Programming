namespace Program;

// Значення рядка (цифрові символи),
// конструктори, деструктор, метод
// обчислення довжини, метод обернення
// рядка, метод отримання значення рядка)
class MyString {
    private string _value;
    public string Value {
        get => this._value;
        set {
            if(!MyString.IsNumeric(value)) throw new Exception("String must be numeric");
            this._value = value;
        }
    }

    public MyString() {
        this._value = "";
    }
    public MyString(string text) {
        this.Value = text;
    }
    public MyString(char[] text) {
        this.Value = new String(text);
        
    }
    ~MyString() {
        Console.WriteLine($"String {this._value} is destroyed");
    }

    public int Lenght() => this._value.Length;

    public void Inverse() {
        char[] chars = this._value.ToCharArray();
        Array.Reverse(chars);
        this._value = new String(chars);
    }

    public IEnumerator<char> GetEnumerator() {
        foreach(char c in this._value) yield return c;
    }

    public override string ToString() => this._value;

    public static bool IsNumeric(string text) {
        foreach(char i in text) {
            if(!Char.IsDigit(i)) return false;
        }
        return true;
    }

    public static MyString operator +(MyString a, MyString b) => new MyString(a._value+b._value);
    public char this[int key] {
        get => this._value[key];
    }
}