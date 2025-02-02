import { Vector2 } from "./vector2"
import { Rectange } from "./rectangle"
import { question } from "readline-sync"

function getInputAsNumber(query:string):number {
    let input = NaN
    while(true) {
        input = Number(question(query))
        if(isNaN(input)) console.log("Enter a valid number!")
        else return input
    }
}

const topLeftX = getInputAsNumber("Enter the X coord of the top left vertex: ")
const topLeftY = getInputAsNumber("Enter the Y coord of the top left vertex: ")
const width = getInputAsNumber("Enter the width of the rectangle: ")
const height = getInputAsNumber("Enter the height of the rectangle: ")

const rect = new Rectange(new Vector2(topLeftX,topLeftY),width,height)

console.log(`Top left: ${rect.TopLeft.ToString()}`)
console.log(`Top right: ${rect.TopRight.ToString()}`)
console.log(`Bottom left: ${rect.BottomLeft.ToString()}`)
console.log(`Bottomg right ${rect.BottomRight.ToString()}`)
console.log(`Perimeter: ${rect.GetPerimeter()}`)
console.log(`Area: ${rect.GetArea()}`)