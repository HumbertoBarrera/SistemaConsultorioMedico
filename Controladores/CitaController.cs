using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico;
using System.Windows.Forms;
using System.Data.SqlClient;


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
            //SqlCommand comando;
            //comando = new SqlCommand("INSERT INTO CITA VALUES ('" + c.getIdPaciente() + "','" + c.getFecha() + "','" + c.getHora() + "')", Controladores.ConexionController.Conectar());
            //int r = comando.ExecuteNonQuery();
            // SqlDataReader leer = comando.ExecuteReader();

            //if (r==1)
            //{
            //    MessageBox.Show("Cita Agregada con exito");

            //}
            //else
            //{
            //    MessageBox.Show("Cita no agregada");

            //}

        }
    }
}