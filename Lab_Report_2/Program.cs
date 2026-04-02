using System;

struct Marks
{
    public int score;
}

// Reference Type (Class)
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
        Console.WriteLine("Inside ModifyValueType: " + m.score);
    }

    // Method to modify reference type
    static void ModifyReferenceType(Student s)
    {
        s.name = "Modified Name";
        s.marks = 95;
        Console.WriteLine("Inside ModifyReferenceType: " + s.name + ", " + s.marks);
    }

    static void Main(string[] args)
    {
        // Value Type Example
        Marks m1;
        m1.score = 50;

        Console.WriteLine("Before ModifyValueType: " + m1.score);
        ModifyValueType(m1);
        Console.WriteLine("After ModifyValueType: " + m1.score);

        Console.WriteLine();

        // Reference Type Example
        Student s1 = new Student();
        s1.name = "Krishal";
        s1.marks = 70;

        Console.WriteLine("Before ModifyReferenceType: " + s1.name + ", " + s1.marks);
        ModifyReferenceType(s1);
        Console.WriteLine("After ModifyReferenceType: " + s1.name + ", " + s1.marks);

        Console.ReadLine();
    }
}