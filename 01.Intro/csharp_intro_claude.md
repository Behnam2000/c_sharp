# C# Introduction

## Variables
**your answer**
A variable is a named storage location in memory that holds a value of a specific type. In C#, every variable has a type that's fixed at declaration (C# is statically typed), which determines what kind of data it can hold and what operations are valid on it.
```csharp
int age = 30;
string name = "Alex";
```

### Declaring & Assigning
**your answer**
**Declaring** a variable means telling the compiler its name and type, without necessarily giving it a value yet. **Assigning** means putting a value into that variable. You can declare and assign separately, or together in one statement.
```csharp
int score;      // declaration
score = 100;     // assignment
int total = 50;  // declaration + assignment
```

### Initialize
**your answer**
Initializing a variable means giving it a value at the moment it's declared. In C#, local variables must be initialized (or assigned) before they're used — the compiler will error on a "use of unassigned local variable."
```csharp
int count = 0; // declared and initialized together
```

### Implicit and Explicitly typed variables
**your answer**
An **explicitly typed** variable states its type directly (`int`, `string`, `bool`, etc.). An **implicitly typed** variable uses the `var` keyword, letting the compiler infer the type from the value on the right-hand side at compile time — it's still strongly typed, just inferred rather than written out.
```csharp
int explicitAge = 30;      // explicit
var implicitAge = 30;      // implicit — compiler infers int
var name = "Alex";         // compiler infers string
```

### char Datatype
**your answer**
`char` represents a single 16-bit Unicode character, written with single quotes (not double quotes, which are for `string`). It's distinct from a one-character string.
```csharp
char grade = 'A';
char newline = '\n';
```

### String Manipulation with String Formmating
**your answer**
Strings in C# can be built and formatted several ways: concatenation with `+`, **string interpolation** with `$"..."` (the most common modern approach, embedding expressions directly with `{}`), and `string.Format()`. Useful methods include `.ToUpper()`, `.Substring()`, `.Trim()`, and `.Replace()`.
```csharp
string first = "Jane";
int age = 28;
string message = $"{first} is {age} years old"; // interpolation
string message2 = string.Format("{0} is {1} years old", first, age);
```

## Operators and Order of Evaluation
**your answer**
C# has arithmetic (`+ - * / %`), comparison (`== != < > <= >=`), logical (`&& || !`), and assignment (`= += -= *= /=`) operators, among others. When an expression mixes operators, C# follows **operator precedence** rules (similar to math: `*` and `/` before `+` and `-`) and evaluates left-to-right for operators of equal precedence. Parentheses `()` can (and should) be used to make evaluation order explicit and unambiguous.
```csharp
int result = 2 + 3 * 4;     // 14, not 20 — * happens first
int result2 = (2 + 3) * 4;  // 20 — parentheses override precedence
```

## Data Types in C#

### Value Types
**your answer**
Value types store their data directly in the memory location assigned to the variable (typically the stack). Examples: `int`, `double`, `bool`, `char`, `struct`. When you assign one value-type variable to another, the value is **copied** — the two variables are independent afterward.
```csharp
int a = 5;
int b = a; // b gets a copy of a's value
b = 10;    // a is still 5
```

### Reference Types
**your answer**
Reference types store a reference (a pointer) to the actual data, which lives on the heap. Examples: `class`, `string`, `array`, `object`. When you assign one reference-type variable to another, both variables point to the **same underlying object**.
```csharp
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1; // arr2 references the same array
arr2[0] = 99;      // arr1[0] is also now 99
```

- Value vs Referece Type: **your answer**
The core difference is *what gets copied on assignment*: value types copy the actual data, so changes to one variable don't affect another; reference types copy the reference, so both variables point to the same object in memory, and changes through one are visible through the other.

### Nullable Types
**your answer**
Value types normally can't be `null` (they always hold an actual value), but appending `?` makes them **nullable**, allowing them to also represent "no value." This is done via the `Nullable<T>` struct under the hood.
```csharp
int? maybeAge = null;
if (maybeAge.HasValue) { Console.WriteLine(maybeAge.Value); }
```

### User Defined Types
**your answer**
Beyond C#'s built-in types, you can define your own types using `class`, `struct`, `enum`, or `interface`. These let you model custom data structures and behavior specific to your program.
```csharp
enum Direction { North, South, East, West }
class Person { public string Name; public int Age; }
```

### Pointer Types (unsafe context)
**your answer**
C# normally manages memory safely and doesn't expose raw pointers, but an `unsafe` context allows direct pointer manipulation (similar to C/C++) using `*` and `&`, typically for performance-critical or interop scenarios. Code using pointers must be marked `unsafe` and the project must allow unsafe code to compile.
```csharp
unsafe
{
    int x = 10;
    int* p = &x;
    Console.WriteLine(*p); // 10
}
```

### Structured Types
**your answer**
Structured types group multiple pieces of data together. This includes `struct` (a value-type grouping, good for small, lightweight data like a `Point`), `class` (a reference-type grouping), arrays, and tuples. `struct` is often used instead of `class` when the data is small, immutable-ish, and copy semantics are desirable.
```csharp
struct Point { public int X; public int Y; }
var p = new Point { X = 1, Y = 2 };
```

## Conversions
**your answer**
Conversion means changing a value from one type to another — for example, turning a `string` into an `int`, or a `double` into an `int`. C# supports this through implicit/explicit casting and through helper methods for more complex conversions (like parsing text).

### Implicit and Explicit
**your answer**
An **implicit conversion** happens automatically when there's no risk of data loss (e.g. `int` to `double`, since every int fits into a double). An **explicit conversion** (a cast) is required when data could be lost or the conversion could fail (e.g. `double` to `int`), and you must write the cast yourself using `(type)`.
```csharp
int i = 10;
double d = i;           // implicit — safe, no data loss
double d2 = 9.7;
int i2 = (int)d2;        // explicit cast — truncates to 9, must be written explicitly
```

### Conversion Helpers (Parse & Convert)
**your answer**
For conversions that casting can't handle — like turning a `string` into a numeric type — C# provides:
- **`Parse` / `TryParse`** — e.g. `int.Parse("42")` converts a string to an int, throwing an exception if the string is invalid; `int.TryParse("42", out int result)` does the same but returns `false` instead of throwing, which is safer for user input.
- **`Convert` class** — e.g. `Convert.ToInt32(value)` converts between a wide range of types, and unlike `Parse`, it gracefully handles `null` (returning 0) instead of throwing.
```csharp
int a = int.Parse("42");
bool ok = int.TryParse("abc", out int b); // ok = false, b = 0
int c = Convert.ToInt32("42");
```
