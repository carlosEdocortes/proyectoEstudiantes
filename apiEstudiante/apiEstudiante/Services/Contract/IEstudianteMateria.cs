using apiEstudiante.Models;

namespace apiEstudiante.Services.Contract
{
    public interface IEstudianteMateria
    {
        Task<List<EstudianteMateria>> GetListaEstudianteMaterias();
        Task<EstudianteMateria> GetEstudianteMaterias(int idEstudianteMateria);
        Task<bool> DeleteEstudianteMaterias(int idestudianteMateria);
        Task<EstudianteMateria> AddEstudiantematerias(EstudianteMateria objEstudianteMateria);
        Task<bool> UpdateEstudiantematerias(EstudianteMateria objEstudianteMateria);
    }
}
