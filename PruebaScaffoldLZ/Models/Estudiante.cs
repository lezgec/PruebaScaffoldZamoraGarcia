using System;
using System.Collections.Generic;

namespace PruebaScaffoldLZ.Models;

public partial class Estudiante
{
    public int EstudianteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public bool? Activo { get; set; }
}
