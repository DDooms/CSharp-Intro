using Moq;
using MySchoolApp.MySchoolApp;

namespace MySchoolApp.Test;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestEnroll()
    {
        // Arrange
        var student = new Student
        {
            StudentId = 1,
            Name = "John Doe",
            Age = 20
        };

        // Act
        student.Enroll("Math");

        // Assert
        Assert.AreEqual("Math", student.Course);
    }

    [TestMethod]
    public void TestStudy()
    {
        // Arrange
        var student = new Student
        {
            StudentId = 2,
            Name = "Jane Smith",
            Age = 22,
            Course = "English"
        };

        // Act
        student.Study();

        // Assert (no need for assertions here since it only writes to the console)
    }
    [TestMethod]
    public void TestEnrollWithMoq()
    {
        // Arrange
        var mockStudent = new Mock<IStudent>();

        // Act
        mockStudent.Object.Enroll("Math");

        // Assert
        Assert.AreEqual("Math", mockStudent.Object.Course);
    }


    [TestMethod]
    public void TestStudyWithMoq()
    {
        // Arrange
        var mockStudent = new Mock<IStudent>();
        mockStudent.Setup(s => s.Study());

        // Act
        mockStudent.Object.Study();

        // Assert (no need for assertions here since it only writes to the console)
    }
}