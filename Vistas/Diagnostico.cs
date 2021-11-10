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
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
        }

        private void FechaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (FechaTxb.Text == "FECHA")
            {
                FechaTxb.Text = "";
                FechaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (FechaTxb.Text == "")
            {
                FechaTxb.Text = "FECHA";
                FechaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Descripciontxb_MouseEnter(object sender, EventArgs e)
        {
            if (Descripciontxb.Text == "DESCRIPCION")
            {
                Descripciontxb.Text = "";
                Descripciontxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Descripciontxb_MouseLeave(object sender, EventArgs e)
        {
            if (Descripciontxb.Text == "")
            {
                Descripciontxb.Text = "DESCRIPCION";
                Descripciontxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PacienteTxb_MouseEnter(object sender, EventArgs e)
        {
            if (PacienteTxb.Text == "PACIENTE")
            {
                PacienteTxb.Text = "";
                PacienteTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PacienteTxb_MouseLeave(object sender, EventArgs e)
        {
            if (PacienteTxb.Text == "")
            {
                PacienteTxb.Text = "PACIENTE";
                PacienteTxb.ForeColor = Color.DarkSlateGray;
            }
        }
    }
}
