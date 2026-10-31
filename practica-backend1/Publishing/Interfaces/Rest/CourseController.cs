using Microsoft.AspNetCore.Mvc;
using practica_backend1.Publishing.Application.Services;
using practica_backend1.Publishing.Interfaces.Resources;
using practica_backend1.Publishing.Interfaces.Transform;

namespace practica_backend1.Publishing.Interfaces.Rest;


//atributos
[ApiController]
[Route("api/v1/[controller]")]
public class CourseController(CourseCommandServices courseCommandServices) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateCourse([FromBody] CreateInterfaceCourseResource resource)
    {
        var command = CreateCourseCommandFromResourceAssembler.ToCreateCourseCommand(resource);
        await courseCommandServices.Handle(command);
        
        return Ok();
        
    }
}