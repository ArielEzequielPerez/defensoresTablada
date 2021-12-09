using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace defensoresTablada.Models.BBDD
{
    public class Profesional : IDBase
    {
        public string Apellido { get; set; }
        public List<Cliente> Clientes { get; set; }

    }
}
