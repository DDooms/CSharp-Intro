namespace MySchoolApp.MySchoolApp;

public interface IStudent
{
    int StudentId { get; set; }
    string Name { get; set; }
    int Age { get; set; }
    string Course { get; set; }

    void Enroll(string course);
    void Study();
    void TakeExam();
    void PrintStudentInfo();
}