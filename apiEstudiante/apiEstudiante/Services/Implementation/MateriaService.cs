using apiEstudiante.Models;
using apiEstudiante.Services.Contract;
using Microsoft.EntityFrameworkCore;

namespace apiEstudiante.Services.Implementation
{
    public class MateriaService:IMateriaService
    {
        RegistroEstudiantesContext db_context;
        public MateriaService(RegistroEstudiantesContext context) {

            db_context = context;
        }

        public Task<Materia> AddMateria(Materia materia)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMateria(int idMateria)
        {
            throw new NotImplementedException();
        }

        public Task<Materia> GetMateria(int idMateria)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Materia>> GetMaterias()
        {
            try
            {
                List<Materia> objListaMaterias = new List<Materia>();
                objListaMaterias = await db_context.Materia.ToListAsync();
                return objListaMaterias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> UpdateMateria(Materia materia)
        {
            throw new NotImplementedException();
        }
    }
}
