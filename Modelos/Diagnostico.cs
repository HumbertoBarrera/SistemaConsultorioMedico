using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class Diagnostico
    {
        private int idPaciente;
        private DateTime fecha;
        private String descripcion, folioDiagnostico;

        public Diagnostico()
        {

        }

        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }
        public void setFolioDiagnostico(String folioDiagnostico)
        {
            this.folioDiagnostico = folioDiagnostico;
        }


        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public int getIdPaciente()
        {
            return idPaciente;
        }

        public String getFolioDiagnostico()
        {
            return folioDiagnostico;
        }
        public DateTime getFecha()
        {
            return fecha;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

    }
}

