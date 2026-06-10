# C# Course

This repository contains small C# practice programs. Each `.cs` file focuses on one concept, such as variables, loops, arrays, classes, collections, interfaces, and basic object-oriented programming.

## Project Files

| File | What it is about |
| --- | --- |
| `helloworld.cs` | First C# program that prints `hello world` to the console. |
| `variables.cs` | Shows how to declare variables, assign values, and print them. |
| `data_types.cs` | Demonstrates common C# data types like `int`, `long`, `float`, `double`, `decimal`, `bool`, `char`, `byte`, `string`, `object`, arrays, and `var`. |
| `TypeCasting.cs` | Placeholder file for type casting practice. The class exists, but no example code has been added yet. |
| `input_user.cs` | Shows how to take user input with `Console.ReadLine()`, convert input to an integer, and validate input using `int.TryParse()`. |
| `conditional_statements.cs` | Uses `if`, `else if`, and `else` to print a grade based on marks. |
| `Ternary_operator.cs` | Demonstrates the ternary operator by checking whether a number is even or odd. |
| `Switch.cs` | Demonstrates a `switch` statement using different player states. |
| `Loops.cs` | Covers `for`, `while`, `do-while`, `foreach`, `break`, and `continue`. |
| `NestedLoops.cs` | Demonstrates nested loops by printing values from an inner and outer loop. |
| `array.cs` | Shows array basics, including accessing elements, array length, rank, reversing, and sorting. |
| `MultiDimensionalArray.cs` | Demonstrates a three-dimensional array and nested loops for accessing array positions. |
| `list.cs` | Demonstrates `List<T>` using a `Teacher` class, including adding, removing, inserting, looping, and finding an index. |
| `dictinory.cs` | Demonstrates `Dictionary<TKey, TValue>`, including adding values, updating values, checking keys/values, using `TryGetValue()`, and storing objects as values. |
| `Other_Collections.cs` | Shows other collection types: `Queue`, `Stack`, `HashSet`, `LinkedList`, and `SortedList`. |
| `Functions.cs` | Demonstrates creating a method that returns a value, using an `add()` function. |
| `Void.cs` | Demonstrates `void` methods by calling a method that prints a message. |
| `Params.cs` | Demonstrates the `params` keyword for passing a variable number of arguments to a method. |
| `Optional_Parameters.cs` | Shows optional parameters, default values, and named arguments. |
| `Out.cs` | Demonstrates the `out` keyword to return multiple values from a method. |
| `Recursion.cs` | Demonstrates recursion by calculating the factorial of a number. |
| `class_objects.cs` | Demonstrates creating a class, making an object, setting fields, and calling a method. |
| `Constructor.cs` | Demonstrates constructors and setting object values when creating an object. |
| `Properties.cs` | Demonstrates C# properties with `get` and `set` accessors. |
| `Static.cs` | Demonstrates static methods and static fields that can be used without creating an object. |
| `accrss_modiefiers.cs` | Demonstrates access modifiers using a private `score` field and public methods to update and display it. |
| `oops.cs` | Demonstrates object-oriented programming concepts like inheritance, method overriding, and polymorphism. |
| `Interfaces.cs` | Demonstrates interfaces, multiple interface implementation, default interface methods, and explicit interface implementation. |
| `Struct.cs` | Demonstrates `struct` value-type behavior by copying one struct into another. |
| `Enum.cs` | Demonstrates enums and converting an enum value to its integer value. |
| `Delegate.cs` | Demonstrates delegates by storing and calling methods through a delegate variable. |
| `Value_vs_Reference.cs` | Explains value types vs reference types, object references, method parameter behavior, and the `object` keyword. |
| `Number_guess.cs` | A number guessing game where multiple players guess numbers, scores are tracked, and the first player to reach 10 points wins. |

## Keywords Used In This Project

This section lists the main C# keywords used in the `.cs` files and explains their function and common use cases.

