using System;
using System.Collections.Generic;

#nullable disable

namespace defensoresTablada.Models.BBDD
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }
    }
}
