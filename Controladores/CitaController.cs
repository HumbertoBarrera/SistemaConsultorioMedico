using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using SistemaConsultorioMedico.Interfaces;

namespace SistemaConsultorioMedico.Controladores
{
    class CitaController : ICitaController
    {

        DateTime fecha;
        static int intTuplaManipulada = 0;

        /// <summary>
        /// Registra la cita en la base de datos.
        /// </summary>
        /// <param name="c"></param>
        public bool InsertarCita(Modelos.Cita c)
        {
            bool result = false;
            String query = "INSERT INTO CITA VALUES (@idPaciente, @fecha, @hora, @folioCita)";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    comando.Parameters.Add("@idPaciente", c.getIdPaciente());
                    comando.Parameters.Add("@fecha", c.getFecha());
                    comando.Parameters.Add("@hora", c.getHora());
                    comando.Parameters.Add("@folioCita", c.getFolioCita());
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplaManipulada)
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Cita agregada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = true;
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
            return result;
        }

        /// <summary>
        /// Muestra las citas registradas en el sistema.
        /// </summary>
        /// <returns></returns>
        public DataTable CargarGridCitas()
        {
            fecha = DateTime.Now;
            String query = "SELECT c.idPaciente,CONCAT(p.nombresP, ' ',p.apellidoPatP, ' ',p.apellidoMatP) AS nombre,LEFT(c.fecha,10),c.hora,c.folioCita FROM CITA " +
                "C INNER JOIN PACIENTE p ON C.idPaciente = p.idPaciente WHERE c.fecha >='" +fecha.ToString("yyyy/MM/dd") + "' ORDER BY c.fecha ASC";

                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    return tabla;
                }
        }

        /// <summary>
        /// Elimina la cita de la base de datos.
        /// </summary>
        /// <param name="c"></param>
        public bool EliminarCita(Modelos.Cita c)
        {
            bool result = false;
            String query = "DELETE FROM CITA WHERE idPaciente='"+c.getIdPaciente()+"' AND fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' AND hora='" + 
                c.getHora()+ "' AND folioCita='" + c.getFolioCita() + "'";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplaManipulada)
                        MessageBox.Show("Error al Eliminar Cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Cita Eliminada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = true;
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
            return result;
        }

        /// <summary>
        /// Modifica la cita de la base de datos.
        /// </summary>
        /// <param name="c"></param>
        public bool ModificarCita(Modelos.Cita c) {
            bool result = false;
            String query = "UPDATE CITA SET fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' , hora='" + c.getHora() + "' WHERE folioCita='" + 
                c.getFolioCita() + "'";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < intTuplaManipulada)
                        MessageBox.Show("Error al Modificar Cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Cita Modificada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = true;
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
            return result;
        }

        /// <summary>
        /// Genera el folio de la cita.
        /// </summary>
        /// <param name="c"></param>
        public String CrearFolio(Modelos.Cita c)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 8;
            string folioCitaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++) // Control de la longitud del folio
            {
                letra = caracteres[rdn.Next(longitud)]; // Caracter generado aleatoriamente
                folioCitaAleatoria += letra.ToString(); // Asignacion de caracter generado, al folio de la cita
            }
            if (ValidarSiExisteFolio(folioCitaAleatoria) == false)
                c.setFolioCita(folioCitaAleatoria);
            else
                if (ValidarSiExisteFolio(folioCitaAleatoria) == true)   CrearFolio(c);
            return folioCitaAleatoria;
        }

        //----------------------------------Validaciones----------------------------------------------
        /// <summary>
        /// Valida si existe la cita en la base de datos.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool ValidarSiExisteCita(Modelos.Cita c)
        {
            String query = "SELECT * FROM CITA WHERE fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' AND hora='" + c.getHora() + "'";
      
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                        return true;
                    else
                        return false;
                }

        }

        /// <summary>
        /// Valida si ya existe el folio.
        /// </summary>
        /// <param name="folio"></param>
        /// <returns></returns>
        public bool ValidarSiExisteFolio(String folio)
        {
            String query = "SELECT * FROM CITA WHERE folioCita='" + folio + "'";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                    return true;
                else
                    return false;
            }

        }

        /// <summary>
        /// Valida si existe la paciente en la base de datos.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool ValidarSiExistePaciente(Modelos.Cita c)
        {
            String query = "SELECT * FROM Paciente WHERE idPaciente='" + c.getIdPaciente() + "'";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                    return true;
                else
                    return false;
            }

        }

        /// <summary>
        /// Valida si la fecha y la hora de la cita no están ya ocupadas.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool ValidarSiExisteFechaHora(Modelos.Cita c)
        {
            String query = "SELECT * FROM CITA WHERE fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' AND hora='" + c.getHora() + "'";

            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                    return true;
                else
                    return false;
            }

        }

        public DataTable LlenarComboBoxDePacientes()
        {
            String query = "SELECT idPaciente, nombresP + ' ' + apellidoPatP + ' ' + apellidoMatP as Nombre FROM PACIENTE";
            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                return tabla;
            }
        }

    }

}