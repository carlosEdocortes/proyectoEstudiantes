using System;
using System.Collections.Generic;

namespace apiEstudiante.Models;

public partial class Estudiante
{
    public int Id { get; set; }

    public string NombreEstudiante { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public int Grado { get; set; }

    public string Clave { get; set; } = null!;

    public virtual ICollection<EstudianteMateria> objEstudianteMateria { get; set; } = new List<EstudianteMateria>();
}
