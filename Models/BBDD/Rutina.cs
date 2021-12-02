using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace defensoresTablada.Models.BBDD
{
    public class Rutina : Ejericicio
    {
        [Required]
        public int Serie { get; set; }

    }
}
