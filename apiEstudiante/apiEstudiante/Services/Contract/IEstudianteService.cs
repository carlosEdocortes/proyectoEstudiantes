using apiEstudiante.Models;
namespace apiEstudiante.Services.Contract
{
    public interface IEstudianteService
    {
        Task<List<Estudiante>> GetEstudiante();
        Task<Estudiante> GetEstudiante(int idEstudiante);
        Task<Estudiante> AddEstudiante(Estudiante estudiante);
        Task<bool> DeleteEstudiante(int idEstudiante);
        Task<bool> UpdateEstudiante(Estudiante estudiante);


    }
}
