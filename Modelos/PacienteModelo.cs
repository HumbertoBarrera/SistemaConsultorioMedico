using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class PacienteModelo
    {

        public int idPaciente { get; set; }

        public String nombresP { get; set; }

        public String apellidoPatP { get; set; }

        public String apellidoMatP { get; set; }

        public DateTime fechaNac { get; set; }

        public int edad { get; set; }

        public String lugarNac { get; set; }

        public String direccionP { get; set; }

        public String telefonoP { get; set; }

        public String emailP { get; set; }

        public String telefonoTrabajoP { get; set; }

        public String lugarTrabajoP { get; set; }

    }
}
