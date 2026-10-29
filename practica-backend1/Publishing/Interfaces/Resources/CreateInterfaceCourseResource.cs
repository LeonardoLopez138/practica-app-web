
using System.ComponentModel.DataAnnotations;

namespace practica_backend1.Publishing.Interfaces.Resources;

public record CreateInterfaceCourseResource(
    
    [Required(ErrorMessage = "The course code is required")] string coursecode,
    [Required(ErrorMessage = "The course title is required")] string courseTittle
    
    ){}