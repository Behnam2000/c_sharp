# C# Introduction

## Variables

**your answer**

A **variable** is a named storage location in memory that holds a value. In C#, every variable has a **type** (which determines what kind of data it can hold), a **name** (identifier), and a **value**. Variables are the building blocks of any program — they allow you to store, retrieve, and manipulate data.

C# is a **statically typed** language, which means the type of every variable must be known at compile time. This gives you strong type safety, catching many bugs before your program even runs.

**Key rules for variable names:**
- Must start with a letter or underscore (`_`)
- Can contain letters, digits, and underscores
- Cannot be a C# reserved keyword (e.g., `class`, `int`, `return`)
- Case-sensitive: `name` and `Name` are different variables
- Use **camelCase** for local variables and parameters (e.g., `firstName`, `totalAmount`)

```csharp
int age = 25;
string name = "Alice";
double price = 19.99;
bool isActive = true;
```

---

### Declaring & Assigning

**your answer**

**Declaring** a variable means telling the compiler its name and type. **Assigning** means giving it a value.

```csharp
// Declaration only (variable exists but has no value yet)
int score;

// Assignment (giving it a value)
score = 100;

// Declaration + Assignment in one line
int score = 100;

// Multiple declarations
int a, b, c;
a = 1; b = 2; c = 3;

// Multiple declarations with initialization
int x = 10, y = 20, z = 30;
```

**Important:** In C#, you cannot use a local variable before it has been assigned a value. The compiler enforces this — it is a compile-time error, not a runtime crash.

```csharp
int number;
Console.WriteLine(number);  // ERROR: Use of unassigned local variable 'number'
```

**Field variables** (class-level variables) are different — if not explicitly initialized, they get a **default value** (`0` for numbers, `null` for reference types, `false` for booleans).

---

### Initialize

**your answer**

**Initialization** is the process of giving a variable its first value at the time of declaration. It is the safest and most readable practice.

```csharp
// Good: Initialize at declaration
int count = 0;
string message = "Hello";
double taxRate = 0.07;
bool isReady = false;

// Arrays: initialize with values
int[] numbers = { 1, 2, 3, 4, 5 };
string[] names = new string[] { "Alice", "Bob", "Carol" };

// Objects: initialize with a constructor
DateTime today = new DateTime(2024, 6, 15);
List<int> scores = new List<int> { 90, 85, 95 };
```

**Why initialize?**
- Prevents compile-time errors from using unassigned variables
- Makes your code's intent clear to other developers
- Avoids subtle bugs from default values
- Enables the compiler to perform better optimizations

**Default values for types:**

| Type | Default Value |
|------|---------------|
| `int`, `long`, `short`, `byte` | `0` |
| `float`, `double`, `decimal` | `0.0` |
| `bool` | `false` |
| `char` | `'\0'` (null character) |
| `string` (reference type) | `null` |
| Any class/object | `null` |

---

### Implicit and Explicitly typed variables

**your answer**

C# offers two ways to declare variables: **explicit typing** (you write the type) and **implicit typing** (the compiler infers the type).

### Explicit Typing
You declare the type explicitly. This is the traditional, most readable approach.

```csharp
int age = 25;
string name = "Alice";
List<int> scores = new List<int>();
Dictionary<string, int> map = new Dictionary<string, int>();
```

### Implicit Typing (`var`) — Recommended for obvious types
The compiler determines the type from the right-hand side of the assignment. The variable is still **strongly typed** — the type is just inferred.

```csharp
var age = 25;           // Compiler infers: int
var name = "Alice";     // Compiler infers: string
var price = 19.99;      // Compiler infers: double
var today = DateTime.Now;  // Compiler infers: DateTime
```

**Rules for `var`:**
- Must be initialized at declaration (the compiler needs a value to infer the type)
- Cannot be used for fields (class-level variables)
- Cannot be used when the type is `null` (compiler cannot infer)
- The variable is not dynamic — it has a fixed compile-time type

