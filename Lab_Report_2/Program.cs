/*
 LAB REPORT 2
Value Types and Reference Types in .NET Console Application
Objective

To demonstrate the difference between value types and reference types in C# using a simple student system.
*/
using System;
// Value Type (Structure)
struct Marks
{
    public int score;
}

// Reference type(class)
class Student
{
    public string name;
    public Marks marks;
}

class Program
{
    // method to modify value type
    static void ModifyValueType(Marks m) 
    {
        m.score = 90;
        Console.WriteLine("Inside ModifyValueType: " + m.score);
    }

    // method to modify reference type
    static void ModifyReferenceType(Student s)
    {
        s.name = "Anmol";
        s.marks.score = 95;
        Console.WriteLine("Inside ModifyReferenceType: " + s.name + " " + s.marks.score);
    }
    static void Main(string[] args)
    {
        // Value Type example
        Marks m1;
        m1.score = 50;

        // Reference type example
        Student s1 = new Student();
        s1.name = "Sachin";
        s1.marks.score = 50;

        // Calling Methods
        ModifyValueType(m1);
        ModifyReferenceType(s1);

        // Displaying Results
        Console.WriteLine("\n.....After Method Calls.....");
        Console.WriteLine("Marks (value type): " + m1.score);
        Console.WriteLine("Student (Reference type): " + s1.name + " " + s1.marks.score);
        Console.ReadLine();
    }
}

/*
 *Value Type
A copy of the actual value is passed to the method.
So the method works on a separate independent variable.

Result: original variable is unaffected.

Reference Type
A copy of the reference (address) is passed.
That reference still points to the same object in heap memory.

So both original variable and method parameter point to the same object.

Result: changes inside method affect the original object.
 */