namespace Program;

class Vector2(double x = 0, double y = 0) {
    public double X {get;} = x;
    public double Y {get;} = y;
    public double Magnitude {get;} = Math.Sqrt(x*x+y*y);

    public override string ToString() => $"{this.X}, {this.Y}";
}