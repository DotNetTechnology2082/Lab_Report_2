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
        s.name = "Updated Name";
        s.marks = 95;
    }

    static void Main(string[] args)
    {
        // Value Type Example
        Marks m1;
        m1.score = 50;

        // Reference Type Example
        Student s1 = new Student();
        s1.name = "Annie";
        s1.marks = 60;

        // Call methods
        ModifyValueType(m1);
        ModifyReferenceType(s1);

        // Display Results
        Console.WriteLine("Value Type Marks: " + m1.score);
        Console.WriteLine("Reference Type Student Name: " + s1.name);
        Console.WriteLine("Reference Type Student Marks: " + s1.marks);

        Console.ReadLine();
    }
}