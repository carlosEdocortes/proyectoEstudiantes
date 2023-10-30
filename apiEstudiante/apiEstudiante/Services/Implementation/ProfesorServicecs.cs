using apiEstudiante.Models;
using apiEstudiante.Services.Contract;
using Microsoft.EntityFrameworkCore;

namespace apiEstudiante.Services.Implementation
{
    public class ProfesorServicecs: IProfesorService
    {
        RegistroEstudiantesContext db_context;
        public ProfesorServicecs(RegistroEstudiantesContext db_context)
        {
            this.db_context = db_context;
        }

        public Task<Profesor> AddProfesor(Profesor profesor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProfesor(int idProfesor)
        {
            throw new NotImplementedException();
        }

        public Task<Profesor> GetProfesor(int idProfesor)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Profesor>> GetProfesors()
        {
            try
            {
                List<Profesor> objListaProfesor = new List<Profesor>();
                objListaProfesor= await db_context.Profesors.ToListAsync();
                return objListaProfesor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> UpdateProfesor(Profesor profesor)
        {
            throw new NotImplementedException();
        }
    }
}
