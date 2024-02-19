public class TeacherTests
{
    public object Assert { get; private set; }

  
    public void Teacher_GetName_ReturnsCorrectName()
    {
        var mockDatabase = new Mock<IDatabase>(); // Assuming you have a dependency on IDatabase
        var teacher = new Teacher(mockDatabase.Object, "John Doe");

        var result = teacher.GetName();
    }
}

internal class Mock<T>
{
    public Mock()
    {
    }

    public object Object { get; internal set; }
}