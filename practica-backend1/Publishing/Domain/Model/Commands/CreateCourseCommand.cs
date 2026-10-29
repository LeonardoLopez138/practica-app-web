using practica_backend1.Publishing.Domain.Model.ValueObject;

namespace practica_backend1.Publishing.Domain.Model.Commands;

public record CreateCourseCommand(CourseCode coursecode, CourseTitle courseTittle);