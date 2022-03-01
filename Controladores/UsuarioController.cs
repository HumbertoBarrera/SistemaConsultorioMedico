using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaConsultorioMedico.Controladores
{
    class UsuarioController
    {

        public static void Login(Modelos.Usuario U, Login login)
        {
            SqlCommand codigo;
            codigo = new SqlCommand("SELECT * FROM USUARIO WHERE usuario= '" + U.getUsuario() + "' AND contraseña='" + U.getPassword()+ "'", Controladores.ConexionController.Conectar());
            SqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                codigo = new SqlCommand("SELECT rol FROM USUARIO WHERE usuario = '" + U.getUsuario() + "'", Controladores.ConexionController.Conectar());
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
            {
                MessageBox.Show("Usuario y/o contraseña son incorrectos");
            }

        }

    }
}
