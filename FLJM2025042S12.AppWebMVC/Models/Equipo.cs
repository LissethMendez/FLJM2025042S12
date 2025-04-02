using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FLJM2025042S12.AppWebMVC.Models;

public partial class Equipo
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
