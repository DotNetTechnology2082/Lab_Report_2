using System;

namespace LabReport2
{
    // 1) Value Type (struct)
    struct Marks
    {
        public int score;
    }

    // 2) Reference Type (class)
    class Student
    {
        public string name;
        public Marks marks;
    }

    class Program
    {
        // 3a) Method to modify value type
        static void ModifyValueType(Marks m)
        {
            m.score = 90;
            Console.WriteLine("Inside ModifyValueType: " + m.score);
        }

        // 3b) Method to modify reference type
        static void ModifyReferenceType(Student s)
        {
            s.name = "Changed Name";
            s.marks.score = 85;
        }

        static void Main(string[] args)
        {
            // Create value type
            Marks m1;
            m1.score = 60;

            // Create reference type
            Student s1 = new Student();
            s1.name = "suvam basnet";
            s1.marks = m1;

            Console.WriteLine("Before Method Calls:");
            Console.WriteLine("Marks: " + m1.score);
            Console.WriteLine("Student Name: " + s1.name);
            Console.WriteLine("Student Marks: " + s1.marks.score);

            Console.WriteLine("\nCalling ModifyValueType...");
            ModifyValueType(m1);

            Console.WriteLine("After ModifyValueType:");
            Console.WriteLine("Marks: " + m1.score); // unchanged

            Console.WriteLine("\nCalling ModifyReferenceType...");
            ModifyReferenceType(s1);

            Console.WriteLine("After ModifyReferenceType:");
            Console.WriteLine("Student Name: " + s1.name); // changed
            Console.WriteLine("Student Marks: " + s1.marks.score); // changed

            Console.ReadLine();
        }
    }
}