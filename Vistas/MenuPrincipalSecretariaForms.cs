using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaConsultorioMedico
{
    public partial class MenuPrincipalSecretaria : Form
    {
        int idPaciente;
        bool flagME = true;

        public MenuPrincipalSecretaria()
        {
            InitializeComponent();
        }

        private void Pacientebtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Paciente());
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }

        private void MenuDesplegableBtn_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                contenedorMenuPnl.Width = 90;
                linea.Width = 252;
                bunifuTransition1.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                contenedorMenuPnl.Width = 300;
                linea.Width = 252;
                AnimacionSidebarAtras.Show(Sidebar);
            }

            
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void citaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CitasForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new LogoForm());
        }

        private void InformacionMedicaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new InformacionMedica(idPaciente, flagME));
        }

    }
}
