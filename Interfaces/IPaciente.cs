using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Interfaces
{
    public interface IPaciente
    {

        void setIdPaciente(int idPaciente);

        void setNombresP(String nombresP);

        void setApellidoPatP(String apellidoPatP);

        void setApellidoMatP(String apellidoMatM);

        void fechaNacP(DateTime fechaNacP);

        void setEdad(String edad);

        void setLugarNac(String lugarNac);

        void setDireccionP(String direccionP);

        void setTelefonoP(String telefonoP);

        void setEmailP(String emailP);

        void setTrabajoP(String trabajoP);

        void setTelefonoTrabajoP(String telefonoTrabajoP);

        void setLugarTrabajo(String lugarTrabajoP);

        int getIdPaciente();

        String getNombresP();

        String getApellidoPatP();

        String getApellidoMatP();

        DateTime getFechaNacP();

        int getEdad();

        String getLugarNac();

        String getDireccionP();

        String getTelefonoP();

        String getEmailP();

        String getTrabajoP();

        String getTelefonoTrabajoP();

        String getLugarTrabajo();

    }
}
