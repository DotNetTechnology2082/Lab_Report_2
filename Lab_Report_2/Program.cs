
using System;

struct Marks
{
    public int score;
}

class Student
{
    public string name;
    public int marks;
}

class Program
{
    static void ModifyValueType(Marks m)
    {
        m.score = 90;
        Console.WriteLine("Inside ModifyValueType: " + m.score);
    }

    static void ModifyReferenceType(Student s)
    {
        s.name = "Modified Name";
        s.marks = 95;
        Console.WriteLine("Inside ModifyReferenceType: " + s.name + ", " + s.marks);
    }

    static void Main(string[] args)
    {
        Marks m1;
        m1.score = 50;

        Console.WriteLine("Before ModifyValueType: " + m1.score);
        ModifyValueType(m1);
        Console.WriteLine("After ModifyValueType: " + m1.score);

        Console.WriteLine();

        Student s1 = new Student();
        s1.name = "Ash";
        s1.marks = 60;

        Console.WriteLine("Before ModifyReferenceType: " + s1.name + ", " + s1.marks);
        ModifyReferenceType(s1);
        Console.WriteLine("After ModifyReferenceType: " + s1.name + ", " + s1.marks);
    }
}