using Microsoft.EntityFrameworkCore;
using apiEstudiante.Models;
using apiEstudiante.Services.Contract;

namespace apiEstudiante.Services.Implementation
{
    public class EstudianteService: IEstudianteService
    {
        private readonly RegistroEstudiantesContext _dbContext;
        public EstudianteService(RegistroEstudiantesContext context) {
        
            this._dbContext = context;
        }

        public Task<Estudiante> AddEstudiante(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEstudiante(int idEstudiante)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Estudiante>> GetEstudiantes()
        {
            try
            {
                List<Estudiante> objListaEstudiante = new List<Estudiante>();
                objListaEstudiante= await _dbContext.Estudiantes.ToListAsync();
                return objListaEstudiante;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Estudiante> GetEstudiante(int idEstudiante)
        {
            try
            {
                Estudiante? objEstudiante = new Estudiante();
                objEstudiante = await _dbContext.Estudiantes.Where(e => e.Id == idEstudiante).FirstOrDefaultAsync();
                return objEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> UpdateEstudiante(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public Task<List<Estudiante>> GetEstudiante()
        {
            throw new NotImplementedException();
        }
    }
}
