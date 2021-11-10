using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaConsultorioMedico.Controladores
{
    class PacienteController
    {

        public static void altaPaciente(Modelos.Paciente p)
        {
            String query = "INSERT INTO PACIENTE VALUES (@idPaciente, @nombresP, @apellidoPatP, @apellidoMatP, @fechaNac, @edadP, @lugarNac, @direccionP, @telefonoP, @emailP, @trabajoP, @lugarTrabajoP)";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPaciente", p.getIdPaciente());
                    comando.Parameters.AddWithValue("@nombresP", p.getNombresP());
                    comando.Parameters.AddWithValue("@apellidoPatP", p.getApellitosPatP());
                    comando.Parameters.AddWithValue("@apellidoMatP", p.getApellidosMatP());
                    comando.Parameters.AddWithValue("@fechaNac", p.getFechaNac());
                    comando.Parameters.AddWithValue("@edadP", p.getEdad());
                    comando.Parameters.AddWithValue("@lugarNac", p.getLugarNac());
                    comando.Parameters.AddWithValue("@direccionP", p.getDireccionP());
                    comando.Parameters.AddWithValue("@telefonoP", p.getTelefonoP());
                    comando.Parameters.AddWithValue("@emailP", p.getEmailP());
                    comando.Parameters.AddWithValue("@trabajoP", p.getTrabajoP());
                    comando.Parameters.AddWithValue("@lugarTrabajoP", p.getTelefonoTrabajoP());
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al insertar en la bd", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Paciente agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

    }
}
