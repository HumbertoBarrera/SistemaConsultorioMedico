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

        public static void Login(Modelos.Usuario U)
        {
            SqlCommand codigo;
            codigo = new SqlCommand("SELECT * FROM USUARIO WHERE usuario like '%" + U.getUsuario() + "%' AND contraseña='" + U.getPassword()+ "'", Controladores.ConexionController.Conectar());
            SqlDataReader leer = codigo.ExecuteReader();
           // int r = codigo.ExecuteNonQuery();
             if (leer.Read())
            {
                Form MenuForm = new Menuform();
                MenuForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña son incorrectos");

            }

        }

    }
}
