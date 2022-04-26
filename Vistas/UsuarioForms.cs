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
    }
}
