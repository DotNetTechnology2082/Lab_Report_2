using System;

namespace ValueVsReferenceType
{
    // Reference Type: Class to store student name and marks
    class Student
    {
        public string Name;
        public int Marks;
    }

    class Program
    {
        // Method to modify value type (int)
        static void ModifyValue(int marks)
        {
            marks = 100; // Change will NOT reflect outside
            Console.WriteLine("Inside ModifyValue: " + marks);
        }

        // Method to modify reference type (Student object)
        static void ModifyReference(Student student)
        {
            student.Marks = 100; // Change WILL reflect outside
            Console.WriteLine("Inside ModifyReference: " + student.Marks);
        }

        static void Main(string[] args)
        {
            // Value Type: storing marks
            int marks = 50;
            Console.WriteLine("\n--- Value Type ---");
            Console.WriteLine("Before ModifyValue: " + marks);
            ModifyValue(marks);
            Console.WriteLine("After ModifyValue: " + marks);

            // Reference Type: storing student name and marks
            Student student = new Student();
            student.Name  = "Ram";
            student.Marks = 50;

            Console.WriteLine("\n--- Reference Type ---");
            Console.WriteLine("Before ModifyReference: " + student.Marks);
            ModifyReference(student);
            Console.WriteLine("After ModifyReference: " + student.Marks);

            Console.ReadLine();
        }
    }
}
