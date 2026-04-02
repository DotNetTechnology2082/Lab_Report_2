using System;

class Student
{
    public string Name;
    public int Marks;
}

class Program
{
    // Method to change value type
    static void ChangeValue(int marks)
    {
        marks = marks + 10;
        Console.WriteLine("Inside ChangeValue method: " + marks);
    }

    // Method to change reference type
    static void ChangeReference(Student student)
    {
        student.Marks = student.Marks + 10;
        student.Name = "Updated " + student.Name;
        Console.WriteLine("Inside ChangeReference method: " + student.Name + " - " + student.Marks);
    }

    static void Main()
    {
        // Value type
        int myMarks = 80;

        // Reference type
        Student s = new Student();
        s.Name = "Neha";
        s.Marks = 80;

        Console.WriteLine("Before modification:");
        Console.WriteLine("Value type marks: " + myMarks);
        Console.WriteLine("Reference type student: " + s.Name + " - " + s.Marks);

        // Call methods
        ChangeValue(myMarks);
        ChangeReference(s);

        Console.WriteLine("\nAfter modification:");
        Console.WriteLine("Value type marks: " + myMarks); // stays same
        Console.WriteLine("Reference type student: " + s.Name + " - " + s.Marks); // changed
    }
}