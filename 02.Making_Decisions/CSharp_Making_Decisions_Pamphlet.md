# C# Making Decisions — Masterclass Pamphlet

> *"Programs must make choices. A program without decisions is just a calculator."*

This pamphlet covers the essential tools C# provides for controlling the flow of execution based on conditions. From simple comparisons to complex branching logic, mastering these constructs is the gateway to writing intelligent, responsive applications.

---

## 1. Logical Operators

Logical operators allow you to combine multiple boolean expressions into a single condition. They are the glue that holds complex decision-making together.

| Operator | Name | Description | Example |
|----------|------|-------------|---------|
| `&&` | Conditional AND | Returns `true` if **both** operands are true. Short-circuits (stops evaluating if the first is false). | `a > 5 && b < 10` |
| `\|\|` | Conditional OR | Returns `true` if **at least one** operand is true. Short-circuits (stops evaluating if the first is true). | `a > 5 \|\| b < 10` |
| `!` | Logical NOT | Inverts the boolean value. Turns `true` into `false` and vice versa. | `!(a > 5)` |
| `&` | Logical AND | Returns `true` if both operands are true. **Does not** short-circuit. | `a > 5 & b < 10` |
| `\|` | Logical OR | Returns `true` if at least one operand is true. **Does not** short-circuit. | `a > 5 \| b < 10` |
| `^` | Logical XOR | Returns `true` if **exactly one** operand is true (exclusive OR). | `a > 5 ^ b < 10` |

### 1.1 Variants of OR Statements

The OR operator comes in two flavors in C#, and understanding the difference is critical for both correctness and performance.

#### Conditional OR (`||`)

```csharp
int speed = 120;
int fuel = 5;

if (speed > 100 || fuel > 10)
{
    Console.WriteLine("Warning condition met.");
}
```

**Short-circuit behavior:** If `speed > 100` evaluates to `true`, the runtime **does not evaluate** `fuel > 10`. This is efficient when the second condition is expensive (e.g., a database call or complex calculation).

#### Logical OR (`|`)

```csharp
bool a = true;
bool b = false;

if (a | b)
{
    Console.WriteLine("At least one is true.");
}
```

**Non-short-circuit behavior:** Both sides are **always** evaluated, regardless of the first operand's value. This is rarely needed for boolean logic but is essential when the side effects of the second expression are intentional.

**Practical Example:**

```csharp
bool LogAndCheck(bool condition, string message)
{
    Console.WriteLine(message);
    return condition;
}

// Using | ensures both log messages appear
if (LogAndCheck(false, "Checking A...") | LogAndCheck(true, "Checking B..."))
{
    Console.WriteLine("Overall result: true");
}
// Output: Checking A...
Checking B...
Overall result: true
```

> **Best Practice:** Use `||` for boolean logic. Reserve `|` for bitwise operations or when you explicitly need both sides evaluated.

### 1.2 Variants of AND Statements

Just like OR, AND has both a conditional and a logical variant.

#### Conditional AND (`&&`)

```csharp
int age = 17;
bool hasLicense = true;

if (age >= 18 && hasLicense)
{
    Console.WriteLine("You can drive.");
}
else
{
    Console.WriteLine("You cannot drive.");
}
```

**Short-circuit behavior:** If `age >= 18` is `false`, `hasLicense` is never checked. This prevents errors like null-reference exceptions:

```csharp
string name = null;

// Safe: name?.Length is never evaluated because name != null is false
if (name != null && name.Length > 5)
{
    Console.WriteLine("Long name!");
}
```

#### Logical AND (`&`)

```csharp
bool x = true;
bool y = false;

if (x & y)
{
    Console.WriteLine("Both are true.");
}
```

**Non-short-circuit behavior:** Both operands are always evaluated. Like `|`, this is primarily useful when side effects are desired or for bitwise operations on integers.

**Bitwise AND Example:**

```csharp
int flags = 0b1010;  // Binary: 1010
int mask  = 0b1000;  // Binary: 1000

int result = flags & mask;  // Binary: 1000 (decimal: 8)
Console.WriteLine(result);  // Output: 8
```

> **Best Practice:** Use `&&` for boolean conditions. Use `&` for bitmasking and integer bitwise operations.

---

## 2. Relational Operators

Relational operators compare two values and return a boolean result. They form the foundation of almost every conditional statement.

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `>` | Greater than | `10 > 5` | `true` |
| `<` | Less than | `10 < 5` | `false` |
| `>=` | Greater than or equal to | `5 >= 5` | `true` |
| `<=` | Less than or equal to | `5 <= 4` | `false` |

