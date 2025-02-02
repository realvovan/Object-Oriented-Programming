import { Vector2 } from "./vector2";

export class Rectange {
    private topLeft:Vector2
    private topRight:Vector2
    private bottomLeft:Vector2
    private bottomRight:Vector2
    private width:number
    private height:number

    public constructor(topLeft:Vector2, width:number, height:number) {
        if(height <= 0) {throw new Error("Height must be positive")}
        if(width <= 0) {throw new Error("Width must be positive")}
        
        this.topLeft = topLeft
        this.topRight = new Vector2(topLeft.X+width, topLeft.Y)
        this.bottomLeft = new Vector2(topLeft.X, topLeft.Y+height)
        this.bottomRight = new Vector2(topLeft.X+width, topLeft.Y+height)
        this.width = width
        this.height = height
    }
    public get TopLeft():Vector2 {return this.topLeft}
    public get TopRight():Vector2 {return this.topRight}
    public get BottomLeft():Vector2 {return this.bottomLeft}
    public get BottomRight():Vector2 {return this.bottomRight}
    public GetArea():number {return this.width * this.height}
    public GetPerimeter():number {return 2 * (this.height + this.width)}
}