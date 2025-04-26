// Клас-контейнер, який є абстракцією тексту та складається з
// об’єктів класу-рядка та методів додавання рядка до тексту,
// видалення рядка з тексту, очищення тексту, отримання
// довжини найкоротшого рядка, повернення відсотка
// приголосних літер у тексті, заміни сукупності пробілів, що
// стоять поряд, одним пробілом, та видалення пробілів
// спочатку рядка та наприкінці.

namespace lab2_3;

class TextContainer : IWhiteSpaceRemover{
    private TextLine[] lines;

    public int LineCount {get => this.lines.Length;}
    public int CharCount {get {
        int count = 0;
        foreach (var i in this.lines) count += i.Length;
        return count;
    }}
    public TextLine this[int key] {get => this.lines[key];}

    public TextContainer() {
        this.lines = [];
    }
    public TextContainer(string line) {
        //creates a text container from one string object
        this.lines = [new TextLine(line)];
    }
    public TextContainer(TextLine line) {
        //creates a text container from one TextLine object
        this.lines = [line];
    }
    public TextContainer(string[] lines) {
        this.lines = new TextLine[lines.Length];
        for (int i = 0; i < lines.Length; i++) this.lines[i] = new TextLine(lines[i]);
    }
    public TextContainer(TextLine[] lines) {
        this.lines = lines;
    }
    public TextContainer(TextContainer other) {
        this.lines = other.lines;
    }

    public void Append(string line) => this.lines = [..this.lines,new TextLine(line)];
    public void Append(TextLine line) => this.lines = [..this.lines,line];
    public void Clear() {
        Array.Clear(this.lines);
        this.lines = [];
    }
    public void RemoveLine(int line) {
        if (line < 0 || line >= this.lines.Length) throw new IndexOutOfRangeException($"Line {line} is out of range");
        var asList = new List<TextLine>(this.lines);
        asList.RemoveAt(line);
        this.lines = asList.ToArray();
        asList.Clear();
    }
    public TextLine GetShortestLine() {
        TextLine shortestLine = this.lines[0];
        for (int i = 1; i < this.lines.Length; i++) {
            if (this.lines[i].Length < shortestLine.Length) shortestLine = this.lines[i];
        }        
        return shortestLine;
    }
    public IEnumerator<TextLine> GetEnumerator() {
        foreach (TextLine i in this.lines) yield return i;
    }
    public float ConsonantRatio() {
        int consonantCount = 0;
        foreach (var i in this.lines) consonantCount += i.Consonants;
        return (float)consonantCount / this.CharCount;
    }
    public void RemovePrefixWhiteSpace() {
        foreach (var i in this.lines) i.RemovePrefixWhiteSpace();
    }
    public void RemovePostfixWhiteSpace() {
        foreach (var i in this.lines) i.RemovePostfixWhiteSpace();
    }
    public void RemoveExtraSpaces() {
        foreach (var i in this.lines) i.RemoveExtraSpaces();
    }
    public override string ToString() => string.Join('\n',this.lines.Select(line => line.ToString()));

    public static TextContainer operator +(TextContainer left, TextLine right) => new TextContainer([..left,right]);
    public static TextContainer operator +(TextContainer left, string right) => new TextContainer([..left,new TextLine(right)]);
    public static TextContainer operator +(TextContainer left, TextLine[] right) => new TextContainer([..left,..right]);
    public static TextContainer operator +(TextContainer left, string[] right) {
        TextLine[] lines = new TextLine[left.lines.Length + right.Length];
        for (int i = 0; i < left.lines.Length; i++) {
            lines[i] = left.lines[i];
        }
        for (int i = 0; i < right.Length; i++) {
            lines[left.lines.Length + i] = new TextLine(right[i]);
        }
        return new TextContainer(lines);
    }
    public static TextContainer operator +(TextContainer left, TextContainer right) => new TextContainer([..left.lines,..right.lines]);
}