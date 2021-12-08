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

        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-M42Q3PRP\\HARORUIZ; DATABASE=CONSULTORIO; Integrated Security=true");
            cn.Open();
            return cn;
        }

        public static SqlConnection Desconectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-M42Q3PRP\\HARORUIZ; DATABASE=CONSULTORIO; Integrated Security=true");
            cn.Close();
            return cn;
        }

    }
}
