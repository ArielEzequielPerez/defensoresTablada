using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace defensoresTablada.Models.BBDD
{
    public class Cliente : IDBase

    {
        public List<Rutina> Rutinas { get; set; }
        public List<MaximaRepeticion> MaximasRepeticiones { get; set; }

       

    }
}
