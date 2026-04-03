using System;

// Value Type
struct Marks
{
    public int score;
}

// Reference Type
class Student
{
    public string name;
    public int marks;
}

class Program
{
    // Method to modify value type
    static void ModifyValueType(Marks m)
    {
        m.score = 90;
    }

    // Method to modify reference type
    static void ModifyReferenceType(Student s)
    {
        s.name = "Sushma";
        s.marks = 95;
    }

    static void Main(string[] args)
    {
        // Value Type Example
        Marks m1 = new Marks();
        m1.score = 50;

        // Reference Type Example
        Student s1 = new Student();
        s1.name = "Sushma";
        s1.marks = 60;

        // Calling methods
        ModifyValueType(m1);
        ModifyReferenceType(s1);

        // Display results
        Console.WriteLine("Value Type Marks: " + m1.score);
        Console.WriteLine("Reference Type Name: " + s1.name);
        Console.WriteLine("Reference Type Marks: " + s1.marks);

        Console.ReadLine();
    }
}

