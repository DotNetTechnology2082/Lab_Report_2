using System;

namespace LabReport2
{
    // Reference type (class)
    class Student
    {
        public string Name;
        public int Marks;
    }

    class Program
    {
        // Method to modify value type
        static void ModifyValue(int num)
        {
            num = num + 10;
            Console.WriteLine("Inside ModifyValue: " + num);
        }

        // Method to modify reference type
        static void ModifyReference(Student s)
        {
            s.Name = "Changed Name";
            s.Marks = s.Marks + 10;
            Console.WriteLine("Inside ModifyReference: " + s.Name + " " + s.Marks);
        }

        static void Main(string[] args)
        {
            // Value type example
            int marks = 50;
            Console.WriteLine("Before ModifyValue: " + marks);
            ModifyValue(marks);
            Console.WriteLine("After ModifyValue: " + marks);

            Console.WriteLine("----------------------");

            // Reference type example
            Student student = new Student();
            student.Name = "Swastika";
            student.Marks = 50;

            Console.WriteLine("Before ModifyReference: " + student.Name + " " + student.Marks);
            ModifyReference(student);
            Console.WriteLine("After ModifyReference: " + student.Name + " " + student.Marks);
        }
    }
}
