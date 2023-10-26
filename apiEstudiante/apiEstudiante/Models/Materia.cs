using System;
using System.Collections.Generic;

namespace apiEstudiante.Models;

public partial class Materia
{
    public int Id { get; set; }

    public string NombreMateria { get; set; } = null!;

    public int Credito { get; set; }

    public virtual ICollection<EstudianteMateria> objEstudianteMateria { get; set; } = new List<EstudianteMateria>();

    public virtual ICollection<ProfesorMateria> objProfesorMateria { get; set; } = new List<ProfesorMateria>();
}
