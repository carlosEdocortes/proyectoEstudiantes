using apiEstudiante.Models;
namespace apiEstudiante.Services.Contract
{
    public interface IProfesorService
    {

        Task<List<Profesor>> GetProfesors();
        Task<Profesor> GetProfesor(int idProfesor);

        Task<bool> UpdateProfesor(Profesor profesor);

        Task<bool> DeleteProfesor(int idProfesor);
        Task<Profesor> AddProfesor(Profesor profesor); 

    }
}
