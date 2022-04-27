using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaConsultorioMedico.Vistas
{
    public partial class UsuarioForms : Form
    {

        private Modelos.Usuario user;

        public UsuarioForms()
        {
            InitializeComponent();
        }

        private void UsuarioForms_Load(object sender, EventArgs e)
        {
            Controladores.UsuarioController da = new Controladores.UsuarioController();
            var dt = da.CargarGridUsuarios();
            usuarios_DataGrid.DataSource = dt;
        }

        private void LlenarInfoUsuarios_DataGrid(object sender, DataGridViewCellEventArgs e)
        {
            int indice = usuarios_DataGrid.CurrentRow.Index;
            usuarioTbx.Text = usuarios_DataGrid[0, indice].Value.ToString();
            passwordTbx.Text = usuarios_DataGrid[1, indice].Value.ToString();
        }

        private void BloqueoBtnGuardar(object sender, EventArgs e)
        {
            if (ValidarCampos())
                guardarUsuario_Btn.Enabled = true;
            else
                guardarUsuario_Btn.Enabled = false;
        }

        private void BloqueoBotonGuardar(object sender, EventArgs e)
        {
            if (guardarUsuario_Btn.Enabled == true)
            {
                guardarUsuario_Btn.IdleFillColor = Color.White;
                guardarUsuario_Btn.Padding = new Padding(0);
            }
            else
            {
                guardarUsuario_Btn.IdleFillColor = Color.Gray;
                guardarUsuario_Btn.Padding = new Padding(26, 10, 0, 0);
            }
        }
        
        private Boolean ValidarCampos()
        {
            if (!String.IsNullOrEmpty(usuarioTbx.Text) && !String.IsNullOrEmpty(passwordTbx.Text) && rol_comboBox.selectedIndex > 0)
                return true;
            else
                return false;
        }

        private void guardarUsuario_Btn_Click(object sender, EventArgs e)
        {
            var idRandom = new Random().Next(10000000, 99999999);
            user = new Modelos.Usuario(idRandom, usuarioTbx.Text, passwordTbx.Text, rol_comboBox.selectedValue.ToString().Substring(0, 1));
            Controladores.UsuarioController.RegistrarUsuario(user);
            ActualizarTabla();
            ReestablecerCampos();
        }

        private void ActualizarTabla()
        {
            Controladores.UsuarioController da = new Controladores.UsuarioController();
            var dt = da.CargarGridUsuarios();

            usuarios_DataGrid.DataSource = dt;
        }

        private void ReestablecerCampos()
        {
            usuarioTbx.Text = "";
            passwordTbx.Text = "";
            rol_comboBox.selectedIndex = 0;
        }

    }
}
