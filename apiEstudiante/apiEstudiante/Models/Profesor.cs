using System;
using System.Collections.Generic;

namespace apiEstudiante.Models;

public partial class Profesor
{
    public int Id { get; set; }

    public string NombreProfesor { get; set; } = null!;

    public virtual ICollection<ProfesorMateria> objProfesorMateria { get; set; } = new List<ProfesorMateria>();
}
