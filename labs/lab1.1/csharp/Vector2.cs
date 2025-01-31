namespace Program;

class Vector2(double x = 0, double y = 0) {
    public double X {get;} = x;
    public double Y {get;} = y;

    public double Magnitude() => Math.Sqrt(this.X*this.X + this.Y*this.Y);
    public override string ToString() => $"{this.X}, {this.Y}";
}