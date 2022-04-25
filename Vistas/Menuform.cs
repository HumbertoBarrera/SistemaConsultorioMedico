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
    public partial class Menuform : Form
    {
        int idPaciente;
        bool flagME = true;

        public Menuform()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void MenuDesplegableBtn_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                contenedorMenuPnl.Width = 90;
                linea.Width = 252;
                AnimacionSidebar.Show(Sidebar);
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

        private void Pacientebtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Paciente(true));
        }

        int conteoBase = 0;

        private void AbrirFormHijo(object formhijo)
        {
            if (this.panel1.Controls.Count > conteoBase)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show(); 

        }

        private void AbrirFormHijo2(object formhijo)
        {
            if (this.panel1.Controls.Count > conteoBase)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void citaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo2(new CitasForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new LogoForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new LogoForm());
        }

        private void diagnosticoBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo2(new Diagnostico(idPaciente));
        }

        private void InformacionMedicasBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new InformacionMedica(idPaciente, flagME));
        }

        private void InformacionMedicaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new InformacionMedica(idPaciente, flagME));
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form forma = new Login();
            forma.Show();
            this.Hide();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new UsuarioForms());
        }
    }
}
