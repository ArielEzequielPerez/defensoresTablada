using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace defensoresTablada.Models.BBDD
{
    public class Usuario : IDBase
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        
        public string RolUsuario { get; set; }

        public Rutina Rutinas { get; set; }
        public MaximaRepeticion MaximaRepeticions { get; set; }
    }
}
