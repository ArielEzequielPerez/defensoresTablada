﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace defensoresTablada.Models.BBDD
{
    public class Ejericicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string NombreDeEjercicio { get; set; }

        [Required]
        public int Repeticion { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public DateTime Fecha { get; set; }

    }
}