### Basic Usage

```csharp
int temperature = 35;

if (temperature > 30)
{
    Console.WriteLine("It's hot outside!");
}
else if (temperature >= 20 && temperature <= 30)
{
    Console.WriteLine("The weather is pleasant.");
}
else
{
    Console.WriteLine("It's cold.");
}
```

### Chaining Relational Operators

C# does **not** support mathematical chaining like `5 < x < 10`. You must use logical operators:

```csharp
int x = 7;

// ❌ WRONG: This causes a compile-time error
// if (5 < x < 10)

// ✅ CORRECT: Use logical AND
if (x > 5 && x < 10)
{
    Console.WriteLine("x is between 5 and 10.");
}
```

### Comparing Strings

Relational operators work on strings using **lexicographical (dictionary) order** based on Unicode values:

```csharp
string a = "Apple";
string b = "Banana";

if (a.CompareTo(b) < 0)
{
    Console.WriteLine("Apple comes before Banana.");
}

// Or simply:
bool isBefore = a.CompareTo(b) < 0;
```

> **Note:** Direct use of `<` and `>` on strings is not allowed in C#. Use `CompareTo()` or `String.Compare()` instead.

### Comparing Floating-Point Numbers

Due to precision issues, avoid direct equality checks with `float` and `double`:

```csharp
double a = 0.1 + 0.2;
double b = 0.3;

// ❌ Risky: Might be false due to floating-point precision
if (a == b)

// ✅ Safer: Check if the difference is within a small tolerance (epsilon)
double epsilon = 1e-9;
if (Math.Abs(a - b) < epsilon)
{
    Console.WriteLine("Values are effectively equal.");
}
```

---

## 3. Equality Operators

Equality operators check whether two values are the same or different.

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `==` | Equal to | `5 == 5` | `true` |
| `!=` | Not equal to | `5 != 3` | `true` |

### Value Types vs. Reference Types

The behavior of `==` depends on whether you're comparing **value types** or **reference types**:

#### Value Types (struct, int, double, bool, etc.)

```csharp
int a = 10;
int b = 10;

if (a == b)
{
    Console.WriteLine("Values are equal.");  // ✅ Prints
}
```

For value types, `==` compares the actual data stored in the variables.

#### Reference Types (class, string, arrays, etc.)

```csharp
public class Person
{
    public string Name { get; set; }
}

Person p1 = new Person { Name = "Alice" };
Person p2 = new Person { Name = "Alice" };
Person p3 = p1;

// Comparing references (memory addresses)
Console.WriteLine(p1 == p2);  // false — different objects in memory
Console.WriteLine(p1 == p3);  // true  — same object in memory
```

#### Overriding Equality for Classes

To enable meaningful value comparison for your classes, override `Equals()` and `==`:

```csharp
public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public bool Equals(Person other)
    {
        if (other is null) return false;
        return Name == other.Name && Age == other.Age;
    }

    public override bool Equals(object obj) => Equals(obj as Person);
    public override int GetHashCode() => HashCode.Combine(Name, Age);

    public static bool operator ==(Person left, Person right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }

    public static bool operator !=(Person left, Person right) => !(left == right);
}
```

### The `!=` Operator

```csharp
string password = "secret123";

if (password != "admin")
{
    Console.WriteLine("Access denied. Invalid credentials.");
}
```

### Null Checks

```csharp
string userInput = Console.ReadLine();

if (userInput != null)
{
    Console.WriteLine($"You entered: {userInput}");
}

// Modern C# (8.0+) — pattern matching
if (userInput is not null)
{
    Console.WriteLine($"You entered: {userInput}");
}
```

---

## 4. One-Line `if` Statement

Also known as the **ternary operator** or **conditional operator**, this compact syntax lets you choose between two values based on a condition.

### Syntax

```csharp
condition ? expression_if_true : expression_if_false;
```

### Basic Examples

```csharp
int age = 20;
string status = age >= 18 ? "Adult" : "Minor";
Console.WriteLine(status);  // Output: Adult
```

```csharp
int score = 85;
string grade = score >= 90 ? "A" : score >= 80 ? "B" : "C";
Console.WriteLine(grade);  // Output: B
```

### Nested Ternary Operators

You can nest ternaries, but be careful — excessive nesting hurts readability:

```csharp
int temperature = 25;

// Readable enough with 2 levels
string advice = temperature > 30 ? "Stay hydrated" 
              : temperature > 20 ? "Enjoy the weather" 
              : "Wear a jacket";
```

### With Method Calls

