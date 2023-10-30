using apiEstudiante.Models;

namespace apiEstudiante.Services.Contract
{
    public interface IMateriaService
    {

        Task<List<Materia>> GetMaterias();
        Task<Materia> GetMateria(int idMateria);
        Task<Materia> AddMateria(Materia materia);
        Task<bool> DeleteMateria(int idMateria);
        Task<bool> UpdateMateria(Materia materia);


    }
}
