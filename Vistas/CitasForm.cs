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
    public partial class CitasForm : Form
    {
        public CitasForm()
        {
            InitializeComponent();
        }

        private void PacienteCitaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (PacienteCitaTxb.Text == "PACIENTE")
            {
                PacienteCitaTxb.Text = "";
                PacienteCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PacienteCitaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (PacienteCitaTxb.Text == "")
            {
                PacienteCitaTxb.Text = "PACIENTE";
                PacienteCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaCitaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (FechaCitaTxb.Text == "FECHA")
            {
                FechaCitaTxb.Text = "";
                FechaCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaCitaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (FechaCitaTxb.Text == "")
            {
                FechaCitaTxb.Text = "FECHA";
                FechaCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void HoraCitaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (HoraCitaTxb.Text == "HORA")
            {
                HoraCitaTxb.Text = "";
                HoraCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void HoraCitaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (HoraCitaTxb.Text == "")
            {
                HoraCitaTxb.Text = "HORA";
                HoraCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void BuscarTbx_MouseEnter(object sender, EventArgs e)
        {
            if (BuscarTbx.Text == "BUSCAR")
            {
                BuscarTbx.Text = "";
                BuscarTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void BuscarTbx_MouseLeave(object sender, EventArgs e)
        {
            if (BuscarTbx.Text == "")
            {
                BuscarTbx.Text = "BUSCAR";
                BuscarTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void GuardarCitaBtn_Click(object sender, EventArgs e)
        {
            int idPacienteV = int.Parse(PacienteCitaTxb.Text);
            DateTime fechaV = Convert.ToDateTime(FechaCitaTxb.Text);
            TimeSpan horaV = TimeSpan.Parse(HoraCitaTxb.Text);

            Controladores.CitaController.insertarCita(idPacienteV, fechaV, horaV);
        }
    }
}