```csharp
var x;           // ERROR: Implicitly-typed variables must be initialized
var y = null;    // ERROR: Cannot assign null to an implicitly-typed variable
```

**When to use `var` vs explicit types:**

| Use `var` | Use explicit type |
|-----------|-------------------|
| The type is obvious from the right side | The type is unclear from context |
| Long generic types (`Dictionary<string, List<int>>`) | Working with numeric types where precision matters |
| LINQ queries | Public APIs or method signatures |
| Anonymous types (required) | When you want to emphasize the type for readability |

**Best Practice:** Use `var` when the type is obvious from the initializer. Use explicit types when the type adds important context.

---

### char Datatype

**your answer**

The `char` type represents a **single Unicode character**. It is a value type that occupies **2 bytes** (16 bits) and can store any character from the Unicode character set (U+0000 to U+FFFF).

```csharp
char grade = 'A';
char symbol = '$';
char digit = '7';       // Note: '7' is a char, 7 is an int
char newline = '\n';
char tab = '\t';
```

**Important:** `char` literals use **single quotes** (`'A'`). Double quotes (`"A"`) create a `string`, not a `char`.

**Common escape sequences:**

| Escape | Meaning |
|--------|---------|
| `\'` | Single quote |
| `\"` | Double quote |
| `\\` | Backslash |
| `\n` | Newline |
| `\r` | Carriage return |
| `\t` | Tab |
| `\b` | Backspace |
| `\0` | Null character |
| `\u0041` | Unicode character (hex) — e.g., 'A' |

```csharp
char copyright = '\u00A9';   // ©
char heart = '\u2665';       // ♥
```

**Converting between `char` and `int`:**
```csharp
char letter = 'A';
int code = letter;           // Implicit: 65 (Unicode code point)
char back = (char)65;        // Explicit: 'A'

// Check character properties
char c = '5';
bool isDigit = char.IsDigit(c);      // true
bool isLetter = char.IsLetter(c);      // false
bool isUpper = char.IsUpper('A');      // true
char lower = char.ToLower('A');        // 'a'
```

---

### String Manipulation with String Formmating

**your answer**

A `string` in C# is a **sequence of characters** (an array of `char`). Strings are **immutable** — once created, they cannot be changed. Any modification creates a new string.

### String Declaration
```csharp
string greeting = "Hello, World!";
string path = @"C:\Users\Alice\Documents";  // Verbatim string (no escape needed)
string multiLine = """
    This is a
    multi-line string
    using raw string literals (C# 11+)
    """;
```

### String Formatting Techniques

**1. String Concatenation (`+`)**
```csharp
string fullName = firstName + " " + lastName;
string message = "Score: " + score;   // score is converted to string automatically
```

**2. String Interpolation (`$"..."`) — Recommended**
```csharp
string name = "Alice";
int age = 30;
string message = $"Hello, {name}! You are {age} years old.";
// Result: "Hello, Alice! You are 30 years old."

// With expressions
string result = $"Next year you'll be {age + 1}.";
string formatted = $"Price: {price:C2}";   // Currency with 2 decimals
```

**3. `string.Format()`**
```csharp
string message = string.Format("Hello, {0}! You are {1} years old.", name, age);
// {0} = first argument, {1} = second argument
```

**4. Format Specifiers**

| Specifier | Example | Result |
|-----------|---------|--------|
| `C` or `c` | `{1234.5:C}` | `$1,234.50` (currency) |
| `N` or `n` | `{1234567:N}` | `1,234,567.00` (number with separators) |
| `F` or `f` | `{3.14159:F2}` | `3.14` (fixed-point) |
| `P` or `p` | `{0.85:P}` | `85.00%` (percentage) |
| `D` or `d` | `{42:D5}` | `00042` (decimal with padding) |
| `X` or `x` | `{255:X}` | `FF` (hexadecimal) |

```csharp
double price = 1234.567;
Console.WriteLine($"{price:C}");      // $1,234.57
Console.WriteLine($"{price:F2}");     // 1234.57
Console.WriteLine($"{price:N}");      // 1,234.57

DateTime now = DateTime.Now;
Console.WriteLine($"{now:yyyy-MM-dd HH:mm:ss}");  // 2024-06-15 14:30:45
```

