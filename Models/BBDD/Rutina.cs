using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace defensoresTablada.Models.BBDD
{
    public class Rutina : IDBase
    {
        [Required]
        public string NombreDeEjercicio { get; set; }

        [Required]
        public int Repeticion { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public int Serie { get; set; }

    }
}
