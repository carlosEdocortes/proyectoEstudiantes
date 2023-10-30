using apiEstudiante.Models;

namespace apiEstudiante.Services.Contract
{
    public interface IProfesorMateria
    {
        Task<List<ProfesorMateria>> GetListaProfesorMaterias();
        Task<ProfesorMateria> GetProfesorMaterias(int idProfesorMateria);
        Task<bool> DeleteProfesorMaterias(int idProfesorMateria);
        Task<ProfesorMateria> AddProfesorMaterias(ProfesorMateria objProfesorMateria);
        Task<bool> UpdateProfesorMaterias(ProfesorMateria objProfesorMateria);
    }
}