**5. `StringBuilder` for Heavy Manipulation**
```csharp
// Bad: Creates many intermediate strings
string result = "";
for (int i = 0; i < 1000; i++)
    result += i.ToString();

// Good: Uses a mutable buffer
var sb = new StringBuilder();
for (int i = 0; i < 1000; i++)
    sb.Append(i);
string result = sb.ToString();
```

---

## Operators and Order of Evaluation

**your answer**

Operators are symbols that perform operations on operands (variables, literals, or expressions). C# provides a rich set of operators, and understanding their **precedence** (evaluation order) is critical for writing correct expressions.

### Operator Categories

| Category | Operators | Description |
|----------|-----------|-------------|
| Arithmetic | `+`, `-`, `*`, `/`, `%` | Math operations |
| Assignment | `=`, `+=`, `-=`, `*=`, `/=`, `%=` | Assign and combine |
| Comparison | `==`, `!=`, `<`, `>`, `<=`, `>=` | Compare values |
| Logical | `&&`, `\|\|`, `!` | Boolean logic |
| Bitwise | `&`, `\|`, `^`, `~`, `<<`, `>>` | Work on bits |
| Unary | `++`, `--`, `+`, `-`, `!` | Single operand |
| Ternary | `?:` | Conditional expression |
| Null-coalescing | `??`, `??=` | Handle null values |
| Member access | `.`, `?.`, `?[]` | Access members safely |

### Operator Precedence (Highest to Lowest)

1. `()` — Parentheses (override everything)
2. `++`, `--` (postfix), `.`, `?.`, `?[]`, `()`, `[]`
3. `++`, `--` (prefix), `+`, `-` (unary), `!`, `~`
4. `*`, `/`, `%`
5. `+`, `-` (binary)
6. `<<`, `>>`
7. `<`, `>`, `<=`, `>=`, `is`, `as`
8. `==`, `!=`
9. `&` (bitwise AND)
10. `^` (bitwise XOR)
11. `|` (bitwise OR)
12. `&&` (logical AND)
13. `||` (logical OR)
14. `??` (null-coalescing)
15. `?:` (ternary)
16. `=`, `+=`, `-=`, etc. (assignment)

### Examples

```csharp
int result = 5 + 3 * 2;       // 11, not 16 (multiplication first)
int result2 = (5 + 3) * 2;    // 16 (parentheses override)

bool check = true || false && false;   // true (&& before ||)
bool check2 = (true || false) && false; // false

// Increment operators
int a = 5;
int b = a++;    // b = 5, then a becomes 6 (postfix)
int c = ++a;    // a becomes 7, then c = 7 (prefix)

// Compound assignment
int x = 10;
x += 5;         // x = x + 5 → 15
x *= 2;         // x = x * 2 → 30

// Ternary operator
string status = (age >= 18) ? "Adult" : "Minor";

// Null-coalescing
string name = input ?? "Default";   // Use input if not null, else "Default"
name ??= "Default";                  // Assign only if name is null
```

**Best Practice:** Always use parentheses in complex expressions. Code clarity is more important than saving a few keystrokes.

---

## Data Types in C#

**your answer**

C# is a **type-safe** language where every variable and expression has a type. The .NET type system is unified under `System.Object`, but types are broadly categorized into **value types** and **reference types**.

```
System.Object
├── Value Types (stored on stack or inline)
│   ├── Simple/Primitive Types
│   │   ├── Integral: byte, sbyte, short, ushort, int, uint, long, ulong
│   │   ├── Floating-point: float, double, decimal
│   │   ├── Unicode characters: char
│   │   └── Boolean: bool
│   ├── Enum Types
│   └── Struct Types
│       └── User-defined structs
│       └── Built-in structs: DateTime, TimeSpan, Guid
└── Reference Types (stored on heap, reference on stack)
    ├── Class Types
    │   ├── Ultimate base: object
    │   ├── Unicode strings: string
    │   └── User-defined classes
    ├── Interface Types
    ├── Array Types
    └── Delegate Types
```

