using System;

class Student
{
    public string name;
    public int marks;
}

class Program
{
    // Method to modify value type
    static void ModifyValue(int marks)
    {
        marks = marks + 10;
        Console.WriteLine("Inside Value Method: " + marks);
    }

    // Method to modify reference type
    static void ModifyReference(Student s)
    {
        s.marks = s.marks + 10;
        Console.WriteLine("Inside Reference Method: " + s.marks);
    }

    static void Main(string[] args)
    {
        // Value type
        int marks = 50;

        // Reference type
        Student s = new Student();
        s.name = "Tashi";
        s.marks = 50;

        Console.WriteLine("Before Value Method: " + marks);
        ModifyValue(marks);
        Console.WriteLine("After Value Method: " + marks);

        Console.WriteLine();

        Console.WriteLine("Before Reference Method: " + s.marks);
        ModifyReference(s);
        Console.WriteLine("After Reference Method: " + s.marks);

        Console.ReadLine();
    }
}