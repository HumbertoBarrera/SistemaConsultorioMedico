using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;
using SistemaConsultorioMedico.Interfaces;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace SistemaConsultorioMedico.Controladores
{
    public class PacienteController : IPacienteController
    {

        static int intTuplasManipuladas = 0;

        // Método para dar de alta al paciente en la base de datos
        /// <summary>
        /// Registra a la paciente a la base de datos.
        /// </summary>
        /// <param name="p"></param>
        public bool RegistrarPaciente(Modelos.Paciente p)
        {
            bool result = false;
            // Creamos el query a utilizar
            String query = "INSERT INTO PACIENTE VALUES (@idPaciente, @nombresP, @apellidoPatP, @apellidoMatP, @fechaNac, @edadP, @lugarNac, @direccionP, " +
                "@telefonoP, @emailP, @trabajoP, @lugarTrabajoP)";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    // Introducimos los valores a la manipulación de la base de datos
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
                    int resultado = comando.ExecuteNonQuery(); // Variable que representa el número de tuplas manipuladas
                    if (resultado < intTuplasManipuladas) // Validamos que por lo menos haya una tupla manipulada
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                    {
                        MessageBox.Show("Paciente agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                        result = true;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message); // Recuperamos el error que haya lanzado SQL y lo mostramos en pantalla
            }
            finally
            {
                ConexionController.Desconectar(); // Cerramos conexión
            }
            return result;
        }

        /* Método para cargar los datos de la tabla de pacientes
         * a un data grid
         */
        /// <summary>
        /// Carga a los pacientes de la base de datos y los muestra en el sistema.
        /// </summary>
        /// <returns></returns>
        public DataTable CargarGridPacientes()
        {
            // Creamos el query a utilizar
            String query = "SELECT idPaciente, nombresP, apellidoPatP, apellidoMatP, fechaNac, edadP, lugarNac, direccionP, telefonoP, emailP, " +
                "trabajoP, lugarTrabajoP FROM PACIENTE";
            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataAdapter data = new SqlDataAdapter(comando); // Se recuperan los datos de la tabla
                DataTable tabla = new DataTable(); // Creamos una variable de tipo tabla de datos
                data.Fill(tabla); // Llenamos la tabla de datos con la información recuperada
                return tabla; // Regresamos dicha tabla
            }
        }

        // Método para hacer update a la información del paciente
        /// <summary>
        /// Modifica la información de la paciente en la base de datos.
        /// </summary>
        /// <param name="p"></param>
        public bool ActualizarPaciente(Modelos.Paciente p)
        {
            bool result = false;
            // Creamos query ya con los datos integrados
            String query = "UPDATE PACIENTE SET nombresP='" + p.getNombresP() + "', apellidoPatP='" + p.getApellitosPatP() + "', apellidoMatP='" + 
                p.getApellidosMatP() + "', fechaNac='" + p.getFechaNac().ToString("yyyy/MM/dd") + "', edadP='" + p.getEdad() + "', lugarNac='" + p.getLugarNac() +
                "', direccionP='" + p.getDireccionP() + "', telefonoP='" + p.getTelefonoP() + "', emailP='" + p.getEmailP() + "',trabajoP='" + p.getTrabajoP() + 
                "', lugarTrabajoP='" + p.getLugarTrabajoP() + "' WHERE idPaciente='" + p.getIdPaciente() + "'";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery(); // Variable que representa el número de tuplas manipuladas
                    if (resultado < intTuplasManipuladas) // Validamos que por lo menos haya una tupla manipulada
                        MessageBox.Show("Error al actualizar paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                    {
                        MessageBox.Show("Paciente actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                        result = true;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message); // Recuperamos el error que haya lanzado SQL y lo mostramos en pantalla
            }
            finally
            {
                ConexionController.Desconectar(); // Cerramos conexión
            }
            return result;
        }

        // Método para eliminar a un paciente de la base de datos
        /// <summary>
        /// Elimina a la paciente de la base de datos.
        /// </summary>
        /// <param name="p"></param>
        public void EliminarPaciente(Modelos.Paciente p)
        {
            try
            {
                // Creamos el query, eliminando citas del paciente eliminado
                String query = "DELETE FROM CITA WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery(); // Variable que representa el número de tuplas manipuladas
                    if (resultado < intTuplasManipuladas) // Validamos que por lo menos haya una tupla manipulada 
                        MessageBox.Show("Error al eliminar citas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                        MessageBox.Show("Citas eliminadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                }

                // Actualizamos query para eliminar el diagnóstico del paciente
                query = "DELETE FROM DIAGNOSTICO WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplasManipuladas)
                        MessageBox.Show("Error al eliminar diagnosticos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                        MessageBox.Show("Diagnosticos eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                }

                // Actualizamos query para  eliminar la información médica del paciente
                query = "DELETE FROM INFORMACIONMEDICA WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplasManipuladas)
                        MessageBox.Show("Error al eliminar info medica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                        MessageBox.Show("Info medica eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                }

                // Actualizamos query para eliminar al paciente
                query = "DELETE FROM PACIENTE WHERE idPaciente='" + p.getIdPaciente() + "'";
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplasManipuladas)
                        MessageBox.Show("Error al eliminar paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación exitosa
                    else
                        MessageBox.Show("Paciente eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación no exitosa
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

        /* Este método consiste en validar si el paciente existe
         * haciendo un barrido a la tabla de pacientes, buscando
         * por el ID del paciente
         */
        /// <summary>
        /// Valida si existe la paciente en la base de datos.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <returns></returns>
        public bool ValidarSiExistePaciente(int idPaciente)
        {
            // Query para buscar al paciente
            String query = "SELECT * FROM Paciente WHERE idPaciente='" + idPaciente.ToString() + "'";
            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read()) // Valida si la variable de tipo data reader leýo algo en la base de datos, es decir, encontró el dato
                    return true;
                else
                    return false;
            }

        }

    }
}
