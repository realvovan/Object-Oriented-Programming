// Значення рядка (цифрові символи),
// конструктори, деструктор, метод
// обчислення довжини, метод обернення
// рядка, метод отримання значення рядка)

export class MyString {
    private value: string;
    public get Value():string {return this.value}
    public set Value(text:string) {
        if(!MyString.IsNumeric(text)) throw new Error("String must be numeric");
        this.value = text
    }

    constructor(text?:string) {
        this.Value = text || ""
    }

    public Length():number {return this.value.length}

    public Inverse():void {this.value = this.value.split("").reverse().join("")}

    public Concat(other:MyString):MyString {return new MyString(this.value + other.value)}

    public CharAt(index:number):string {return this.value.charAt(index)}

    public static IsNumeric(text: string): boolean {
        for (const c of text) {
            if (isNaN(Number(c))) return false
        }
        return true;
    }
}
