using Conexion_Mongo_Api.Models;
using Conexion_Mongo_Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Conexion_Mongo_Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesController : ControllerBase
    {

            private readonly EstudianteService _estudianteService;

            public EstudiantesController(EstudianteService estudianteService)
            {
                _estudianteService = estudianteService;
            }

            [HttpPost]
            public async Task<IActionResult> CrearEstudiante([FromBody] Estudiante estudiante)
            {
                await _estudianteService.CreateAsync(estudiante);
                return CreatedAtAction(nameof(CrearEstudiante), new { id = estudiante.Id }, estudiante);
            }
    }
}
