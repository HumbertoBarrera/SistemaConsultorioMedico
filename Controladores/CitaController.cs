using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico;
using System.Data.SqlClient;


namespace SistemaConsultorioMedico.Controladores
{
    class CitaController
    {

        public static void insertarCita(Modelos.Cita c)
        {
            SqlCommand comando;
            comando = new SqlCommand("INSERT INTO CITA VALUES ('" + c.getIdPaciente() + "','" + c.getFecha() + "','" + c.getHora() + "')", Controladores.ConexionController.Conectar());
            int r = comando.ExecuteNonQuery();


        }
    }
}