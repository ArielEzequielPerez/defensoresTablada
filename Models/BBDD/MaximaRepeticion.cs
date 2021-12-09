using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace defensoresTablada.Models.BBDD
{
    public class MaximaRepeticion : IDBase
    {
        [Required]
        public int Repeticion { get; set; }
        [Required]
        public float Peso { get; set; }
      

    }
}
