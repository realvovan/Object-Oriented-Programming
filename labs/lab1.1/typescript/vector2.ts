export class Vector2 {
    public constructor(private x:number = 0, private y:number = 0) {}

    public get X():number {return this.x}
    public get Y():number {return this.y}

    public Magnitude():number {
        return Math.sqrt(this.x*this.x + this.y*this.y)
    }
    public ToString():string {
        return `${this.x}, ${this.y}`
    }
}