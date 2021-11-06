using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SistemaConsultorioMedico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void usuariotxt_Enter(object sender, EventArgs e)
        {
            if (usuariotxt.Text == "USUARIO")
            {
                usuariotxt.Text = "";
                usuariotxt.ForeColor = Color.LightGray;
            }
        }

        private void usuariotxt_Leave(object sender, EventArgs e)
        {
            if (usuariotxt.Text == "")
            {
                usuariotxt.Text = "USUARIO";
                usuariotxt.ForeColor = Color.Silver;
            }
        }

        private void contratxt_Enter(object sender, EventArgs e)
        {
            if (contratxt.Text == "CONTRASEÑA")
            {
                contratxt.Text = "";
                contratxt.ForeColor = Color.LightGray;
                contratxt.UseSystemPasswordChar = true;
            }
        }

        private void contratxt_Leave(object sender, EventArgs e)
        {
            if (contratxt.Text == "")
            {
                contratxt.Text = "CONTRASEÑA";
                contratxt.ForeColor = Color.Silver;
                contratxt.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void usuariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Form AbrirMenu = new Menuform();
            AbrirMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AbrirMenu2 = new MenuPrincipalSecretaria();
            AbrirMenu2.Show();
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form AbrirRecu = new RecuperarContra();
            AbrirRecu.Show();
        }
    }
}
