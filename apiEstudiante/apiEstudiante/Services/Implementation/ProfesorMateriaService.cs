using apiEstudiante.Models;
using apiEstudiante.Services.Contract;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace apiEstudiante.Services.Implementation
{
    public class ProfesorMateriaService:IProfesorMateria
    {
        private readonly RegistroEstudiantesContext _dbcontext;

        public  ProfesorMateriaService(RegistroEstudiantesContext _dbcontext)
        {
            this._dbcontext = _dbcontext;
        }

        public Task<ProfesorMateria> AddProfesorMaterias(ProfesorMateria objProfesorMateria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProfesorMaterias(int idProfesorMateria)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProfesorMateria>> GetListaProfesorMaterias()
        {
            try
            {
                List<ProfesorMateria> objListaProfesorMateria = new List<ProfesorMateria>();
                objListaProfesorMateria = await _dbcontext.ProfesorMateria.Include(pr=> pr.IdProfesor).ToListAsync();
                return objListaProfesorMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ProfesorMateria> GetProfesorMaterias(int idProfesorMateria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProfesorMaterias(ProfesorMateria objProfesorMateria)
        {
            throw new NotImplementedException();
        }
    }
}
