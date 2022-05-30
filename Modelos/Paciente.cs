using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Interfaces;

namespace SistemaConsultorioMedico.Modelos
{
    public class Paciente
    {

        private int idPaciente, edad;
        private String nombresP, apellidoPatP, apellidoMatP, lugarNac, direccionP, telefonoP, emailP, trabajoP, telefonoTrabajoP, lugarTrabajoP;
        private DateTime fechaNac;

        // Estructura del modelo de paciente

        public Paciente() { }

        /// <summary>
        /// Método constructor del objeto Paciente.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <param name="edad"></param>
        /// <param name="nombresP"></param>
        /// <param name="apellidoPatP"></param>
        /// <param name="apellidoMatP"></param>
        /// <param name="lugarNac"></param>
        /// <param name="direccionP"></param>
        /// <param name="telefonoP"></param>
        /// <param name="emailP"></param>
        /// <param name="trabajoP"></param>
        /// <param name="telefonoTrabajoP"></param>
        /// <param name="lugarTrabajoP"></param>
        /// <param name="fechaNac"></param>
        public Paciente(int idPaciente, int edad, String nombresP, String apellidoPatP, String apellidoMatP, String lugarNac, String direccionP,
                        String telefonoP, String emailP, String trabajoP, String telefonoTrabajoP, String lugarTrabajoP, DateTime fechaNac)
        {
            this.idPaciente = idPaciente;
            this.nombresP = nombresP;
            this.apellidoPatP = apellidoPatP;
            this.apellidoMatP = apellidoMatP;
            this.fechaNac = fechaNac;
            this.edad = edad;
            this.lugarNac = lugarNac;
            this.direccionP = direccionP;
            this.telefonoP = telefonoP;
            this.emailP = emailP;
            this.trabajoP = trabajoP;
            this.telefonoTrabajoP = telefonoTrabajoP;
            this.lugarTrabajoP = lugarTrabajoP;
        }

        // Métodos setters del modelo de paciente

        /// <summary>
        /// Método que settea el identificador de la paciente. Se genera automáticamente el ID.
        /// </summary>
        /// <param name="idPaciente"></param>
        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        /// <summary>
        /// Método que settea el nombre de la paciente.
        /// </summary>
        /// <param name="nombresP"></param>
        public void setNombresP(String nombresP)
        {
            this.nombresP = nombresP;
        }

        /// <summary>
        /// Método que settea el apellido paterno de la paciente.
        /// </summary>
        /// <param name="apellidoPatP"></param>
        public void setApellidoPatP(String apellidoPatP)
        {
            this.apellidoPatP = apellidoPatP;
        }

        /// <summary>
        /// Método que settea el apellido materno de la paciente.
        /// </summary>
        /// <param name="apellidoMatP"></param>
        public void setApellidoMatP(String apellidoMatP)
        {
            this.apellidoMatP = apellidoMatP;
        }

        /// <summary>
        /// Método que settea la fecha de nacimiento de la paciente.
        /// </summary>
        /// <param name="fechaNac"></param>
        public void setFechaNac(DateTime fechaNac)
        {
            this.fechaNac = fechaNac;
        }

        /// <summary>
        /// Método que settea la edad de la paciente. Se calcula de forma automática con la fecha de nacimiento.
        /// </summary>
        /// <param name="edad"></param>
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        /// <summary>
        /// Método que settea el lugar de nacimiento de la paciente.
        /// </summary>
        /// <param name="lugarNac"></param>
        public void setLugarNac(String lugarNac)
        {
            this.lugarNac = lugarNac;
        }

        /// <summary>
        /// Método que settea la dirección de la paciente.
        /// </summary>
        /// <param name="direccionP"></param>
        public void setDireccionP(String direccionP)
        {
            this.direccionP = direccionP;
        }

        /// <summary>
        /// Método que settea el teléfono celular de la paciente.
        /// </summary>
        /// <param name="telefonoP"></param>
        public void setTelefonoP(String telefonoP)
        {
            this.telefonoP = telefonoP;
        }

        /// <summary>
        /// Método que settea el correo electrónico de la paciente.
        /// </summary>
        /// <param name="emailP"></param>
        public void setEmailP(String emailP)
        {
            this.emailP = emailP;
        }

        /// <summary>
        /// Método que settea el trabajo de la paciente.
        /// </summary>
        /// <param name="trabajoP"></param>
        public void setTrabajoP(String trabajoP)
        {
            this.trabajoP = trabajoP;
        }

        /// <summary>
        /// Método que settea el teléfono del trabajo de la paciente.
        /// </summary>
        /// <param name="telefonoTrabajoP"></param>
        public void setTelefonoTrabajoP(String telefonoTrabajoP)
        {
            this.telefonoTrabajoP = telefonoTrabajoP;
        }

        /// <summary>
        /// Método que settea el lugar de trabajo de la paciente.
        /// </summary>
        /// <param name="lugarTrabajoP"></param>
        public void setLugarTrabajoP(String lugarTrabajoP)
        {
            this.lugarTrabajoP = lugarTrabajoP;
        }

        // Métodos getters del modelo de paciente

        /// <summary>
        /// Obtiene el identficador de la paciente.
        /// </summary>
        /// <returns></returns>
        public int getIdPaciente()
        {
            return idPaciente;
        }

        /// <summary>
        /// Obtiene el nombre de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getNombresP()
        {
            return nombresP;
        }

        /// <summary>
        /// Obtiene el apellido paterno de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getApellitosPatP()
        {
            return apellidoPatP;
        }

        /// <summary>
        /// Obtiene el apellido materno de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getApellidosMatP()
        {
            return apellidoMatP;
        }

        /// <summary>
        /// Obtiene la fecha de nacimiento de la paciente.
        /// </summary>
        /// <returns></returns>
        public DateTime getFechaNac()
        {
            return fechaNac;
        }

        /// <summary>
        /// Obtiene la edad de la paciente.
        /// </summary>
        /// <returns></returns>
        public int getEdad()
        {
            return edad;
        }

        /// <summary>
        /// Obtiene el lugar de nacimiento de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getLugarNac()
        {
            return lugarNac;
        }

        /// <summary>
        /// Obtiene la dirección de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getDireccionP()
        {
            return direccionP;
        }

        /// <summary>
        /// Obtiene el teléfono de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getTelefonoP()
        {
            return telefonoP;
        }

        /// <summary>
        /// Obtiene el correo electrónico de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getEmailP()
        {
            return emailP;
        }

        /// <summary>
        /// Obtiene el trabajo de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getTrabajoP()
        {
            return trabajoP;
        }

        /// <summary>
        /// Obteiene el teléfono del trabajo de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getTelefonoTrabajoP()
        {
            return telefonoTrabajoP;
        }

        /// <summary>
        /// Obtiene el lugar de trabajo de la paciente.
        /// </summary>
        /// <returns></returns>
        public String getLugarTrabajoP()
        {
            return lugarTrabajoP;
        }

    }
}