---

### Value Types

**your answer**

**Value types** store their data **directly** in the memory location where the variable is allocated. When you assign a value type to another variable, a **complete copy** of the data is made.

**Where stored:** Typically on the **stack** (for local variables) or inline within objects (for fields). This makes them efficient for small, frequently-used data.

**Built-in Value Types:**

| Type | Size | Range | Example |
|------|------|-------|---------|
| `byte` | 1 byte | 0 to 255 | `byte flags = 0xFF;` |
| `sbyte` | 1 byte | -128 to 127 | `sbyte temp = -10;` |
| `short` | 2 bytes | -32,768 to 32,767 | `short count = 1000;` |
| `ushort` | 2 bytes | 0 to 65,535 | `ushort port = 8080;` |
| `int` | 4 bytes | -2.1B to 2.1B | `int age = 25;` |
| `uint` | 4 bytes | 0 to 4.3B | `uint id = 1;` |
| `long` | 8 bytes | -9 quintillion | `long big = 9_000_000_000L;` |
| `ulong` | 8 bytes | 0 to 18 quintillion | `ulong huge = 1UL;` |
| `float` | 4 bytes | ~7 digits precision | `float pi = 3.14f;` |
| `double` | 8 bytes | ~15 digits precision | `double precise = 3.14159;` |
| `decimal` | 16 bytes | ~28 digits precision | `decimal money = 99.99m;` |
| `char` | 2 bytes | Unicode U+0000 to U+FFFF | `char grade = 'A';` |
| `bool` | 1 byte | `true` or `false` | `bool active = true;` |

**Key characteristics:**
- Cannot be `null` (unless declared as nullable: `int?`)
- Assignment copies the entire value
- Passed to methods by **value** (a copy is made)
- Have a default value if not initialized

```csharp
int a = 10;
int b = a;      // b gets a COPY of 10
b = 20;         // a is still 10

Point p1 = new Point { X = 5, Y = 10 };
Point p2 = p1;  // p2 gets a complete copy
p2.X = 100;     // p1.X is still 5
```

---

### Reference Types

**your answer**

**Reference types** store a **reference** (memory address) to the actual data, which lives on the **managed heap**. When you assign a reference type to another variable, only the **reference** is copied — both variables point to the **same object** in memory.

**Common Reference Types:**

| Type | Description |
|------|-------------|
| `class` | User-defined reference types |
| `string` | Immutable sequence of characters |
| `object` | Base type of all types in C# |
| `array` | Fixed-size collection of elements |
| `interface` | Contract that classes can implement |
| `delegate` | Type-safe function pointer |

```csharp
// Reference type behavior
Person person1 = new Person { Name = "Alice" };
Person person2 = person1;   // person2 references the SAME object

person2.Name = "Bob";       // Changes the object both variables point to
Console.WriteLine(person1.Name);  // "Bob" — person1 sees the change!
```

**Key characteristics:**
- Can be `null` (reference to nothing)
- Assignment copies the reference, not the data
- Passed to methods by **reference** to the reference (modifications affect the original)
- Memory is managed by the **Garbage Collector (GC)**
- Default value is `null`

```csharp
string s1 = "Hello";
string s2 = s1;
s2 = "World";    // s1 is still "Hello" because strings are immutable!
// s2 now points to a new string object, s1 still points to "Hello"
```

---

- Value vs Referece Type: **your answer**

Understanding the difference between value and reference types is fundamental to writing correct C# code. Here's a comprehensive comparison:

