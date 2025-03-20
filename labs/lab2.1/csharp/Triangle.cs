// Трикутники:
// конструктор з параметрами,
// методи обчислення площі та
// периметра, методи отримання
// даних об’єкту

class Triangle : Shape2D {
    const string TOO_MANY_VERTICES = "Too many vertices, a triangle must only have 3";

    public double[] VertexA => this.vertices[0];
    public double[] VertexB => this.vertices[1];
    public double[] VertexC => this.vertices[2];
    public double SideA => this.GetSideLength(1,2);
    public double SideB => this.GetSideLength(0,2);
    public double SideC => this.GetSideLength(0,1);

    public Triangle() : base([ [0,0], [0,1], [1,0] ]) {}
    public Triangle(double[][] vertices) : base(vertices) {if (vertices.GetLength(0) != 3) throw new Exception(TOO_MANY_VERTICES);}
    public Triangle(double[,] vertices) : base(vertices) {if (vertices.GetLength(0) != 3) throw new Exception(TOO_MANY_VERTICES);}
    public Triangle(double[] vertexA, double[] vertexB, double[] vertexC) : base([vertexA,vertexB,vertexC]) {}

    public override double GetArea() {
        //area of a triangle as per Heron's formula
        var semiperimeter = this.GetPerimeter() / 2;
        return Math.Sqrt(semiperimeter*(semiperimeter - SideA)*(semiperimeter - SideB)*(semiperimeter - SideC));
    }
    public override double GetPerimeter() => this.SideA + this.SideB + this.SideC;
}