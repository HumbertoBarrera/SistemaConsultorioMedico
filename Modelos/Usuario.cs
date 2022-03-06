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
        //Setters y getter dek objeto
        /// <summary>
        /// Settea el identificador del usuario.
        /// </summary>
        /// <param name="idUsuario"></param>
        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        /// <summary>
        /// Settea el nombre del usuario.
        /// </summary>
        /// <param name="usuario"></param>
        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        /// <summary>
        /// Settea la contraseña del usuario.
        /// </summary>
        /// <param name="password"></param>
        public void setPassword(String password)
        {
            this.password = password;
        }

        /// <summary>
        /// Obtiene el identificador del usuario.
        /// </summary>
        /// <returns></returns>
        public int getIdUsuario()
        {
            return idUsuario;
        }

        /// <summary>
        /// Obtiene el nombre del usuario.
        /// </summary>
        /// <returns></returns>
        public String getUsuario()
        {
            return usuario;
        }

        /// <summary>
        /// Obtiene la contraseña del usuario.
        /// </summary>
        /// <returns></returns>
        public String getPassword()
        {
            return password;
        }

    }
}
