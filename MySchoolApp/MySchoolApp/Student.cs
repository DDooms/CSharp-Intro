namespace MySchoolApp.MySchoolApp;

public class Student : IStudent
{
    // Properties
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }

    // Methods
    public void Enroll(string course)
    {
        Course = course;
        Console.WriteLine($"{Name} has enrolled in {course}.");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying hard for {Course}.");
    }

    public void TakeExam()
    {
        Console.WriteLine($"{Name} is taking the exam for {Course}.");
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Course: {Course}");
    }
}