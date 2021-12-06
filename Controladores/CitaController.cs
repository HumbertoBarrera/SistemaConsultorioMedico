using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaConsultorioMedico.Controladores
{
    class CitaController
    {

        public static void insertarCita(Modelos.Cita c)
        {
            String query = "INSERT INTO CITA VALUES (@idPaciente, @fecha, @hora)";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    comando.Parameters.Add("@idPaciente", c.getIdPaciente());
                    comando.Parameters.Add("@fecha", c.getFecha());
                    comando.Parameters.Add("@hora", c.getHora());
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cita agregada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
        }
        public DataTable CargarGridCitas()
        {
            String query = "select idPaciente,LEFT(fecha,10),hora from cita";

                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    return tabla;
                }
        }

        public static void EliminarCita(Modelos.Cita c)
        {
            String query = "DELETE FROM CITA WHERE idPaciente='"+c.getIdPaciente()+"' AND fecha='" + c.getFecha() + "' AND hora='" + c.getHora()+"'";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                 
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al Eliminar Cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cita Eliminada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
        }

    }
    
}