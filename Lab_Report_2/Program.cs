using System;

namespace Lab_Report_2
{
    // Reference Type: Student class
    class Student
    {
        public string Name;
        public int Marks;
    }

    class Program
    {
        // Method to modify value type
        static void ModifyValue(int mark)
        {
            mark = mark + 10;
            Console.WriteLine("Inside ModifyValue method: " + mark);
        }

        // Method to modify reference type
        static void ModifyReference(Student student)
        {
            student.Marks = student.Marks + 10;
            Console.WriteLine("Inside ModifyReference method: " + student.Marks);
        }

        static void Main(string[] args)
        {
            // 1) Value type
            int score = 50;
            Console.WriteLine("Original Value Type (score): " + score);
            ModifyValue(score);
            Console.WriteLine("After ModifyValue call: " + score);

            // 2) Reference type
            Student s1 = new Student();
            s1.Name = "Suman";
            s1.Marks = 50;

            Console.WriteLine("Original Reference Type (s1.Marks): " + s1.Marks);
            ModifyReference(s1);
            Console.WriteLine("After ModifyReference call: " + s1.Marks);

            Console.WriteLine($"Student Name: {s1.Name}, Marks: {s1.Marks}");
        }
    }
}