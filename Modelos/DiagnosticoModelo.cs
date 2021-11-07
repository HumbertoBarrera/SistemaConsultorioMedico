using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class DiagnosticoModelo
    {

        public int idPaciente { get; set; }

        public int folioDiagnostico { get; set; }

        public DateTime fecha { get; set; }

        public String descripcion { get; set; }

    }
}
