// Фігури:
// координати вершин,
// конструктор з параметрами,
// метод обчислення довжини
// сторони

class Shape2D {
    const string NOT_ENOUGH_VERTICES = "Not enough vertcies, any shape must have at least 3";

    protected readonly double[][] vertices;

    public int VertexCount => this.vertices.Length;
    
    public Shape2D() => this.vertices = [ [0,0], [0,1], [1,0] ];
    public Shape2D(double[][] vertices) => this.vertices = vertices.GetLength(0) > 2 ? vertices : throw new Exception(NOT_ENOUGH_VERTICES);
    public Shape2D(double[,] vertices) {
        if (this.VertexCount < 3) throw new Exception(NOT_ENOUGH_VERTICES);
        this.vertices = new double[this.VertexCount][];
        for (int i = 0; i < this.VertexCount; i++) {
            this.vertices[i] = [vertices[i,0],vertices[i,1]];
        }
    }

    public double[] GetVertex(int index) => index > -1 && index < this.VertexCount ? this.vertices[index] : throw new IndexOutOfRangeException(
        $"Index {index} is out of range for Shape with {this.VertexCount} vertices"
    );
    public double GetSideLength(int vertexAIndex, int vertexBIndex) {
        if (vertexAIndex == vertexBIndex) throw new Exception("Cannot get the side with the same vertices");
        double[] vertexA = this.GetVertex(vertexAIndex);
        double[] vertexB = this.GetVertex(vertexBIndex);
        return Math.Sqrt(Math.Pow(vertexB[0]-vertexA[0],2) + Math.Pow(vertexB[1]-vertexA[1],2));
    }
    public virtual double GetPerimeter() => throw new NotImplementedException();
    public virtual double GetArea() => throw new NotImplementedException();
    public override string ToString() {
        var str = $"{this.GetType().Name} with following vertices:";
        foreach(double[] i in this.vertices) str += $" [{i[0]}, {i[1]}]";
        return str;
    }
}
