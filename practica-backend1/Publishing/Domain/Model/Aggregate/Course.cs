using practica_backend1.Publishing.Domain.Model.Commands;
using practica_backend1.Publishing.Domain.Model.ValueObject;

namespace practica_backend1.Publishing.Domain.Model.Aggregate;

//creamos una partial class porque permite dividir el archivo en 2 partes, una de escritura y otra de lectura
public partial class Course
{
    //tenemos el id del curso porque este id engloba los 2, curso y titulo, los junta
    public int id { get; private set; }
    
    //llamado a los datos que tenemos que cada uno y los mesclamos con el anterior que es el id
    public CourseCode Code { get; private set; }
    public CourseTitle Title { get; private set; }

    
    //contructor porque estas llamando a las variables puestas antes y la estamos inicializando
    public Course()
    {
        Code = null!;
        Title = null!;
    }
    
    //de los datos que creamos antes le pasamos los command que viene de value object para darles valores
    public Course(CreateCourseCommand command)
    {
        Code = command.coursecode;
        Title = command.courseTittle;
    }
}