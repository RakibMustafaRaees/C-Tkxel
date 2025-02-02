//using System;                       // using System means that we can use classes from the System namespace.
                                    // A blank line. C# ignores white space. However, multiple lines makes the code more readable.
namespace HelloWorld                // Namespace is used to organize your code, and it is a container for classes and other namespaces.
{                                   // The curly braces {} marks the beginning and the end of a block of code.
  public class Program1_HelloWorld                     // class is a container for data and methods, which brings functionality to your program. 
                                    //Every line of code that runs in C# must be inside a class. In our example, we named the class --Program--
  {
    public static void descriptive_HelloWorld() // Another thing that always appear in a C# program is the Main method. Any code inside its curly brackets {} will be executed.
    {
      Console.WriteLine("Hello World with lots of comments");    
    }
  }
}

/* Console is a class of the System namespace ----> which has a WriteLine() method that is used to output/print text. 

In our example, it will output "Hello World!".
If you omit the using System line, you would have to write ----> System.Console.WriteLine() <---- to print/output text.

Note: Every C# statement ends with a semicolon ;.
Note: C# is case-sensitive; "MyClass" and "myclass" have different meaning.
*/