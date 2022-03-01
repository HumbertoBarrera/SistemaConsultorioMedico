using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    public class Paciente
    {

        private int idPaciente, edad;
        private String nombresP, apellidoPatP, apellidoMatP, lugarNac, direccionP, telefonoP, emailP, trabajoP, telefonoTrabajoP, lugarTrabajoP;
        private DateTime fechaNac;

        // Estructura del modelo de paciente

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

        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        public void setNombresP(String nombresP)
        {
            this.nombresP = nombresP;
        }

        public void setApellidoPatP(String apellidoPatP)
        {
            this.apellidoPatP = apellidoPatP;
        }

        public void setApellidoMatP(String apellidoMatP)
        {
            this.apellidoMatP = apellidoMatP;
        }

        public void setFechaNac(DateTime fechaNac)
        {
            this.fechaNac = fechaNac;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setLugarNac(String lugarNac)
        {
            this.lugarNac = lugarNac;
        }

        public void setDireccionP(String direccionP)
        {
            this.direccionP = direccionP;
        }

        public void setTelefonoP(String telefonoP)
        {
            this.telefonoP = telefonoP;
        }

        public void setEmailP(String emailP)
        {
            this.emailP = emailP;
        }

        public void setTrabajoP(String trabajoP)
        {
            this.trabajoP = trabajoP;
        }

        public void setTelefonoTrabajoP(String telefonoTrabajoP)
        {
            this.telefonoTrabajoP = telefonoTrabajoP;
        }

        public void setLugarTrabajoP(String lugarTrabajoP)
        {
            this.lugarTrabajoP = lugarTrabajoP;
        }

        // Métodos getters del modelo de paciente

        public int getIdPaciente()
        {
            return idPaciente;
        }

        public String getNombresP()
        {
            return nombresP;
        }

        public String getApellitosPatP()
        {
            return apellidoPatP;
        }

        public String getApellidosMatP()
        {
            return apellidoMatP;
        }

        public DateTime getFechaNac()
        {
            return fechaNac;
        }

        public int getEdad()
        {
            return edad;
        }

        public String getLugarNac()
        {
            return lugarNac;
        }

        public String getDireccionP()
        {
            return direccionP;
        }

        public String getTelefonoP()
        {
            return telefonoP;
        }

        public String getEmailP()
        {
            return emailP;
        }

        public String getTrabajoP()
        {
            return trabajoP;
        }

        public String getTelefonoTrabajoP()
        {
            return telefonoTrabajoP;
        }

        public String getLugarTrabajoP()
        {
            return lugarTrabajoP;
        }

    }
}
