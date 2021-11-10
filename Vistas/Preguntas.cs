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
    public partial class Preguntas : Form
    {
        public Preguntas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuienTxb_MouseEnter(object sender, EventArgs e)
        {
            if (QuienTxb.Text == " ¿QUIEN?")
            {
                QuienTxb.Text = "";
                QuienTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void OtroTbx_MouseEnter(object sender, EventArgs e)
        {
            if (OtroTbx.Text == "OTRO")
            {
                OtroTbx.Text = "";
                OtroTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QuienTxb_MouseLeave(object sender, EventArgs e)
        {
            if (QuienTxb.Text == "")
            {
                QuienTxb.Text = " ¿QUIEN?";
                QuienTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FamiliarInfertilrTxb_MouseEnter(object sender, EventArgs e)
        {
            if (FamiliarInfertilrTxb.Text == "¿TIENE ALGUN FAMILIAR INFERTIL?")
            {
                FamiliarInfertilrTxb.Text = "";
                FamiliarInfertilrTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FamiliarInfertilrTxb_MouseLeave(object sender, EventArgs e)
        {
            if (FamiliarInfertilrTxb.Text == "")
            {
                FamiliarInfertilrTxb.Text = "¿TIENE ALGUN FAMILIAR INFERTIL?";
                FamiliarInfertilrTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ParejasSexualesTxb_MouseEnter(object sender, EventArgs e)
        {
            if (ParejasSexualesTxb.Text == "¿CUANTAS PERSONAS SEXUALES A TENIDO?")
            {
                ParejasSexualesTxb.Text = "";
                ParejasSexualesTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ParejasSexualesTxb_MouseLeave(object sender, EventArgs e)
        {
            if (ParejasSexualesTxb.Text == "")
            {
                ParejasSexualesTxb.Text = "¿CUANTAS PERSONAS SEXUALES A TENIDO?";
                ParejasSexualesTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Fumatxb_MouseEnter(object sender, EventArgs e)
        {
            if (Fumatxb.Text == "¿FUMA?")
            {
                Fumatxb.Text = "";
                Fumatxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Fumatxb_MouseLeave(object sender, EventArgs e)
        {
            if (Fumatxb.Text == "")
            {
                Fumatxb.Text = "¿FUMA?";
                Fumatxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (DesdeCuandoTxb.Text == "¿DESDE CUANDO?")
            {
                DesdeCuandoTxb.Text = "";
                DesdeCuandoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (DesdeCuandoTxb.Text == "")
            {
                DesdeCuandoTxb.Text = "¿DESDE CUANDO?";
                DesdeCuandoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiarioTbx_MouseEnter(object sender, EventArgs e)
        {
            if (QueTantoDiarioTbx.Text == "¿QUE TANTO DIARIO?")
            {
                QueTantoDiarioTbx.Text = "";
                QueTantoDiarioTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiarioTbx_MouseLeave(object sender, EventArgs e)
        {
            if (QueTantoDiarioTbx.Text == "")
            {
                QueTantoDiarioTbx.Text = "¿QUE TANTO DIARIO?";
                QueTantoDiarioTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void OtroTbx_MouseLeave(object sender, EventArgs e)
        {
            if (OtroTbx.Text == "")
            {
                OtroTbx.Text = "OTRO";
                OtroTbx.ForeColor = Color.DarkSlateGray;
            }
        }
    }
}
