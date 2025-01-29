namespace Program;

class Rectangle {
    public Vector2 TopLeft {get;}
    public Vector2 TopRight {get;}
    public Vector2 BottomLeft {get;}
    public Vector2 BottomRight {get;}
    public double Width {get;}
    public double Height {get;}

    public double GetPerimeter() => 2*(this.Width + this.Height);
    public double GetArea() => this.Width * this.Height;

    public Rectangle(Vector2 topLeft, double width, double height) {
        if(width <= 0) throw new ArgumentException("Width must be positive");
        if(height <= 0) throw new ArgumentException("Height must be positive");
        this.Width = width;
        this.Height = height;

        this.TopLeft = topLeft;
        this.TopRight = new Vector2(topLeft.X+width, topLeft.Y);
        this.BottomLeft = new Vector2(topLeft.X, topLeft.Y+height);
        this.BottomRight = new Vector2(topLeft.X+width, topLeft.Y+height);
    }
}