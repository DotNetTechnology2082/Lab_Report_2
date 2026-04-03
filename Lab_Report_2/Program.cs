using System;

namespace ValueVsReferenceDemo
{
    // Reference type: Student class
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        // Method to modify value type
        static void ModifyValueType(int marks)
        {
            marks = 90; // change value
            Console.WriteLine("Inside ModifyValueType: Marks = " + marks);
        }

        // Method to modify reference type
        static void ModifyReferenceType(Student student)
        {
            student.Marks = 95; // change property
            Console.WriteLine("Inside ModifyReferenceType: Marks = " + student.Marks);
        }

        static void Main(string[] args)
        {
            // Value type example
            int marks = 80;
            Console.WriteLine("Original Value Type Marks = " + marks);
            ModifyValueType(marks);
            Console.WriteLine("After ModifyValueType: Marks = " + marks);

            Console.WriteLine();

            // Reference type example
            Student student = new Student { Name = "John", Marks = 85 };
            Console.WriteLine("Original Reference Type Marks = " + student.Marks);
            ModifyReferenceType(student);
            Console.WriteLine("After ModifyReferenceType: Marks = " + student.Marks);

            Console.ReadLine();
        }
    }
}
