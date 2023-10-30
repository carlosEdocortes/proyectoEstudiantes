using apiEstudiante.Models;
using apiEstudiante.Services.Contract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace apiEstudiante.Services.Implementation
{
    public class EstudianteMateriaService:IEstudianteMateria
    {
        private readonly RegistroEstudiantesContext _dbcontext;

        public EstudianteMateriaService(RegistroEstudiantesContext _dbcontext) { 
            this._dbcontext = _dbcontext;
        }

        public Task<EstudianteMateria> AddEstudiantematerias(EstudianteMateria objEstudianteMateria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEstudianteMaterias(int idestudianteMateria)
        {
            throw new NotImplementedException();
        }

        public EstudianteMateria GetEstudianteMaterias(int idEstudianteMateria)
        {
            try
            {
                EstudianteMateria? objEstudianteMateria = new EstudianteMateria();
                //objEstudianteMateria =await _dbcontext.EstudianteMateria.Include(mat => mat.Id).Where(es => es.Id == idEstudianteMateria).FirstOrDefaultAsync();
                objEstudianteMateria = (EstudianteMateria)_dbcontext.Materia.Join(_dbcontext.EstudianteMateria, mat => mat.Id, est => est.MateriaId, (mat, est) => new { mat, est }).Where(x => x.mat.Id == idEstudianteMateria);
                return objEstudianteMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EstudianteMateria>> GetListaEstudianteMaterias()
        {
            try
            {
                List<EstudianteMateria> obListaEstudianteMateria = new List<EstudianteMateria>();
                obListaEstudianteMateria = await _dbcontext.EstudianteMateria.Include(est => est.EstudianteId).ToListAsync();
                return obListaEstudianteMateria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<bool> UpdateEstudiantematerias(EstudianteMateria objEstudianteMateria)
        {
            throw new NotImplementedException();
        }

        Task<EstudianteMateria> IEstudianteMateria.GetEstudianteMaterias(int idEstudianteMateria)
        {
            throw new NotImplementedException();
        }
    }
}
