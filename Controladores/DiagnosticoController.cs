using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaConsultorioMedico.Modelos;
using System.Data.SqlClient;
using System.Data;


namespace SistemaConsultorioMedico.Controladores
{
    class DiagnosticoController
    {

        static int intTuplasManipuladas = 0;

        /// <summary>
        /// Método para registrar el diagnóstico en la base de datos.
        /// </summary>
        /// <param name="d"></param>
        public static void insertarDiagnostico(Modelos.Diagnostico d)
        {
            String query = "INSERT INTO DIAGNOSTICO VALUES (@idPaciente, @folioDiagnostico, @fecha, @descripcion)";
            try
            {
                using(SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPaciente", d.getIdPaciente());
                    comando.Parameters.AddWithValue("@folioDiagnostico", d.getFolioDiagnostico());
                    comando.Parameters.AddWithValue("@fecha", d.getFecha());
                    comando.Parameters.AddWithValue("@descripcion", d.getDescripcion());
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplasManipuladas)
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Diagnóstico agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
        }

        /// <summary>
        /// Crea el folio del diagnóstico.
        /// </summary>
        /// <param name="d"></param>
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


        public static void diagnostico(Modelos.Diagnostico d)
        {

            String query = "SELECT * FROM DIAGNOSTICO WHERE idPaciente=@idPaciente";

            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPaciente", d.getIdPaciente());

                    SqlDataReader resultado = comando.ExecuteReader();

                    if (resultado.Read())
                    {
                    }
                    else
                    {
                       
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }


        }

        /// <summary>
        /// Carga el diagnóstico de la base de datos al sistema.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public DataTable CargarGridDiagnostico(Modelos.Diagnostico d)
        {
            String query = "SELECT folioDiagostico,LEFT(fecha,10),descripcion FROM DIAGNOSTICO WHERE idPaciente=@idPaciente";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                comando.Parameters.AddWithValue("@idPaciente", d.getIdPaciente());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                return tabla;
            }
        }

        //---------------------------------------Validaciones----------------------------------
        /// <summary>
        /// Valida si existe el paciente.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool validaExisPaciente(Modelos.Diagnostico d)
        {
            String query = "SELECT * FROM Paciente WHERE idPaciente='" + d.getIdPaciente() + "'";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                    return true;
                else
                    return false;
            }

        }
    }
}
