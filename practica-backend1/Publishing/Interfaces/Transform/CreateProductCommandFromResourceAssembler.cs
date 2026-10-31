using practica_backend1.Publishing.Domain.Model.Aggregate;
using practica_backend1.Publishing.Domain.Model.Commands;
using practica_backend1.Publishing.Domain.Model.ValueObject;
using practica_backend1.Publishing.Interfaces.Resources;

namespace practica_backend1.Publishing.Interfaces.Transform;



//en este paso se crea un ensamblador que convierte el resource a un command
//este command de ahi pasa directo al command services
//de ahi del command services pasa al aggregate y de ahi al repositorio

public static class CreateCourseCommandFromResourceAssembler
{
    public static CreateCourseCommand ToCreateCourseCommand(CreateInterfaceCourseResource resource)
    {
        return new CreateCourseCommand(
            new CourseCode(resource.courseCode),
            new CourseTitle(resource.courseTittle)
        );
    }
}
