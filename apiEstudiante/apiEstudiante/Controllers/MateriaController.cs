using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiEstudiante.Models;


namespace apiEstudiante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {

        public RegistroEstudiantesContext _dbContext = new RegistroEstudiantesContext();


        public MateriaController(RegistroEstudiantesContext context) { 
            _dbContext = context;
        }

        [HttpGet]
        [Route("listarMaterias")]
        public IActionResult listarMaterias()
        {
            List <Materia> listaMaterias = new List <Materia>();

            try
            {
                listaMaterias = _dbContext.Materia.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = listaMaterias });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Error al listar materias"+ex.Message });
            }
        }


    }
}
