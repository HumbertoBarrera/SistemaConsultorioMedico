using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;

namespace SistemaConsultorioMedico.Interfaces
{
    public interface IPacienteController
    {

        bool RegistrarPaciente(Modelos.Paciente p);

        bool ActualizarPaciente(Modelos.Paciente p);

        bool ValidarSiExistePaciente(int idPaciente);

    }
}
