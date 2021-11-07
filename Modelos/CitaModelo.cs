using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class CitaModelo
    {

        public int idPaciente { get; set; }

        public DateTime fecha { get; set; }

        public TimeSpan hora { get; set; }

    }
}
