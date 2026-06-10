# C# Course

A beginner-friendly collection of C# programs designed to help learners understand the fundamentals of C# programming and Object-Oriented Programming (OOP).

This repository contains small, focused examples where each file demonstrates a specific concept. The goal is to build a strong foundation in C# by learning one topic at a time through practical code examples.

Whether you're a student, self-learner, or aspiring game developer using Unity, these examples can help you understand how core C# concepts work in real-world applications.

---

# Author

**Legendpoke**

Passionate about programming, game development, and helping beginners learn software development through practical examples.

---

# What You'll Learn

This repository covers:

- Variables and Data Types
- User Input Handling
- Conditional Statements
- Loops and Nested Loops
- Arrays and Collections
- Functions and Parameters
- Object-Oriented Programming (OOP)
- Constructors and Properties
- Access Modifiers
- Interfaces
- Delegates
- Structs and Enums
- Value Types vs Reference Types
- Basic Console Game Development

By completing these examples, you'll develop a solid understanding of C# fundamentals that can later be applied to:

- Unity Game Development
- Desktop Applications
- Web Development with ASP.NET
- Backend Development
- Software Engineering Projects

---

# Project Structure

Each file focuses on a specific programming concept.

| File | Concept | Real-World Use Case |
|--------|--------|--------|
| `helloworld.cs` | Hello World Program | Understanding program structure and console output. |
| `variables.cs` | Variables | Storing player names, scores, health values, etc. |
| `data_types.cs` | Data Types | Managing different kinds of data such as numbers, text, and boolean states. |
| `TypeCasting.cs` | Type Conversion | Converting user input or data received from external systems. |
| `input_user.cs` | User Input | Reading player names, menu options, or configuration settings. |
| `conditional_statements.cs` | If-Else Statements | Decision-making systems such as grading, game logic, or validations. |
| `Ternary_operator.cs` | Ternary Operator | Writing shorter conditional expressions. |
| `Switch.cs` | Switch Statement | Handling game states, menus, or command selections. |
| `Loops.cs` | Looping | Repeating actions such as game updates or data processing. |
| `NestedLoops.cs` | Nested Loops | Working with grids, matrices, and board games. |
| `array.cs` | Arrays | Storing collections of related values like scores or inventory items. |
| `MultiDimensionalArray.cs` | 3D Arrays | Managing coordinates, maps, and spatial data. |
| `list.cs` | Lists | Dynamic collections where size changes during runtime. |
| `dictinory.cs` | Dictionaries | Fast key-value lookups such as usernames and profiles. |
| `Other_Collections.cs` | Queue, Stack, HashSet, LinkedList, SortedList | Specialized collections for different programming problems. |
| `Functions.cs` | Methods with Return Values | Reusable logic that returns results. |
| `Void.cs` | Void Methods | Performing actions without returning values. |
| `Params.cs` | Params Keyword | Accepting a variable number of arguments. |
| `Optional_Parameters.cs` | Optional Parameters | Making methods easier and more flexible to call. |
| `Out.cs` | Out Parameters | Returning multiple values from a method. |
| `Recursion.cs` | Recursive Methods | Solving problems that repeat themselves, such as factorial calculations. |
| `class_objects.cs` | Classes and Objects | Building custom data types. |
| `Constructor.cs` | Constructors | Initializing objects with default values. |
| `Properties.cs` | Properties | Controlled access to class data. |
| `Static.cs` | Static Members | Shared methods and data across all objects. |
| `accrss_modiefiers.cs` | Access Modifiers | Protecting data and controlling accessibility. |
| `oops.cs` | Inheritance and Polymorphism | Creating reusable and extensible code structures. |
| `Interfaces.cs` | Interfaces | Defining contracts between classes. |
| `Struct.cs` | Structs | Lightweight value-type objects. |
| `Enum.cs` | Enumerations | Creating readable named constants. |
| `Delegate.cs` | Delegates | Storing and executing methods dynamically. |
| `Value_vs_Reference.cs` | Memory Management | Understanding how data behaves when copied or passed around. |
| `Number_guess.cs` | Console Game Project | Combines multiple concepts into a complete mini-project. |

---

# Number Guess Game

The Number Guess Game is the largest practice project in this repository. It is a four-player console game where three computer-controlled players compete against one human player. Each round, all four players submit guesses, a target result is calculated from those guesses, and anyone whose guess falls within a range of the result earns a point. The first player to reach 10 points wins.

## How It Works

**Round Setup**

At the start of each round, three random numbers between 0 and 100 are generated — one for each computer player. The human player is then prompted to enter their own guess in the same range.

**Result Calculation**

All four guesses are added together and divided by 4 to find the average. That average is then multiplied by 0.8 to produce the round's target result, representing 80% of the average guess.

**Scoring**

Each player's guess is checked against the result. If a guess falls within plus or minus 2 of the result, that player earns one point. All four players are checked independently in the same round, so multiple players can score in a single round.

**Winning Condition**

Score tracking is maintained individually for all four players. The moment any player's score reaches 10, that player is declared the winner and the game ends.

**Input Validation**

If the human player enters something that is not a valid number, the round is skipped and the player is prompted again. This prevents the program from crashing on bad input.

## Concepts Practiced

- Classes and Objects
- Instance variables for score tracking
- Random number generation
- While loop for the game cycle
- Input validation using `int.TryParse`
- Conditional statements for scoring logic
- Loop control with `break` to end the game
- Float arithmetic for average calculation
- Type conversion with `Convert.ToInt32`

## Game Logic Summary

```
Each round:
  player_one, player_two, player_three = random numbers (0-100)
  player = human input

  average = (player_one + player_two + player_three + player) / 4
  result  = average * 0.8

  For each player:
    if guess is within result ± 2 → score + 1
    if score reaches 10          → that player wins, game ends
```

---

# Important C# Concepts Covered

## Object-Oriented Programming (OOP)

The repository introduces the four core OOP principles:

### Encapsulation
Protecting data using access modifiers and properties.

### Inheritance
Allowing one class to inherit functionality from another.

### Polymorphism
Allowing methods to behave differently depending on the object.

### Abstraction
Hiding implementation details and exposing only required functionality.

---

# How To Run

Clone the repository:

```bash
git clone https://github.com/your-username/your-repository-name.git
```

Move into the project folder:

```bash
cd your-repository-name
```

Run the project:

```bash
dotnet run
```

Some files contain practice methods instead of a standard `Main()` method.

To test a specific concept:

1. Open the desired `.cs` file.
2. Call its method from `Main()`.
3. Run the project again.

---

# Who Is This Repository For?

- Beginners learning C#
- B.Tech Students
- Unity Game Developers
- Aspiring Software Engineers
- Anyone preparing for Object-Oriented Programming interviews