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
            String query = "SELECT usuario, contraseña, rol FROM USUARIO";
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
