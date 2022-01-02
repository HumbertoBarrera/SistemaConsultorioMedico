using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


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
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

        public DataTable CargarGridPacientes()
        {
            String query = "SELECT idPaciente, nombresP, apellidoPatP, apellidoMatP, fechaNac, edadP, lugarNac, direccionP, telefonoP, emailP,trabajoP, lugarTrabajoP FROM PACIENTE";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                return tabla;
            }
        }

        public static void ActualizarPaciente(Modelos.Paciente p)
        {
            String query = "UPDATE PACIENTE SET nombresP='" + p.getNombresP() + "', apellidoPatP='" + p.getApellitosPatP() + "', apellidoMatP='" + p.getApellidosMatP() + "', fechaNac='" + p.getFechaNac().ToString("yyyy/MM/dd") + "', edadP='" + p.getEdad() + "', lugarNac='" + p.getLugarNac() + "', direccionP='" + p.getDireccionP() + "', telefonoP='" + p.getTelefonoP() + "', emailP='" + p.getEmailP() + "',trabajoP='" + p.getTrabajoP() + "', lugarTrabajoP='" + p.getLugarTrabajoP() + "' WHERE idPaciente='" + p.getIdPaciente() + "'";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al actualizar paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Paciente actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

        public static void EliminarPaciente(Modelos.Paciente p)
        {
            try
            {
                String query = "DELETE FROM CITA WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al eliminar citas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Citas eliminadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                query = "DELETE FROM DIAGNOSTICO WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al eliminar diagnosticos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Diagnosticos eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                query = "DELETE FROM INFORMACIONMEDICA WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al eliminar info medica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Info medica eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                query = "DELETE FROM PACIENTE WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al eliminar paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Paciente eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

        public static bool validaExisPaciente(int idPaciente)
        {
            String query = "SELECT * FROM Paciente WHERE idPaciente='" + idPaciente.ToString() + "'";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
}
