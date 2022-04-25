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

        /// <summary>
        /// Método para settear el identificador del paciente. El ID se manda como parámetro del método.
        /// </summary>
        /// <param name="idPaciente"></param>
        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente; //Define el ID con el paciente ingresado
        }

        /// <summary>
        /// Método para settear el folio del diagnóstico registrado. EL folio es mandado como parámetro.
        /// </summary>
        /// <param name="folioDiagnostico"></param>
        public void setFolioDiagnostico(String folioDiagnostico)
        {
            this.folioDiagnostico = folioDiagnostico; //Define el folio creado
        }

        /// <summary>
        /// Método para settear la fecha de registro del diagnóstico.
        /// </summary>
        /// <param name="fecha"></param>
        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha; //Define la fecha actual
        }

        /// <summary>
        /// Método para settear la descripción ´del diagnóstico generado. 
        /// </summary>
        /// <param name="descripcion"></param>
        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion; //Define la descripcion ingresada
        }

        /// <summary>
        /// Método para obtener el ID del paciente registrado en el diagnóstico.
        /// </summary>
        public int getIdPaciente()
        {
            return idPaciente; //Obtiene id del paciente ingresado
        }
        
        /// <summary>
        /// Método para obtener el folio del diagnóstico generado.
        /// </summary>
        public String getFolioDiagnostico()
        {
            return folioDiagnostico; //Obtiene el folio
        }

        /// <summary>
        /// Método para obtener la fecha
        /// </summary>
        public DateTime getFecha()
        {
            return fecha; //Obtiene la fecha actual
        }

        /// <summary>
        /// Método para obtener la descripción del diagnóstico.
        /// </summary>
        public String getDescripcion()
        {
            return descripcion; //Obtiene la descripcion ingresada
        }

    }
}

