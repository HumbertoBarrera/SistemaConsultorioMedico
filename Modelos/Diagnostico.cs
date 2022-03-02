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

        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente; //Define el ID con el paciente ingresado
        }

        public void setFolioDiagnostico(String folioDiagnostico)
        {
            this.folioDiagnostico = folioDiagnostico; //Define el folio creado
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha; //Define la fecha actual
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion; //Define la descripcion ingresada
        }

        public int getIdPaciente()
        {
            return idPaciente; //Obtiene id del paciente ingresado
        }
        
        public String getFolioDiagnostico()
        {
            return folioDiagnostico; //Obtiene el folio
        }
        public DateTime getFecha()
        {
            return fecha; //Obtiene la fecha actual
        }
        public String getDescripcion()
        {
            return descripcion; //Obtiene la descripcion ingresada
        }

    }
}

