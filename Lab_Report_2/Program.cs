using System;

class Student
{
    public string name;
    public int marks;
}

class Program
{
    // Method to modify value type
    static void ModifyValue(int num)
    {
        num = num + 50;
        Console.WriteLine("Inside ModifyValue: " + num);
    }

    // Method to modify reference type
    static void ModifyReference(Student s)
    {
        s.name = "Changed Name";
        s.marks = s.marks + 50;
        Console.WriteLine("Inside ModifyReference: " + s.name + " - " + s.marks);
    }

    static void Main(string[] args)
    {
        // VALUE TYPE
        int marks = 50;
        Console.WriteLine("Before ModifyValue: " + marks);
        ModifyValue(marks);
        Console.WriteLine("After ModifyValue: " + marks);

        Console.WriteLine();

        // REFERENCE TYPE
        Student student = new Student();
        student.name = "Pradip";
        student.marks = 50;

        Console.WriteLine("Before ModifyReference: " + student.name + " - " + student.marks);
        ModifyReference(student);
        Console.WriteLine("After ModifyReference: " + student.name + " - " + student.marks);

        Console.ReadLine();
    }
}