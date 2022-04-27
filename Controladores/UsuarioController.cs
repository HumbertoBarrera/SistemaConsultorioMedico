 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaConsultorioMedico.Controladores
{
    class UsuarioController
    {

        static int intTuplasManipuladas = 0;

        /// <summary>
        /// Método para registrar usuarios nuevos al sistema.
        /// </summary>
        /// <param name="u"></param>
        public static void RegistrarUsuario(Modelos.Usuario u)
        {
            String query = "INSERT INTO USUARIO VALUES (@idUsuario, @usuario, @contraseña, @rol)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, ConexionController.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", u.getIdUsuario());
                    cmd.Parameters.AddWithValue("@usuario", u.getUsuario());
                    cmd.Parameters.AddWithValue("@contraseña", u.getPassword());
                    cmd.Parameters.AddWithValue("@rol", u.getRol());
                    int resultado = cmd.ExecuteNonQuery();
                    if(resultado < intTuplasManipuladas)
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                        MessageBox.Show("Usuario agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                }
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // Recuperamos el error que haya lanzado SQL y lo mostramos en pantalla
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

        /// <summary>
        /// Método para actualizar la información del usuario.
        /// </summary>
        /// <param name="u"></param>
        public static void ModificarUsuario(Modelos.Usuario u)
        {
            String query = "UPDATE USUARIO SET usuario = '" + u.getUsuario() + "', contraseña = '" + u.getPassword() + "', rol = '" + u.getRol() + "'" +
                            "WHERE idUsuario = " + u.getIdUsuario();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, ConexionController.Conectar()))
                {
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado < intTuplasManipuladas)
                        MessageBox.Show("Ocurrió un error al ingresar el usuario a la base de datos." +
                                        " Vuelva a intentarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Usuario modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

        /// <summary>
        /// ´Verifica qué tipo de usuario ingresa al sistema.
        /// </summary>
        /// <param name="U"></param>
        /// <param name="login"></param>
        public static void Login(Modelos.Usuario U, Login login)
        {
            SqlCommand codigo;
            codigo = new SqlCommand("SELECT * FROM USUARIO WHERE usuario= '" 
                + U.getUsuario() + "' AND contraseña='" + U.getPassword()
                + "'", Controladores.ConexionController.Conectar());
            SqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                codigo = new SqlCommand("SELECT rol FROM USUARIO WHERE usuario = '" 
                    + U.getUsuario() + "'", Controladores.ConexionController.Conectar());
                leer = codigo.ExecuteReader();
                while (leer.Read())
                {
                    if(leer["rol"].ToString() == "D")
                    {
                        Form MenuForm = new Menuform();
                        MenuForm.Show();
                        login.Hide();
                    }
                    else
                    {
                        Form Menu = new MenuPrincipalSecretaria(false);
                        Menu.Show();
                        login.Hide();
                    }
                }
            }
            else
                MessageBox.Show("Usuario y/o contraseña son incorrectos");

        }

        /* Método para cargar los datos de la tabla de usuarios
         * a un data grid
         */
        /// <summary>
        /// Carga a los usuarios de la base de datos y los muestra en el sistema.
        /// </summary>
        /// <returns></returns>
        public DataTable CargarGridUsuarios()
        {
            // Creamos el query a utilizar
            String query = "SELECT * FROM USUARIO";
            using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
            {
                SqlDataAdapter data = new SqlDataAdapter(comando); // Se recuperan los datos de la tabla
                DataTable tabla = new DataTable(); // Creamos una variable de tipo tabla de datos
                data.Fill(tabla); // Llenamos la tabla de datos con la información recuperada
                return tabla; // Regresamos dicha tabla
            }
        }

    }
}
