using practica_backend1.Publishing.Domain.Model.Commands;
using practica_backend1.Publishing.Domain.Model.ValueObject;

namespace practica_backend1.Publishing.Domain.Model.Aggregate;

public partial class Course
{
    public int id { get; private set; }
    public CourseCode Code { get; private set; }
    public CourseTitle Title { get; private set; }

    public Course()
    {
        Code = null!;
        Title = null!;
    }
    
    public Course(CreateCourseCommand command)
    {
        Code = command.coursecode;
        Title = command.courseTittle;
    }
}