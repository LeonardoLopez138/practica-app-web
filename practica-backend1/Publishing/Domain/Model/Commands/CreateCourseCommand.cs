using practica_backend1.Publishing.Domain.Model.ValueObject;

namespace practica_backend1.Publishing.Domain.Model.Commands;

//se crea un especie de molde/trnasicion en donde se agrupan los 2, estos crean 1 solo command de lo que buscamos
public record CreateCourseCommand(CourseCode coursecode, CourseTitle courseTittle);