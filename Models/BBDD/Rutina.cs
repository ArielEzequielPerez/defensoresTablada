using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace defensoresTablada.Models.BBDD
{
    public class Rutina
    {
        public int IdUsuario { get; set; }

        [Required]
        public string NombreDeEjercicio {get; set;}

        [Required]
        public int Serie { get; set; }

        [Required]
        public int Repeticion { get; set; }
        

    }
}