| Keyword | Function | Use case |
| --- | --- | --- |
| `using` | Imports namespaces so their classes and methods can be used more easily. | Used for `System`, `System.Collections.Generic`, and other libraries. |
| `namespace` | Groups related classes and avoids naming conflicts. | Used to place course files inside `C__Course`. |
| `class` | Defines a reference type that can contain fields, methods, constructors, and properties. | Used for examples like `Student`, `Cars`, `Calculator`, `Animal`, and `Guess`. |
| `struct` | Defines a value type. | Used in `Struct.cs` to show that copying a struct creates a separate value. |
| `interface` | Defines a contract of methods that classes can implement. | Used in `Interfaces.cs` for `IFly`, `ISwim`, and `ITest`. |
| `enum` | Defines a named set of constant values. | Used in `Enum.cs` for difficulty levels like `Easy`, `Medium`, and `Hard`. |
| `delegate` | Stores a reference to a method with a matching signature. | Used in `Delegate.cs` to call `add()` and `sub()` through a delegate. |
| `public` | Makes a member accessible from outside the class. | Used for methods and fields that other code should access. |
| `private` | Restricts access to inside the same class. | Used in `Number_guess.cs` and `accrss_modiefiers.cs` to protect score fields. |
| `static` | Belongs to the class itself instead of an object. | Used for methods like `Demo.Show()` and shared fields like `Counter.count`. |
| `void` | Means a method does not return a value. | Used for methods that only print output or perform an action. |
| `return` | Sends a value back from a method and exits that method. | Used in `Functions.cs`, `Params.cs`, and `Recursion.cs`. |
| `new` | Creates a new object, array, or collection. | Used to create objects like `new Cars(...)`, `new Guess()`, and `new Dictionary<...>()`. |
| `virtual` | Allows a base class method to be overridden by a derived class. | Used in `oops.cs` for `Animal.sound()`. |
| `override` | Replaces a virtual method from a base class. | Used in `Dog.sound()` to provide dog-specific behavior. |
| `get` | Defines how a property value is read. | Used in `Properties.cs` for `Mmarks` and `Name`. |
| `set` | Defines how a property value is assigned. | Used in `Properties.cs` to control property assignment. |
| `int` | Stores whole numbers. | Used for marks, scores, ages, array values, loop counters, and calculations. |
| `long` | Stores large whole numbers. | Used in `data_types.cs` for a bigger integer value. |
| `float` | Stores decimal numbers with single precision. | Used in `data_types.cs` and `Number_guess.cs` for average/result calculations. |
| `double` | Stores decimal numbers with double precision. | Used in `data_types.cs` and `Params.cs`. |
| `decimal` | Stores precise decimal numbers, often useful for money. | Used in `data_types.cs`. |
| `bool` | Stores `true` or `false`. | Used in `data_types.cs` for simple yes/no state. |
| `char` | Stores a single character. | Used in `data_types.cs`. |
| `byte` | Stores a small whole number from 0 to 255. | Used in `data_types.cs`. |
| `string` | Stores text. | Used for names, messages, input, and printed output. |
| `object` | Base type that can store any type of value. | Used in `data_types.cs`, `Params.cs`, and `Value_vs_Reference.cs`. |
| `var` | Lets the compiler decide the variable type from the assigned value. | Used when the assigned value clearly shows the type. |
| `true` | Boolean value meaning yes/on/correct. | Used for infinite loops and boolean examples. |
| `if` | Runs code only when a condition is true. | Used for grading, input validation, score checking, and logic decisions. |
| `else` | Runs code when the `if` condition is false. | Used for fallback cases like invalid input or failed conditions. |
| `switch` | Selects one block of code from multiple cases. | Used in `Switch.cs` for player state handling. |
| `case` | Defines one possible match inside a `switch`. | Used for player states like idle, running, and jumping. |
| `default` | Runs when no `switch` case matches. | Used to handle an unknown player state. |
| `for` | Repeats code a fixed number of times. | Used for array indexing and counter-based loops. |
| `foreach` | Loops through every item in a collection or array. | Used for arrays, lists, dictionaries, queues, stacks, and other collections. |
| `in` | Used with `foreach` to specify the collection being looped through. | Example: `foreach (var item in students)`. |
| `while` | Repeats code while a condition remains true. | Used in loops and in the number guessing game. |
| `do` | Starts a `do-while` loop that runs at least once. | Used in `Loops.cs` to demonstrate `do-while`. |
| `break` | Stops a loop or exits a `switch`. | Used when a winner is found or when a `switch` case ends. |
| `continue` | Skips the rest of the current loop cycle and moves to the next one. | Used when invalid input is entered or when skipping a loop value. |
| `out` | Allows a method to return values through parameters. | Used in `Out.cs` and with `int.TryParse()`. |
| `params` | Allows a method to accept a variable number of arguments. | Used in `Params.cs` for adding numbers, printing names, and printing mixed items. |

## How To Run

This is a .NET console project. You can run it with:

```bash
dotnet run
```

Many files contain practice methods instead of a normal `Main` method, so you may need to call the method you want to test from your program entry point.
