/*
    Done by:
    Student: Hordiienko Volodymyr
    Group: 123:2
    Lab 1.2
    Variant 3
*/

import { MyString } from "./myString"
import { question } from "readline-sync"

let emptyString = new MyString()
var str1 = new MyString(question("Enter a numeric string: "))
var str2 = new MyString(question("Enter another numeric string: "))
console.log(`Empty string: "${emptyString.Value}", length: ${emptyString.Length()}`)
console.log(`String 1: ${str1.Value}, length: ${str1.Length()}`)
console.log(`String 1: ${str2.Value}, length: ${str2.Length()}`)

str1.Value = "1234"
str1.Inverse()

console.log(`Reversed string: ${str1.Value}`)
console.log(`The 2nd element is ${str1.CharAt(1)}`)
let concatenated = str1.Concat(str2)
console.log(`Concatenated sting: ${concatenated.Value}`)
str1.Value = "1a2" // this will error