| Aspect | Value Type | Reference Type |
|--------|-----------|----------------|
| **Storage** | Data stored directly | Reference stored; data on heap |
| **Memory** | Stack (usually) or inline | Heap |
| **Assignment** | Copies the entire value | Copies only the reference |
| **Default** | Zero-equivalent (`0`, `false`, `'\0'`) | `null` |
| **Nullability** | Cannot be `null` (unless `Nullable<T>`) | Can be `null` |
| **Inheritance** | Implicitly sealed (cannot inherit) | Can inherit and be inherited |
| **Passed to methods** | By value (copy) | By reference to reference |
| **Lifetime** | Method scope or containing object | Managed by Garbage Collector |
| **Examples** | `int`, `double`, `bool`, `struct`, `enum` | `class`, `string`, `array`, `interface` |

**Visual comparison:**

```
Value Type Assignment:          Reference Type Assignment:
┌─────────┐                     ┌─────────┐      ┌─────────────┐
│   a: 10 │                     │   a: ───┼────→ │ Name: Alice │
├─────────┤                     ├─────────┤      └─────────────┘
│   b: 10 │ ← copy            │   b: ───┘      (same object!)
└─────────┘                     └─────────┘
```

**Practical Example:**
```csharp
// Value type
void Increment(int x) { x++; }
int num = 5;
Increment(num);
Console.WriteLine(num);  // Still 5 — a copy was modified

// Reference type
void Rename(Person p) { p.Name = "Changed"; }
Person person = new Person { Name = "Alice" };
Rename(person);
Console.WriteLine(person.Name);  // "Changed" — original object modified

// To modify a value type in a method, use 'ref' or 'out'
void IncrementRef(ref int x) { x++; }
IncrementRef(ref num);
Console.WriteLine(num);  // Now 6
```

**When to choose which:**
- Use **value types** for small, immutable data (coordinates, colors, money amounts with `decimal`)
- Use **reference types** for complex objects, large data structures, or when you need inheritance/polymorphism
- A good rule of thumb: if your struct is larger than 16 bytes, consider making it a class

---

### Nullable Types

**your answer**

In C#, value types cannot be `null` by default. **Nullable types** allow value types to represent missing or undefined values by adding `null` as a possible state.

**Declaring nullable types:**
```csharp
int? age = null;           // Nullable int
bool? isActive = null;     // Nullable bool (true, false, or null)
double? temperature = 98.6; // Nullable double
DateTime? birthDate = null; // Nullable DateTime
```

**Syntax:** `T?` is shorthand for `Nullable<T>`, a built-in generic struct.
```csharp
int? x = null;           // Same as: Nullable<int> x = null;
```

**Checking for null:**
```csharp
int? score = GetScore();

if (score.HasValue)              // Check if it has a value
    Console.WriteLine(score.Value);  // Access the value (throws if null)

if (score != null)               // Same check, more idiomatic
    Console.WriteLine(score.Value);
```

**Null-coalescing operator (`??`):**
```csharp
int? input = null;
int result = input ?? 0;         // If input is null, use 0
Console.WriteLine(result);       // 0

string name = GetName() ?? "Anonymous";  // Use default if null
```

**Null-conditional operator (`?.`) with nullable types:**
```csharp
int? length = name?.Length;      // If name is null, length is null (not exception)
```

**Null-forgiving operator (`!`):**
```csharp
string text = GetText()!;        // Tell compiler "trust me, this isn't null"
```

**Why nullable types matter:**
- Databases often have nullable columns
- User input may be missing
- Configuration values may be optional
- APIs may return optional fields

**C# 8.0+ Nullable Reference Types:**
```csharp
#nullable enable
string name = null;     // Warning! Non-nullable string assigned null
string? name = null;    // OK — explicitly nullable reference type
```

---

### User Defined Types

**your answer**

C# allows developers to create their own types using **`class`**, **`struct`**, **`enum`**, **`interface`**, and **`record`**. These are called **user-defined types** and are the foundation of object-oriented programming in C#.

### Classes (Reference Types)
```csharp
public class Person
{
    // Fields
    private int age;

    // Properties
    public string Name { get; set; }
    public int Age 
    { 
        get { return age; }
        set { age = value; }
    }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        this.age = age;
    }

    // Method
    public void Greet()
    {
        Console.WriteLine($"Hello, I'm {Name}!");
    }
}

// Usage
Person alice = new Person("Alice", 30);
alice.Greet();
```

