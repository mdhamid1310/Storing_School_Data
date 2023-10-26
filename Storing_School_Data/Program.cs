using System;
using System.Collections.Generic;
using System.Linq;
using SchoolLibrary;

class Program
{
    static void Main()
    {
        // Create and initialize lists for students, teachers, and subjects.
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Subject> subjects = new List<Subject>();

        // Add sample data
        students.Add(new Student("John", "Class A", "Section 1"));
        students.Add(new Student("Bob", "Class B", "Section 2"));
        students.Add(new Student("Warner", "Class A", "Section 1"));
        students.Add(new Student("Nikhil", "Class B", "Section 2"));

        teachers.Add(new Teacher("Mr. Smith", "Class A", "Section 1"));
        teachers.Add(new Teacher("Ms. Johnson", "Class B", "Section 2"));

        subjects.Add(new Subject("Math", "MATH101", teachers[0])); // Math taught by Mr. Smith
        subjects.Add(new Subject("Science", "SCI101", teachers[1]));// Science taught by Ms. Johnson
        subjects.Add(new Subject("English", "ENG101", teachers[1]));// English taught by Ms. Johnson

        // Display students in a class
        DisplayStudentsInClass(students, "Class A", "Section 1");

        // Display subjects taught by a teacher
        DisplaySubjectsByTeacher(subjects, "Mr. Smith");

        // You can add more data and perform other operations as needed.
        Console.ReadLine();
    }

    static void DisplayStudentsInClass(List<Student> students, string className, string section)
    {
        Console.WriteLine($"Students in Class {className}, Section {section}:");
        var studentsInClass = students.Where(student => student.Class == className && student.Section == section);
        foreach (var student in studentsInClass)
        {
            Console.WriteLine(student.Name);
        }
    }

    static void DisplaySubjectsByTeacher(List<Subject> subjects, string teacherName)
    {
        Console.WriteLine($"Subjects taught by {teacherName}:");
        var subjectsTaught = subjects.Where(subject => subject.Teacher.Name == teacherName);
        foreach (var subject in subjectsTaught)
        {
            Console.WriteLine($"{subject.Name} (Subject Code: {subject.SubjectCode})");
        }
    }
    
}
