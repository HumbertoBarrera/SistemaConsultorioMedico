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
    public partial class Paciente : Form
    {

        DateTime curDate = DateTime.Today;

        public Paciente()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_MouseEnter(object sender, EventArgs e)
        {
            if(NombreTxb.Text == "NOMBRE")
            {
                NombreTxb.Text = "";
                NombreTxb.ForeColor = Color.DarkRed;
        
            }
        }

        private void bunifuMaterialTextbox1_MouseLeave(object sender, EventArgs e)
        {
            if (NombreTxb.Text == "")
            {
                NombreTxb.Text = "NOMBRE";
                NombreTxb.ForeColor = Color.DarkSlateGray;
             
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

        private void NombreTxb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaNacTxb_MouseEnter(object sender, EventArgs e)
        {
            if (FechaNacTxb.Text == "FECHA NACIMIENTO")
            {
                FechaNacTxb.Text = "";
                FechaNacTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaNacTxb_MouseLeave(object sender, EventArgs e)
        {
            if (FechaNacTxb.Text == "")
            {
                FechaNacTxb.Text = "FECHA NACIMIENTO";
                FechaNacTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaNacTxb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LugarNaciTxb_MouseEnter(object sender, EventArgs e)
        {
            if (LugarNaciTxb.Text == "LUGAR DE NACIMIENTO")
            {
                LugarNaciTxb.Text = "";
                LugarNaciTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void LugarNaciTxb_MouseLeave(object sender, EventArgs e)
        {
            if (LugarNaciTxb.Text == "")
            {
                LugarNaciTxb.Text = "LUGAR DE NACIMIENTO";
                LugarNaciTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Direcciontxb_MouseEnter(object sender, EventArgs e)
        {
            if (Direcciontxb.Text == "DIRECCION")
            {
                Direcciontxb.Text = "";
                Direcciontxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Direcciontxb_MouseLeave(object sender, EventArgs e)
        {
            if (Direcciontxb.Text == "")
            {
                Direcciontxb.Text = "DIRECCION";
                Direcciontxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void TelefonoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (TelefonoTxb.Text == "TELEFONO")
            {
                TelefonoTxb.Text = "";
                TelefonoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void TelefonoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (TelefonoTxb.Text == "")
            {
                TelefonoTxb.Text = "TELEFONO";
                TelefonoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CorreoETxb_MouseEnter(object sender, EventArgs e)
        {
            if (CorreoETxb.Text == "CORREO ELECTRONICO")
            {
                CorreoETxb.Text = "";
                CorreoETxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CorreoETxb_MouseLeave(object sender, EventArgs e)
        {
            if (CorreoETxb.Text == "")
            {
                CorreoETxb.Text = "CORREO ELECTRONICO";
                CorreoETxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void OcupacionTxb_MouseEnter(object sender, EventArgs e)
        {
            if (OcupacionTxb.Text == "OCUPACION")
            {
                OcupacionTxb.Text = "";
                OcupacionTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void OcupacionTxb_MouseLeave(object sender, EventArgs e)
        {
            if (OcupacionTxb.Text == "")
            {
                OcupacionTxb.Text = "OCUPACION";
                OcupacionTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void LugarTrabajoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (LugarTrabajoTxb.Text == "LUGAR DE TRABAJO")
            {
                LugarTrabajoTxb.Text = "";
                LugarTrabajoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void LugarTrabajoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (LugarTrabajoTxb.Text == "")
            {
                LugarTrabajoTxb.Text = "LUGAR DE TRABAJO";
                LugarTrabajoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void LugarNaciTxb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guardarPac_Btn_Click(object sender, EventArgs e)
        {
            var random = new Random().Next(10000000, 99999999);
            Modelos.Paciente paciente = new Modelos.Paciente(random, ((curDate.Year) - Convert.ToInt32(Convert.ToDateTime(FechaNacTxb.Text).Year)), NombreTxb.Text, NombreTxb.Text,
                                                            NombreTxb.Text, LugarNaciTxb.Text, Direcciontxb.Text, TelefonoTxb.Text, CorreoETxb.Text,
                                                            OcupacionTxb.Text, TelefonoTxb.Text, LugarTrabajoTxb.Text, Convert.ToDateTime(FechaNacTxb.Text));
            Controladores.PacienteController.altaPaciente(paciente);
        }
    }
}
