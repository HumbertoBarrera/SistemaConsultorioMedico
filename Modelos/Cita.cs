using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    public class Cita
    {
        public string folioCita;
        public int idPaciente;
        public DateTime fecha;
        public TimeSpan hora;

        /// <summary>
        /// Método para settear el folio identificador de la cita.
        /// </summary>
        /// <param name="folioCita"></param>
        public void setFolioCita(string folioCita)
        {
            this.folioCita= folioCita;
        }

        /// <summary>
        /// Método para settear el identificador del paciente.
        /// </summary>
        /// <param name="idPaciente"></param>
        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        /// <summary>
        /// Método para settear la fecha de la cita.
        /// </summary>
        /// <param name="fecha"></param>
        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        /// <summary>
        /// Método para settear la hora de la cita.
        /// </summary>
        /// <param name="hora"></param>
        public void setHora(TimeSpan hora)
        {
            this.hora = hora;
        }

        /// <summary>
        /// Método para obtener el folio identificador generado de la cita.
        /// </summary>
        public string getFolioCita()
        {
            return folioCita;
        }

        /// <summary>
        /// Método para obtener el identificador generado del paciente.
        /// </summary>
        public int getIdPaciente()
        {
            return idPaciente;
        }

        /// <summary>
        /// Método para obtener la fecha de la cita.
        /// </summary>
        public DateTime getFecha()
        {
            return fecha;
        }

        /// <summary>
        /// Método para obtener la hora de la cita.
        /// </summary>
        public TimeSpan getHora()
        {
            return hora;
        }

    }
}
