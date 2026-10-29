using practica_backend1.Publishing.Domain.Model.Aggregate;
using practica_backend1.Publishing.Domain.Model.Commands;
using practica_backend1.Publishing.Domain.Repositories;
using practica_backend1.Publishing.Shared.Domain.Repositories;

namespace practica_backend1.Publishing.Application.Services;


//creamos una clase que es capaz de manejar los comandos junto al repositorio y la unidad de trabajo, para poder crear un curso
public class CourseCommandServices(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
{
    //se crea un metodo publico asincronico(async) que tiene un task(espera a que el servidor le de la respuesta) y maneja el comando junto al token de cancelacion
    //el token de cancelacion sirve para cuando el usuario quiere cancelar la operacion, entonces manda un aviso para que ya no se ejecute la operacion
    public async Task Handle(CreateCourseCommand command, CancellationToken cancellationToken = default)
    {
            //se verifica que courseRepository tenga un coursecode, si es que ya existe sale el mensaje
            if (await courseRepository.FindCodeAsync(command.coursecode, cancellationToken) != null)
            {
                throw new Exception("Course code already exists");
            }
            //si no es el caso
            else
            {
                //se crea un nuevo curso mediante el command hacia var course 
                var course = new Course(command);
                //se agrega al repositorio
                await courseRepository.AddAsync(course, cancellationToken);
                //se completa la unidad de trabajo y se verifica por si a caso
                await unitOfWork.CompleteAsync(cancellationToken);
            }
    }
}

