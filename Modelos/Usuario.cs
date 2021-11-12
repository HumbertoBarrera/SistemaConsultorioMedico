using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class Usuario
    {

        int idUsuario;
        String usuario, password;

        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public int getIdUsuario()
        {
            return idUsuario;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public String getPassword()
        {
            return password;
        }

    }
}
