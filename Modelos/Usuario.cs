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
        String usuario, password, rol;

        public Usuario() { }

        /// <summary>
        /// Método constructor del objeto Usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <param name="rol"></param>
        public Usuario(int idUsuario, String usuario, String password, String rol)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.password = password;
            this.rol = rol;
        }

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
        /// Settea el rol del usuario.
        /// </summary>
        /// <param name="rol"></param>
        public void setRol(String rol)
        {
            this.rol = rol;
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

        /// <summary>
        /// Obtiene el rol del usuario
        /// </summary>
        /// <returns></returns>
        public String getRol()
        {
            return rol;
        }

    }
}
