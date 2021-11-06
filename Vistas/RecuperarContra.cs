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
    public partial class RecuperarContra : Form
    {
        public RecuperarContra()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RecuperarContra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void NombreTxb_MouseEnter(object sender, EventArgs e)
        {
            if (UsuarTxb.Text == "USUARIO")
            {
                UsuarTxb.Text = "";
                UsuarTxb.ForeColor = Color.LightGray;
            }
        }

        private void UsuarTxb_MouseLeave(object sender, EventArgs e)
        {
            if (UsuarTxb.Text == "")
            {
                UsuarTxb.Text = "USUARIO";
                UsuarTxb.ForeColor = Color.Silver;
            }
        }

        private void CorreoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (CorreoTxb.Text == "CORREO ELECTRONICO")
            {
                CorreoTxb.Text = "";
                CorreoTxb.ForeColor = Color.LightGray;
            }

        }

        private void CorreoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (CorreoTxb.Text == "")
            {
                CorreoTxb.Text = "CORREO ELECTRONICO";
                CorreoTxb.ForeColor = Color.Silver;
            }
        }
    }
}
