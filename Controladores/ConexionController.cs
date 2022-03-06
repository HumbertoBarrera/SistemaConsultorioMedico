using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaConsultorioMedico.Controladores
{
    class ConexionController
    {
        private static string connection = "SERVER=OSCARLOPEZ; DATABASE=CONSULTORIO; Integrated Security=true";
        
        /// <summary>
        /// Método para conectarse a la base de datos.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(connection);
            cn.Open();
            return cn;
        }

        /// <summary>
        /// Método para cerrar la conexión a la base de datos.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection Desconectar()
        {
            SqlConnection cn = new SqlConnection(connection);
            cn.Close();
            return cn;
        }

    }
}
