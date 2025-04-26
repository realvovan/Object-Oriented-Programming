// Клас-рядок, який містить методи, необхідні для роботи
// методів класу-контейнера.
using System.Text;

namespace lab2_3;

class TextLine : IWhiteSpaceRemover {
    private const string CONSONANTS = "qwrtypsdfghjklzxcvbnm";
    private const string PUNCTUATION = ".,!?&:;";

    public string Value {get; private set;}
    public int Length {get => this.Value.Length;}
    public int Consonants {get;} = 0;
    public char this[int key] {get => this.Value[key];}

    public TextLine() => this.Value = "";
    public TextLine(TextLine textLine) {
        this.Value = textLine.Value;
        this.Consonants = textLine.Consonants;
    }
    public TextLine(string text) {
        this.Value = text;
        foreach (char i in text) {
            if (CONSONANTS.Contains(char.ToLower(i))) this.Consonants++;
        }
    }
    
    public float ConsonantRatio() => (float)this.Consonants / this.Length;
    public void RemovePrefixWhiteSpace() {
        int i;
        for (i = 0; i < this.Value.Length; i++) {
            if (this.Value[i] != ' ') break;
        }
        this.Value = this.Value.Substring(i);
    }
    public void RemovePostfixWhiteSpace() {
        int i;
        for (i = this.Value.Length - 1; i > -1; i--) {
            if (this.Value[i] != ' ') break;
        }
        this.Value = this.Value.Substring(0,i);
    }
    public void RemoveExtraSpaces() {
        StringBuilder result = new();
        bool isWord = false;
        for (int i = 0; i < this.Value.Length; i++) {
            char currectChar = this.Value[i];
            if (currectChar == ' ') {
                char nextChar = '\0';
                for (int j = i + 1; j < this.Value.Length; j++) {
                    if (this.Value[j] != ' ') {
                        nextChar = this.Value[j];
                        i = j - 1;
                        break;    
                    }
                }
                if (isWord && nextChar != '\0' && !PUNCTUATION.Contains(nextChar)) {
                    result.Append(' ');
                    isWord = false;
                }
            } else {
                result.Append(currectChar);
                isWord = true;
            }
        }
        this.Value = result.ToString();
    }

    public override string ToString() => this.Value;
}