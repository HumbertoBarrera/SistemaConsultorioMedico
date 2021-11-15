using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaConsultorioMedico.Modelos;


namespace SistemaConsultorioMedico.Controladores
{
    class DiagnosticoController
    {

        public static void insertarDiagnostico(Modelos.Diagnostico d)
        {

            SqlCommand comando;
            comando = new SqlCommand("INSERT INTO DIAGNOSTICO VALUES ('" + d.getIdPaciente() + "','" + d.getFolioDiagnostico() + "','" + d.getFecha() + "','" + d.getDescripcion() + "')", Controladores.ConexionController.Conectar());
            int r = comando.ExecuteNonQuery();

            if (r == 1)
            {
                MessageBox.Show("Diagnostico Agregado con exito");

            }
            else
            {
                MessageBox.Show("Diasgnostico no agregad0");

            }
        }

        public static void folio(Modelos.Diagnostico d)
        {
            SqlCommand codigo;
            codigo = new SqlCommand("SELECT CONCAT(RIGHT(idPaciente,2),CONVERT(VARCHAR(2), GETDATE(), 103),SUBSTRING(CONVERT(VARCHAR(10),GETDATE(), 103), 4, 2),SUBSTRING(CONVERT(VARCHAR(10), GETDATE(), 103), 7, 4), CONVERT(nvarchar(2), GETDATE(), 108),SUBSTRING(CONVERT(nvarchar(5), GETDATE(), 108), 4, 2)) As folio FROM PACIENTE WHERE idPaciente ='" + d.getIdPaciente() + "'", Controladores.ConexionController.Conectar());
            SqlDataReader resultado = codigo.ExecuteReader();

            if (resultado.Read())
            {
                string res = resultado[0].ToString();
                d.setFolioDiagnostico(res);

            }


        }
    }
}
