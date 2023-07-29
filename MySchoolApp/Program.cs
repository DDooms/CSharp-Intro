// Create an instance of the Student class

using MySchoolApp.MySchoolApp;

IStudent student = new Student
{
    StudentId = 1,
    Name = "John Doe",
    Age = 20
};

// Test the methods of the Student class
student.Enroll("Math");
student.Study();
student.TakeExam();
student.PrintStudentInfo();

Console.ReadKey();