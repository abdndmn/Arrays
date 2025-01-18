# Array Operations in C#

This program demonstrates basic operations with arrays in C#, including user input, resizing arrays, and sorting elements.

---

## Features

1. **Define an Array**:
   - Creates an integer array with 10 elements.
   - Fills the array with user input using a `for` loop.

2. **Display the Array**:
   - Uses a `foreach` loop to display the contents of the array.

3. **Add a New Element**:
   - Prompts the user to input an additional value.
   - Resizes the array to include the new element.

4. **Sort and Reverse the Array**:
   - Sorts the array in ascending order using `Array.Sort`.
   - Reverses the array to display it in descending order using `Array.Reverse`.

---

## Example Usage

### Input:
```
Lütfen dizinin 1. elemanını giriniz: 5
Lütfen dizinin 2. elemanını giriniz: 8
...
Lütfen diziye eklenecek olan değeri giriniz: 3
```

### Output:
```
Oluşturulan Dizi:
5
8
...

 Dizinin Son Hali:
8
5
3
...
```

---

## Concepts Demonstrated

1. **Array Initialization and Resizing**:
   - Demonstrates how to define and resize arrays in C# using `Array.Resize`.

2. **User Input**:
   - Collects values from the user and adds them to the array.

3. **Sorting and Reversing**:
   - Uses `Array.Sort` and `Array.Reverse` to organize the array.

---

## How to Extend

- Add input validation to ensure only valid integers are entered.
- Allow dynamic array sizes by prompting the user for the initial array length.
- Include options for different sorting orders (ascending, descending).

---

This project is a great introduction to working with arrays and basic data manipulation in C#.