```csharp
int balance = 100;
int withdrawal = 150;

// Only call Withdraw if there's enough balance
string result = balance >= withdrawal 
    ? Withdraw(withdrawal) 
    : "Insufficient funds";
```

### Ternary vs. `if-else`

| Aspect | Ternary `?:` | `if-else` |
|--------|-------------|-----------|
| Returns a value | ✅ Yes | ❌ No (unless you assign in each branch) |
| Can execute statements | ❌ No (expressions only) | ✅ Yes |
| Readability (simple) | ✅ Excellent | ⚠️ Verbose |
| Readability (complex) | ❌ Poor | ✅ Better |

> **Best Practice:** Use the ternary operator for simple value selection. Switch to `if-else` when you need multiple statements or the logic becomes complex.

---

## 5. Switch Statement

The `switch` statement provides a clean way to execute different blocks of code based on the value of an expression. It's often more readable than a long chain of `if-else if` statements.

### Basic Syntax

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    default:
        Console.WriteLine("Weekend!");
        break;
}
```

### Fall-Through Behavior

In C#, you **must** use `break` (or `return`, `throw`, `goto`) to exit a case. Fall-through is not allowed unless cases are empty:

```csharp
char grade = 'B';

switch (grade)
{
    case 'A':
    case 'B':
    case 'C':
        Console.WriteLine("You passed!");
        break;
    case 'D':
    case 'F':
        Console.WriteLine("You failed.");
        break;
    default:
        Console.WriteLine("Invalid grade.");
        break;
}
```

### Switch with Strings

```csharp
string command = "SAVE";

switch (command.ToUpper())
{
    case "OPEN":
        OpenFile();
        break;
    case "SAVE":
        SaveFile();
        break;
    case "EXIT":
        ExitApplication();
        break;
    default:
        Console.WriteLine("Unknown command.");
        break;
}
```

### Switch Expressions (C# 8.0+)

A modern, concise alternative that returns a value:

```csharp
int month = 4;

string season = month switch
{
    12 or 1 or 2  => "Winter",
    3 or 4 or 5   => "Spring",
    6 or 7 or 8   => "Summer",
    9 or 10 or 11 => "Autumn",
    _             => "Unknown"
};
```

### Pattern Matching in Switch (C# 7.0+)

```csharp
object value = 42;

switch (value)
{
    case int i when i > 0:
        Console.WriteLine($"Positive integer: {i}");
        break;
    case string s when s.Length > 5:
        Console.WriteLine($"Long string: {s}");
        break;
    case null:
        Console.WriteLine("Value is null.");
        break;
    default:
        Console.WriteLine("Something else.");
        break;
}
```

### When to Use Switch vs. If-Else

| Use `switch` when... | Use `if-else` when... |
|---------------------|----------------------|
| Comparing a single variable against multiple constant values | Conditions involve ranges or complex logic |
| Working with enums or discrete values | Multiple unrelated conditions |
| You want cleaner, more maintainable code | You need short-circuit evaluation |

---

## 6. Incrementing and Decrementing

Increment and decrement operators are shorthand for adding or subtracting 1 from a variable. They are among the most frequently used operators in loops and counters.

| Operator | Name | Description | Example |
|----------|------|-------------|---------|
| `++` | Increment | Adds 1 to the operand | `x++` or `++x` |
| `--` | Decrement | Subtracts 1 from the operand | `x--` or `--x` |

### 6.1 Incrementing and Pre-Incrementing

The placement of `++` matters! It determines whether the increment happens **before** or **after** the value is used.

#### Post-Increment (`x++`)

The current value is used first, then the variable is incremented.

```csharp
int x = 5;
int y = x++;  // y gets 5, then x becomes 6

Console.WriteLine(x);  // Output: 6
Console.WriteLine(y);  // Output: 5
```

**Step-by-step:**
1. `y` is assigned the current value of `x` (which is 5).
2. `x` is incremented to 6.

#### Pre-Increment (`++x`)

The variable is incremented first, then the new value is used.

```csharp
int x = 5;
int y = ++x;  // x becomes 6, then y gets 6

Console.WriteLine(x);  // Output: 6
Console.WriteLine(y);  // Output: 6
```

**Step-by-step:**
1. `x` is incremented to 6.
2. `y` is assigned the new value of `x` (which is 6).

#### In a Loop

```csharp
// Post-increment — standard for-loop pattern
for (int i = 0; i < 5; i++)
{
    Console.Write(i + " ");  // Output: 0 1 2 3 4
}

