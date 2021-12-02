using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace defensoresTablada.Models.BBDD
{
    public partial class Usuario : Ejericicio
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        [Required]
        public string RolUsuario { get; set; }

        public Rutina Rutinas { get; set; }
    }
}