### Structs (Value Types)
```csharp
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double DistanceToOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

// Usage
Point p = new Point(3, 4);
Console.WriteLine(p.DistanceToOrigin());  // 5
```

### Enums
```csharp
public enum Status
{
    Pending,      // 0
    Approved,     // 1
    Rejected      // 2
}

public enum Priority : byte  // Can specify underlying type
{
    Low = 1,
    Medium = 2,
    High = 3
}

// Usage
Status current = Status.Approved;
if (current == Status.Approved)
    Console.WriteLine("Approved!");
```

### Records (C# 9.0+)
Immutable reference types with value-based equality:
```csharp
public record Person(string Name, int Age);

var p1 = new Person("Alice", 30);
var p2 = new Person("Alice", 30);
Console.WriteLine(p1 == p2);  // true (value equality, not reference equality!)
```

### Interfaces
```csharp
public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
```

---

### Pointer Types (unsafe context)

**your answer**

C# is a **managed language** — memory is automatically managed by the Garbage Collector (GC). However, C# also supports **pointer types** for direct memory manipulation, but only within an **`unsafe` context**.

**When to use pointers:**
- Interoperability with native/C libraries (P/Invoke)
- High-performance scenarios (image processing, game engines)
- Direct memory access for performance-critical code

**Enabling unsafe code:**
In your `.csproj` file:
```xml
<PropertyGroup>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
</PropertyGroup>
```

**Basic pointer syntax:**
```csharp
unsafe
{
    int number = 42;
    int* ptr = &number;    // & gets the address
    
    Console.WriteLine($"Value: {number}");      // 42
    Console.WriteLine($"Address: {(long)ptr:X}"); // Memory address
    Console.WriteLine($"Dereferenced: {*ptr}");  // 42 ( * dereferences )
    
    *ptr = 100;            // Modify through pointer
    Console.WriteLine(number);  // 100
}
```

**Pointers with arrays:**
```csharp
unsafe
{
    int[] numbers = { 10, 20, 30, 40, 50 };
    
    fixed (int* ptr = numbers)  // Pin array in memory (GC cannot move it)
    {
        Console.WriteLine(ptr[0]);   // 10
        Console.WriteLine(*(ptr + 2)); // 30 (pointer arithmetic)
    }
}
```

**Pointer arithmetic:**
```csharp
unsafe
{
    int* ptr = ...;
    ptr++;        // Moves forward by sizeof(int) bytes (4 bytes)
    ptr += 3;     // Moves forward by 3 * sizeof(int) bytes
}
```

**⚠️ Dangers of unsafe code:**
- Memory corruption (writing to wrong addresses)
- Buffer overflows
- Security vulnerabilities
- Code that bypasses type safety

**Best Practice:** Avoid `unsafe` code unless absolutely necessary. For most applications, managed code is safer, more maintainable, and performant enough.

---

### Structured Types

**your answer**

**Structured types** (also called **composite types**) are types composed of multiple members. In C#, these primarily include **`struct`** and **`class`**, but the term also encompasses tuples and records.

### Structs vs Classes Recap