// Pre-increment — same output, slightly different timing
for (int i = 0; i < 5; ++i)
{
    Console.Write(i + " ");  // Output: 0 1 2 3 4
}
```

> **Note:** In standalone statements (`i++;` or `++i;`), there is no difference. Choose one style and be consistent.

#### Compound Assignment

```csharp
int score = 10;

score += 5;   // Same as: score = score + 5;  → 15
score *= 2;   // Same as: score = score * 2;   → 30
score -= 3;   // Same as: score = score - 3;   → 27
score /= 3;   // Same as: score = score / 3;   → 9
```

### 6.2 Decrementing and Modulo Operator

#### Post-Decrement (`x--`)

```csharp
int count = 10;
int result = count--;  // result gets 10, then count becomes 9

Console.WriteLine(count);   // Output: 9
Console.WriteLine(result);  // Output: 10
```

#### Pre-Decrement (`--x`)

```csharp
int count = 10;
int result = --count;  // count becomes 9, then result gets 9

Console.WriteLine(count);   // Output: 9
Console.WriteLine(result);  // Output: 9
```

#### Countdown Loop

```csharp
for (int countdown = 10; countdown > 0; countdown--)
{
    Console.WriteLine(countdown);
}
Console.WriteLine("Blast off!");
```

#### The Modulo Operator (`%`)

The modulo operator returns the **remainder** of a division. It's incredibly useful for cycling through values, checking divisibility, and implementing wrap-around logic.

```csharp
int remainder = 17 % 5;  // 17 divided by 5 is 3 with remainder 2
Console.WriteLine(remainder);  // Output: 2
```

**Checking Even/Odd:**

```csharp
int number = 42;

if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
```

**Cycling Through an Array:**

```csharp
string[] colors = { "Red", "Green", "Blue" };

for (int i = 0; i < 10; i++)
{
    string color = colors[i % colors.Length];
    Console.WriteLine($"Index {i}: {color}");
}
// Output cycles: Red, Green, Blue, Red, Green, Blue...
```

**Checking Divisibility:**

```csharp
int year = 2024;

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine("Leap year!");
}
```

**Extracting Digits:**

```csharp
int number = 1234;

while (number > 0)
{
    int digit = number % 10;  // Get last digit
    Console.WriteLine(digit);
    number /= 10;             // Remove last digit
}
// Output: 4, 3, 2, 1
```

#### Combining Decrement with Modulo

```csharp
// Circular buffer index that wraps around
int index = 0;
int capacity = 5;

for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"Writing to slot: {index}");
    index = (index + 1) % capacity;  // Wraps: 0,1,2,3,4,0,1,2...
}
```

---

## Quick Reference Cheat Sheet

```csharp
// Logical Operators
bool a = true, b = false;
a && b;   // false (AND, short-circuit)
a || b;   // true  (OR, short-circuit)
!a;       // false (NOT)
a & b;    // false (AND, no short-circuit)
a | b;    // true  (OR, no short-circuit)
a ^ b;    // true  (XOR)

// Relational Operators
10 > 5;   // true
10 < 5;   // false
5 >= 5;   // true
5 <= 4;   // false

// Equality Operators
5 == 5;   // true
5 != 3;   // true

// One-line if (Ternary)
string result = condition ? "Yes" : "No";

// Switch
switch (value)
{
    case 1: /* ... */ break;
    case 2: /* ... */ break;
    default: /* ... */ break;
}

// Increment / Decrement
int x = 5;
int a = x++;  // a = 5, x = 6
int b = ++x;  // b = 7, x = 7

// Modulo
int r = 17 % 5;  // r = 2
```

---

## Summary

| Concept | Key Takeaway |
|---------|-------------|
| **Logical Operators** | Use `&&` and `||` for boolean logic; `&` and `\|` for bitwise or when side effects are required. |
| **Relational Operators** | Compare values with `>`, `<`, `>=`, `<=`. Remember: no chaining like `a < x < b` in C#. |
| **Equality Operators** | `==` and `!=` compare values. Be cautious with reference types — override `Equals()` for meaningful comparison. |
| **One-line `if`** | The ternary operator `?:` is perfect for concise value selection. Avoid nesting beyond two levels. |
| **Switch Statement** | Ideal for matching a single expression against multiple constants. Modern C# supports pattern matching and switch expressions. |
| **Increment/Decrement** | `x++` uses then increments; `++x` increments then uses. Use `++`/`--` in loops and counters. |
| **Modulo Operator** | `%` gives the remainder. Essential for cycling, divisibility checks, and digit extraction. |

> **Remember:** Clean decision-making code is readable code. Choose the construct that best expresses your intent, and don't sacrifice clarity for brevity.
