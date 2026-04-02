using System;

// Structure (Value Type)
struct Marks
{
    public int score;
}

// Class (Reference Type)
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
        s.name = "Changed Name";
        s.marks = 95;
        Console.WriteLine("Inside ModifyReference: " + s.name + ", " + s.marks);
    }

    static void Main(string[] args)
    {
        // Value type example
        Marks m1;
        m1.score = 50;

        Console.WriteLine("Before ModifyValue: " + m1.score);
        ModifyValue(m1);
        Console.WriteLine("After ModifyValue: " + m1.score);

        Console.WriteLine();

        // Reference type example
        Student s1 = new Student();
        s1.name = "John";
        s1.marks = 60;

        Console.WriteLine("Before ModifyReference: " + s1.name + ", " + s1.marks);
        ModifyReference(s1);
        Console.WriteLine("After ModifyReference: " + s1.name + ", " + s1.marks);

        Console.ReadLine();
    }
}