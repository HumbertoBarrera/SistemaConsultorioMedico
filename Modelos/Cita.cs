using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class Cita
    {
        string folioCita;
        int idPaciente;
        DateTime fecha;
        TimeSpan hora;

        public void setFolioCita(string folioCita)
        {
            this.folioCita= folioCita;
        }

        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void setHora(TimeSpan hora)
        {
            this.hora = hora;
        }

        public string getFolioCita()
        {
            return folioCita;
        }

        public int getIdPaciente()
        {
            return idPaciente;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public TimeSpan getHora()
        {
            return hora;
        }



    }
}