| Feature | `struct` | `class` |
|---------|----------|---------|
| Type | Value type | Reference type |
| Inheritance | Can implement interfaces, cannot inherit | Can inherit and be inherited |
| Default constructor | Always provided (parameterless) | Must define explicitly |
| Parameterless constructor | Cannot define custom one (C# 10+ allows it) | Can define custom one |
| Instantiation | Can use without `new` (but fields unassigned) | Requires `new` |
| Mutability | Prefer immutable | Can be mutable or immutable |
| Size | Keep small (< 16 bytes recommended) | No size restriction |
| Use case | Simple data structures (Point, Color, Rectangle) | Complex objects with behavior |

### Tuples (Lightweight Structured Types)
```csharp
// ValueTuple — lightweight, no need to declare a type
(string, int) person = ("Alice", 30);
Console.WriteLine(person.Item1);  // Alice
Console.WriteLine(person.Item2);  // 30

// Named tuple elements
(string Name, int Age) person2 = ("Bob", 25);
Console.WriteLine(person2.Name);  // Bob

// Tuple deconstruction
var (name, age) = person2;
Console.WriteLine($"{name} is {age}");

// Returning multiple values from a method
(string Name, int Age) GetPerson() => ("Alice", 30);
```

### Records (Immutable Structured Types)
```csharp
// Positional record (concise)
public record Person(string Name, int Age);

// Record with body
public record Point
{
    public int X { get; init; }  // init-only: set during initialization only
    public int Y { get; init; }
}

// Record struct (C# 10+)
public record struct Point2D(int X, int Y);
```

**Records provide:**
- Value-based equality (two records with same data are equal)
- Built-in `ToString()`, `GetHashCode()`, `Equals()`
- Immutability by default (`init` properties)
- Non-destructive mutation with `with` expressions:
```csharp
var p1 = new Person("Alice", 30);
var p2 = p1 with { Age = 31 };  // Creates copy with Age changed
```

---

## Conversions

**your answer**

**Type conversion** (or type casting) is the process of changing a value from one data type to another. C# provides several mechanisms for conversion, each with different safety guarantees.

### Categories of Conversions

| Conversion | Description | Example |
|------------|-------------|---------|
| **Implicit** | Automatic, safe, no data loss | `int` → `long` |
| **Explicit** | Requires cast operator, may lose data | `double` → `int` |
| **Parse** | String → numeric type | `"123"` → `123` |
| **Convert** | General-purpose conversion | `Convert.ToInt32("123")` |
| **Boxing/Unboxing** | Value type ↔ `object` | `int` → `object` → `int` |

---

### Implicit and Explicit

**your answer**

### Implicit Conversions
Implicit conversions happen **automatically** when the compiler can guarantee no data will be lost. They are **safe** and require no special syntax.

**Rules for implicit conversion:**
- No loss of magnitude (smaller type → larger type)
- No loss of precision (integral → floating-point)
- Reference type → base class or interface it implements

```csharp
// Numeric widening
int i = 100;
long l = i;          // int → long (safe, 4 bytes → 8 bytes)
float f = i;         // int → float (safe)
double d = f;        // float → double (safe)
decimal m = i;       // int → decimal (safe)

// Reference type upcasting
string s = "Hello";
object o = s;        // string → object (every string IS an object)

// Custom implicit conversion (in user-defined types)
public struct Celsius
{
    public double Temperature { get; set; }
    
    public static implicit operator Celsius(double temp)
    {
        return new Celsius { Temperature = temp };
    }
}

Celsius c = 36.6;    // Implicit conversion from double
```

### Explicit Conversions (Casting)
Explicit conversions require a **cast operator** `(Type)` because they may result in data loss or exceptions. You are telling the compiler "I know what I'm doing."

```csharp
// Numeric narrowing (potential data loss)
double d = 123.99;
int i = (int)d;      // Explicit cast: i = 123 (decimal part truncated!)

long l = 10_000_000_000L;
int j = (int)l;      // Explicit cast: may overflow (wrap around)

// Reference type downcasting (may fail at runtime)
object o = "Hello";
string s = (string)o;     // OK — o really is a string

object num = 42;
string bad = (string)num; // COMPILE-TIME OK, but RUNTIME ERROR: InvalidCastException
```

**Safe downcasting with `as` and `is`:**
```csharp
object obj = "Hello";

// 'as' returns null if cast fails (no exception)
string str = obj as string;        // str = "Hello"
int? num = obj as int?;            // num = null (not an int)

// 'is' checks type before casting
if (obj is string text)
{
    Console.WriteLine(text.Length);  // 'text' is safely casted string
}
```

**Custom explicit conversion:**
```csharp
public struct Fahrenheit
{
    public double Temperature { get; set; }
    
    public static explicit operator Celsius(Fahrenheit f)
    {
        return new Celsius { Temperature = (f.Temperature - 32) * 5 / 9 };
    }
}

Fahrenheit f = new Fahrenheit { Temperature = 98.6 };
Celsius c = (Celsius)f;   // Explicit cast required
```

---

### Conversion Helpers (Parse & Convert)

**your answer**

When converting **strings** to numeric types or between disparate types, C# provides helper classes: `Parse`, `TryParse`, and `Convert`.

### `Parse` — String to Type
Converts a string representation to its equivalent type. **Throws an exception** if the string is invalid.

```csharp
string input = "123";
int number = int.Parse(input);          // 123
double price = double.Parse("19.99");   // 19.99
bool flag = bool.Parse("true");         // true
DateTime date = DateTime.Parse("2024-06-15");

// With format providers (culture-specific)
double euro = double.Parse("1.234,56", new CultureInfo("de-DE"));  // German format

// NumberStyles for more control
int hex = int.Parse("FF", NumberStyles.HexNumber);  // 255
```

**⚠️ Danger:** `Parse` throws `FormatException` if the input is invalid.
```csharp
int bad = int.Parse("abc");  // FormatException!
int empty = int.Parse(null);  // ArgumentNullException!
```

### `TryParse` — Safe Parsing (Preferred)
Attempts to parse and returns a `bool` indicating success. **Never throws** an exception for invalid input.

```csharp
string input = "123";

if (int.TryParse(input, out int result))
{
    Console.WriteLine($"Parsed: {result}");
}
else
{
    Console.WriteLine("Invalid number");
}

// Modern C# syntax (discards, inline variable declaration)
if (int.TryParse(input, out var number))
    Console.WriteLine(number);

// Using discard if you only care about success
if (int.TryParse(input, out _))
    Console.WriteLine("Valid number");
```

**Always prefer `TryParse` over `Parse` when handling user input or external data.**

### `Convert` Class — General-Purpose Conversion
The `Convert` class provides methods to convert between **any** base types. It handles `null` gracefully (returns default values) and supports conversions that `Parse` cannot.

```csharp
// String to numeric
int i = Convert.ToInt32("123");        // 123
int fromBool = Convert.ToInt32(true);  // 1
int fromDouble = Convert.ToInt32(3.99); // 3 (rounds!)

// Null handling (returns default instead of throwing)
int fromNull = Convert.ToInt32(null);  // 0
string fromNullStr = Convert.ToString(null); // "" (empty string)

// Base conversions
string binary = Convert.ToString(42, 2);   // "101010"
int fromBinary = Convert.ToInt32("101010", 2); // 42
string hex = Convert.ToString(255, 16);     // "ff"

// Type conversions
string str = Convert.ToString(123);       // "123"
double d = Convert.ToDouble("3.14");      // 3.14
bool b = Convert.ToBoolean(1);            // true
bool b2 = Convert.ToBoolean(0);           // false
char c = Convert.ToChar(65);              // 'A'
byte[] bytes = Convert.FromBase64String("SGVsbG8="); // "Hello"
```

**`Convert` vs `Parse` vs `TryParse`:**

| Scenario | Use |
|----------|-----|
| String → number, trusted input | `Parse` |
| String → number, user/external input | `TryParse` |
| Any type → any type, including null | `Convert` |
| Need culture-specific parsing | `Parse` with `IFormatProvider` |
| Need hex/binary/octal parsing | `Convert.ToInt32(string, base)` |

### `ToString()` — Type to String
Every object in C# has a `ToString()` method. Value types and most reference types override it for meaningful output.

```csharp
int num = 42;
string s = num.ToString();           // "42"

// With formatting
string currency = 1234.5.ToString("C");     // "$1,234.50"
string percent = 0.856.ToString("P1");    // "85.6%"
string hex = 255.ToString("X");            // "FF"

// DateTime formatting
DateTime now = DateTime.Now;
string formatted = now.ToString("yyyy-MM-dd HH:mm:ss");  // "2024-06-15 14:30:00"
```