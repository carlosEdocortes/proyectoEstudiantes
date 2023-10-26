using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using apiEstudiante.Models;

namespace apiEstudiante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        public readonly RegistroEstudiantesContext _dbContext;


        public EstudianteController(RegistroEstudiantesContext _context)
        {
            _dbContext = _context;
        }


        [HttpGet]
        [Route("listarEstudiantes")]
        public IActionResult listar() { 
            List<Estudiante> listaEstudiantes= new List<Estudiante>();

            try
            {
                listaEstudiantes = _dbContext.Estudiantes.ToList();
                return StatusCode(StatusCodes.Status200OK,new { mensaje = "OK", response = listaEstudiantes });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status401Unauthorized, new { mensaje = "Error al listar estudiantes "+ex.Message, response = listaEstudiantes });
            }

        }

    }
}
