    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacunaApp.Models
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string cedula { get; set; }

        public string telefono { get; set; }

        public string provincia{ get; set; }

        public string vacunaRecibida { get; set; }
        public DateTime fecha{ get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
