using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;

namespace SistemaConsultorioMedico.Interfaces
{
    public interface ICitaController
    {

        bool InsertarCita(Cita c);

        bool EliminarCita(Cita c);

        bool ModificarCita(Cita c);

        String CrearFolio(Cita c);

    }
}
