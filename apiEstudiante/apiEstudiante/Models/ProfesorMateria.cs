﻿using System;
using System.Collections.Generic;

namespace apiEstudiante.Models;

public partial class ProfesorMateria
{
    public int IdProfesorMateria { get; set; }

    public int? IdProfesor { get; set; }

    public int? IdMateria { get; set; }

    public virtual Materia? IdMateriaNavigation { get; set; }

    public virtual Profesor? IdProfesorNavigation { get; set; }
}
