using System;

// Value Type (struct)
struct Marks
{
    public int score;
}

// Reference Type (class)
class Student
{
    public string name;
    public int marks;
}

class Program
{
    // Method to modify value type
    static void ModifyValue(Marks m)
    {
        m.score = 90;
        Console.WriteLine("Inside ModifyValue: " + m.score);
    }

    // Method to modify reference type
    static void ModifyReference(Student s)
    {
        s.name = "Modified Name";
        s.marks = 95;
        Console.WriteLine("Inside ModifyReference: " + s.name + ", " + s.marks);
    }

    static void Main(string[] args)
    {
        // Value type object
        Marks m1;
        m1.score = 50;

        // Reference type object
        Student s1 = new Student();
        s1.name = "Anuj";
        s1.marks = 60;

        Console.WriteLine("Before Modification:");
        Console.WriteLine("Marks: " + m1.score);
        Console.WriteLine("Student: " + s1.name + ", " + s1.marks);

        // Calling methods
        ModifyValue(m1);
        ModifyReference(s1);

        Console.WriteLine("\nAfter Modification:");
        Console.WriteLine("Marks: " + m1.score); // unchanged
        Console.WriteLine("Student: " + s1.name + ", " + s1.marks); // changed
    }
}