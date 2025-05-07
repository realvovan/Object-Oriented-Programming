//(2*b-lg(c/4))/(a*a-1)

namespace lab2_4;

class ArithmeticCalculation(double varA, double varB, double varC,Func<double,double,double,double> calculation) {
    private Func<double,double,double,double> calculation = calculation;

    public double VarA { get; set; } = varA;
    public double VarB { get; set; } = varB;
    public double VarC { get; set; } = varC;

    public ArithmeticCalculation(Func<double,double,double,double> calculation) : this(0d,0d,0d,calculation) {}

    public double Calculate() {
        double result = this.calculation.Invoke(this.VarA,this.VarB,this.VarC);
        if (double.IsInfinity(result) || double.IsNaN(result)) throw new ArithmeticException("Denominator cannot be equal to 0");
        return result;
    }
    public void ChangeCalculationMethod(Func<double,double,double,double> calculation) => this.calculation = calculation;

    public static double Log(double n) {
        if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n),"Domain of a logarithmic function is x > 0");
        return Math.Log10(n);
    }
}

static class Program {
    static void protectedCalculation(ArithmeticCalculation calc) {
        try {Console.WriteLine(calc.Calculate());}
        catch (ArgumentOutOfRangeException e) {Console.WriteLine(e.Message);}
        catch (ArithmeticException e) {Console.WriteLine(e.Message);}
    }
    static void Main() {
        var calc = new ArithmeticCalculation(2,3,4,(a,b,c) => (2*b-ArithmeticCalculation.Log(c/4))/(a*a-1));
        ArithmeticCalculation[] calculations = [
            new(2,3,4,(a,b,c) => (2*b-ArithmeticCalculation.Log(c/4))/(a*a-1)),
            new(-1,2,6,(a,b,c) => ArithmeticCalculation.Log(a*b*c)),
            new((a,b,c) => a*b/c)
        ];
        foreach (var i in calculations) protectedCalculation(i);
    }
}