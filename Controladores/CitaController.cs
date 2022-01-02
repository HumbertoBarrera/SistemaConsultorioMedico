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
        DateTime fecha;

        public static void insertarCita(Modelos.Cita c)
        {
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
            
            fecha = DateTime.Now;
            String query = "SELECT c.idPaciente,CONCAT(p.nombresP, ' ',p.apellidoPatP, ' ',p.apellidoMatP) AS nombre,LEFT(c.fecha,10),c.hora,c.folioCita FROM CITA C INNER JOIN PACIENTE p ON C.idPaciente = p.idPaciente WHERE c.fecha >='" +fecha.ToString("yyyy/MM/dd") + "' ORDER BY c.fecha ASC";

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
            String query = "DELETE FROM CITA WHERE idPaciente='"+c.getIdPaciente()+"' AND fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' AND hora='" + c.getHora()+ "' AND folioCita='" + c.getFolioCita() + "'";
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
        public static void ModificarCita(Modelos.Cita c) {

            String query = "UPDATE CITA SET fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' , hora='" + c.getHora() + "' WHERE folioCita='" + c.getFolioCita() + "'";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {

                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al Modificar Cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cita Modificada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static void folio(Modelos.Cita c)
        {

            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 8;
            string folioCitaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                folioCitaAleatoria += letra.ToString();
            }

            if (validaExisFolio(folioCitaAleatoria) == false)
            {
                c.setFolioCita(folioCitaAleatoria);
            }
            else
            {
                if (validaExisFolio(folioCitaAleatoria) == true)
                {
                    folio(c);
                }
            }

        }
        //----------------------------------Validaciones----------------------------------------------
        public static bool validaExisCita(Modelos.Cita c)
        {
            String query = "SELECT * FROM CITA WHERE fecha='" + c.getFecha().ToString("yyyy/MM/dd") + "' AND hora='" + c.getHora() + "'";
      
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
        public static bool validaExisFolio(String folio)
        {
            String query = "SELECT * FROM CITA WHERE folioCita='" + folio + "'";

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

        public static bool validaExisPaciente(Modelos.Cita c)
        {
            String query = "SELECT * FROM Paciente WHERE idPaciente='" + c.getIdPaciente() + "'";

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