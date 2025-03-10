﻿//Варіант 3
// Клас інкапсулює одновимірний масив з елементів булевого типу. Створити
// індексатор, що запобігає порушенню границі масиву та повертає обернене
// значення заданого індексом елемента масиву. Створити властивість, доступну для
// читання закритого елементу-даного, що зберігає значення операції логічного
// додавання всіх елементів масиву
using System.Data;

namespace Homework1;

class BoolArray(bool[] values) {
    private bool[] array = values;
    private bool sum = getSum(values);

    public int Length {get => this.array.Length;}
    /// <summary>
    /// The logical sum of all elements of the array
    /// </summary>
    public bool Sum {get => this.sum;}

    /// <summary>
    /// Appends <i><paramref name="value"/></i> to the end of the array
    /// </summary>
    public void Add(bool value) {
        this.array = [..this.array,value];
        this.sum = getSum(this.array);
    }
    /// <summary>
    /// Appends an array of given bool values to the end of the array
    /// </summary>
    public void Add(bool[] values) {
        this.array = [..this.array,..values];
        this.sum = getSum(this.array);
    }
    public IEnumerator<bool> GetEnumerator() {
        foreach(bool i in this.array) yield return i;
    }
    /// <summary>
    /// Returns whether or not all values of the array are equal to <i><paramref name="predicate"/></i>
    /// </summary>
    public bool All(bool predicate) {
        foreach(var i in this.array) if(i != predicate) return false;
        return true;
    }
    /// <summary>
    /// Joins all the values of the array with a given <i><paramref name="separator"/></i>
    /// </summary>
    public string Join(string separator = "") {
        if(this.Length == 0) return string.Empty;
        string result = this.array[0].ToString();
        for(int i = 1; i < this.Length; i++) result += separator + this.array[i].ToString();
        return result;
    }
    public override string ToString()
        => $"Array [{this.Join(", ")}], length: {this.Length}, logical sum of elements: {this.sum}";
    /// <summary>
    ///     Gets the inversed value of the array or sets a value at a specified index
    /// </summary>
    /// <returns>Returns the inversed value at a specified index or NULL if the index is out of range</returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    /// <exception cref="NoNullAllowedException"></exception>
    public bool? this[int key] {
        get => key < this.Length ? !this.array[key] : null;
        set {
            if(key >= this.Length) throw new IndexOutOfRangeException(
                $"Index {key} is out of range for array with length {this.Length}"
            );
            this.array[key] = value ?? throw new NoNullAllowedException("NULL values are not allowed");
        }
    }

    private static bool getSum(bool[] array) {
        bool result = false;
        foreach(bool i in array) result |= i;
        return result;
    }
}

static class Program {
    static void Main() {
        BoolArray arr = new([false,false,false]);
        Console.WriteLine(arr.ToString());
        arr.Add(true);
        Console.WriteLine(arr.ToString());
        arr.Add([true,false,false]);
        Console.WriteLine(arr.ToString());
        Console.WriteLine($"Invered element at index 0: {arr[0]}");
        Console.WriteLine($"Invered element at index 10: {arr[10]}");
        arr[1] = true;
        Console.Write("Looping over the array: ");
        foreach(bool i in arr) Console.Write($"{i} ");
        Console.WriteLine();
        try {
            arr[1] = null;
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        try {
            arr[10] = true;
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}