using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace defensoresTablada.Models.BBDD
{
    public class Rutina : IDBase
    {
        [Required]
        public int Repeticion { get; set; }
        [Required]
        public float Peso { get; set; }
        [Required]
        public int Serie { get; set; }

        public byte Imagen { get; set; }

    }
}
