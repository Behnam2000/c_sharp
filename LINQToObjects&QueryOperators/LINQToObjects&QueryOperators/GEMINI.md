# LINQ to Objects & Query Operators — Project Instructions

This document provides conventions, architecture rules, and workflows for the LINQ to Objects & Query Operators project. Adhere to these instructions for all modifications, feature additions, or learning exercises.

## 1. Project Overview & Tech Stack
- **Objective:** Learn, practice, and implement C# LINQ to Objects and various Query Operators.
- **Language & Framework:** C# (targeting .NET 10.0 / modern C#).
- **Features Enabled:**
  - **Implicit Usings:** Enabled (common namespaces like `System`, `System.Collections.Generic`, `System.Linq` are implicitly imported).
  - **Nullable Reference Types:** Enabled (always annotate nullable references and avoid disabling compiler warnings/nullability checks).
- **Project Structure:**
  - `Program.cs`: The entry point (`Main` method) and current playground for testing LINQ queries and data models.
  - Sibling source files should be added as the codebase grows (e.g., separating models into dedicated files).

## 2. Coding Guidelines & Architecture Rules
- **Explicit Types vs. `var`:** 
  - Use `var` for local variables when the type is obvious from the right-hand side of the assignment (e.g., `var sorted = from ...`).
  - Use explicit types (like `IEnumerable<Student>`) for LINQ query results when it enhances readability or is needed to clarify the expected shape of the data.
- **LINQ Style Preferences:**
  - Both **Query Syntax** (`from student in students where ... select student`) and **Method Syntax** (`students.Where(...)`) are acceptable, but prioritize **Query Syntax** when focusing specifically on query operators, joins, and grouping, as it aligns with the project's educational focus.
  - Keep queries clean, formatted on multiple lines when complex, and use descriptive variable names (e.g., use `student` instead of short obscure acronyms like `s`).
- **No Hacks or Warning Suppression:**
  - Do not use `#pragma warning disable` or suppress nullable checks with `!` unless absolutely necessary and logically sound.
  - Do not bypass the type system or use reflection/prototype manipulation. Use explicit, idiomatic C# language features.
- **File & Namespace Organization:**
  - Keep namespaces consistent: `namespace LINQToObjects_QueryOperators;`.
  - When adding new models or helpers, place them in their own files under proper directories or directly in the project root if the project is kept small, maintaining clean code separation instead of putting everything in `Program.cs`.

## 3. Workflow & Common Commands
Always explain any shell commands before running them. Below are the key commands to run and build the project:

- **Build Project:**
  ```bash
  dotnet build
  ```
- **Run Application:**
  ```bash
  dotnet run
  ```
- **Code Formatting:**
  ```bash
  dotnet format
  ```

## 4. Verification & Testing
- Prioritize verification before finalizing any code changes.
- Since there is no dedicated automated unit test suite, verification should be done by running the program (`dotnet run`) and ensuring the console output is correct and visually structured.
