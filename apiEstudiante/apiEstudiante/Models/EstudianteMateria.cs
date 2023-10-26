using System;
using System.Collections.Generic;

namespace apiEstudiante.Models;

public partial class EstudianteMateria
{
    public int Id { get; set; }

    public int EstudianteId { get; set; }

    public int MateriaId { get; set; }

    public virtual Estudiante Estudiante { get; set; } = null!;

    public virtual Materia Materia { get; set; } = null!;
}
