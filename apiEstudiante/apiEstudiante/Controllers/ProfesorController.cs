using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiEstudiante.Models;

namespace apiEstudiante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        RegistroEstudiantesContext _dbContext = new RegistroEstudiantesContext();
        public ProfesorController(RegistroEstudiantesContext context) {
            
            _dbContext = context;
        }

        [HttpGet]
        [Route("listarProfesor")]
        public IActionResult listarProfesor()
        {
            List <Profesor> listarProfe = new List<Profesor> ();

            try
            {
                listarProfe = _dbContext.Profesors.ToList();
                return StatusCode(StatusCodes.Status200OK, new {mensaje=" OK",response=listarProfe});
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, new { mensaje = " Error al listar el profesor "+ex.Message });
            }
        }


    }
}
