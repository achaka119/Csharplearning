Homework 1
Name: Askar Kairatbek
Group: IT-2501

## Exercise 1.1

### 1. Is Visual Studio 2022 better than Visual Studio Code?
Not necessarily. Visual Studio 2022 is a full IDE with more built-in tools, while VS Code is lighter and works on Windows, macOS, and Linux. The better choice depends on the project and the operating system you use.

### 2. Are .NET 5 and later better than .NET Framework?
For new projects, usually yes. Modern .NET is cross-platform, supports newer versions of C#, and can be used for web, desktop, mobile, and services. .NET Framework is mainly used to maintain older Windows applications.

### 3.What is .NET Standard and why is it still important?
.NET Standard defines a common set of APIs that different .NET implementations can support. It helped developers create libraries that could work on several .NET platforms. Today it is less important, but it is still useful when supporting older .NET Framework or Xamarin projects.

### 4. Why can a programmer use different languages, for example C# and F#, to write applications that run on .NET?
Because languages such as C# and F# are compiled into the same Intermediate Language, or IL. The .NET runtime then executes this IL, so different programming languages can use the same .NET platform.

### 5. What is a top-level program and how do you access command-line arguments?
A top-level program lets us write code without explicitly creating the Program class and the Main method. The compiler creates them automatically.Command-line arguments can still be accessed using the args array, for example:
```C#
Console.WriteLine(args[0]);
```

### 6. What is the name of the entry point method of a .NET console app and how should it be declared?
The entry point is called Main. If we are not using top-level statements, a common declaration is:
```C#
static void Main(string[] args)
{
    // code
}
```
This is where the program starts running.

### 7. What namespace is the Program class defined in with a top-level program?
It is defined in the global, or empty, namespace. This happens because the compiler-generated Program class does not have an explicitly defined namespace.

### 8. Where would you look for help for a C# keyword?
I would first check the official Microsoft Learn documentation, especially the C# language reference. It is usually the most reliable place to understand how a keyword works and see examples.

### 9. Where would you look first for solutions to common programming problems?
I would usually search Stack Overflow or use Google to find similar problems. Stack Overflow is useful because many common programming questions have already been discussed and answered there.

### 10. What should you do after getting an AI to write code for you?
I should not just copy and use the code immediately. I should read it, understand how it works, test it, and check that it actually solves the problem correctly. AI can help, but the programmer is still responsible for the final code.

## Exercise 2.1

### 1. What statement can you type in a C# file to discover the compiler and language version?
```C#
#error version
```

It shows the compiler and C# language version in the error message.

### 2. What are the two types of comments in C#?
There are single-line comments using // and multi-line comments using 
/* and */.

### 3. What is the difference between a verbatim string and an interpolated string?
A verbatim string uses @ and is useful for things like file paths because backslashes are treated normally. An interpolated string uses $ and lets you insert variables inside { }.

### 4. Why should you be careful when using float and double values?
Because they cannot always store decimal numbers exactly. This can cause small precision errors, especially when comparing values with ==.

### 5. How can you determine how many bytes a type like double uses in memory?
for example:
 ```C#
sizeof(double)
```
A double uses 8 bytes.

### 6. When should you use the var keyword?
I would use var when the type is obvious from the value. If it makes the code harder to understand, it is better to write the type explicitly.

### 7. What is the newest syntax to create an instance of a class like XmlDocument?
```C#
XmlDocument xml = new();
```
This avoids repeating the type name.

### 8. Why should you be careful when using the dynamic type?
Because the compiler does not fully check it at compile time. Some errors only appear when the program is running, and IntelliSense is also limited.

### 9. How do you right-align a format string?
a positive alignment number, for example:
```C#
"{0,10}"
```
Positive numbers align to the right, while negative numbers align to the left.

### 10. What character separates arguments for a console app?
A space separates command-line arguments. If one argument contains spaces, it should be put inside quotes.