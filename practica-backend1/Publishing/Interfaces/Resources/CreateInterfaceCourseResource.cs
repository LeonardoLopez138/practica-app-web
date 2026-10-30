

//esta es muy parecida pero pero muy parecida a la clase de courseCommandServices
//pero esta se encarga de validar los datos http, es como los primitivos, si es que no existe viene aqui primero
//si es que no se implementan esos 2 de forma correcta no se podra crear el curso y saltara el error 400 bad request


//osea que este se encarga de verificar que los datos que pones esten acorde a lo que se espera
//mientras que el command services se encarga de verificar el negocio

using System.ComponentModel.DataAnnotations;

namespace practica_backend1.Publishing.Interfaces.Resources;

public record CreateInterfaceCourseResource(

    
    [Required(ErrorMessage = "The course code is required")] string courseCode,
    [Required(ErrorMessage = "The course title is required")] string courseTittle
    ){}