using System;
using System.Collections.Generic;

namespace BackParcial.Models;

public partial class Cliente
{
    public int IdClientes { get; set; }

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Cedula { get; set; }
}
