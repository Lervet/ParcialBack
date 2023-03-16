using System;
using System.Collections.Generic;

namespace BackParcial.Models;

public partial class Farmaco
{
    public int IdFarmacos { get; set; }

    public string? Nombre { get; set; }

    public string? Codigo { get; set; }

    public int? Cantidad { get; set; }
}
