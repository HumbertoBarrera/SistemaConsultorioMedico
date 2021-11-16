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
        int idPaciente;
        DateTime fecha;
        public Diagnostico(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            PacienteTxb.Text = idPaciente.ToString();
            fecha = DateTime.Now;
            FechaTxb.Text = fecha.ToString("MM/dd/yyyy");
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

        private void guardarbtn_Click(object sender, EventArgs e)
        {


            if ((FechaTxb.Text != "FECHA") && (Descripciontxb.Text != "DESCRIPCION"))
            {
                //DateTime fecha = Convert.ToDateTime(FechaTxb.Text);
                Modelos.Diagnostico diagnostico = new Modelos.Diagnostico();
                diagnostico.setIdPaciente(idPaciente);
                diagnostico.setFecha(fecha);
                diagnostico.setDescripcion(Descripciontxb.Text);

                Controladores.DiagnosticoController.folio(diagnostico);
                Controladores.DiagnosticoController.insertarDiagnostico(diagnostico);

            }
            else
            {
                MessageBox.Show("Los campos deben ser llenados");
            }
        }
    }
}
