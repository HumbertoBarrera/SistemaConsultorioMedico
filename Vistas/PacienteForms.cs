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

        private void NombreTxb_MouseEnter(object sender, EventArgs e)
        {
            if(NombreTxb.Text == "NOMBRES")
            {
                NombreTxb.Text = "";
                NombreTxb.ForeColor = Color.DarkSlateGray;
        
            }
        }

        private void NombreTxb_MouseLeave(object sender, EventArgs e)
        {
            if (NombreTxb.Text == "")
            {
                NombreTxb.Text = "NOMBRES";
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

        private void ApellidoPaternoTbx_MouseEnter(object sender, EventArgs e)
        {
            if (ApellidoPaternoTbx.Text == "APELLIDO PATERNO")
            {
                ApellidoPaternoTbx.Text = "";
                ApellidoPaternoTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ApellidoPaternoTbx_MouseLeave(object sender, EventArgs e)
        {
            if (ApellidoPaternoTbx.Text == "")
            {
                ApellidoPaternoTbx.Text = "APELLIDO PATERNO";
                ApellidoPaternoTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ApellidoMaternoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (ApellidoMaternoTxb.Text == "APELLIDO MATERNO")
            {
                ApellidoMaternoTxb.Text = "";
                ApellidoMaternoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ApellidoMaternoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (ApellidoMaternoTxb.Text == "")
            {
                ApellidoMaternoTxb.Text = "APELLIDO MATERNO";
                ApellidoMaternoTxb.ForeColor = Color.DarkSlateGray;
            }
        }
        private void guardarPac_Btn_Click(object sender, EventArgs e)
        {
            if(NombreTxb.Text != "NOMBRES" & ApellidoMaternoTxb.Text != "APELLIDO PATERNO" & ApellidoMaternoTxb.Text != "APELLIDO MATERNO" & FechaNacTxb.Text != "FECHA NACIMIENTO" & LugarNaciTxb.Text != "LUGAR DE NACIMIENTO" &
               Direcciontxb.Text != "DIRECCION" & TelefonoTxb.Text != "TELEFONO" & CorreoETxb.Text != "CORREO ELECTRONICO" & OcupacionTxb.Text != "OCUPACION" & LugarTrabajoTxb.Text != "OCUPACION" &
               NombreTxb.Text != "" & ApellidoMaternoTxb.Text != "" & ApellidoMaternoTxb.Text != "" & FechaNacTxb.Text != " " & LugarNaciTxb.Text != "" &
               Direcciontxb.Text != "" & TelefonoTxb.Text != "" & CorreoETxb.Text != "" & OcupacionTxb.Text != "" & LugarTrabajoTxb.Text != "")
            {
                var random = new Random().Next(10000000, 99999999);
                Modelos.Paciente paciente = new Modelos.Paciente(random, ((curDate.Year) - Convert.ToInt32(Convert.ToDateTime(FechaNacTxb.Text).Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                ApellidoMaternoTxb.Text, LugarNaciTxb.Text, Direcciontxb.Text, TelefonoTxb.Text, CorreoETxb.Text,
                                                                OcupacionTxb.Text, TelefonoTxb.Text, LugarTrabajoTxb.Text, Convert.ToDateTime(FechaNacTxb.Text));
                Controladores.PacienteController.altaPaciente(paciente);
                NombreTxb.Text = "NOMBRES";
                ApellidoPaternoTbx.Text = "APELLIDO PATERNO";
                ApellidoMaternoTxb.Text = "APELLIDO MATERNO";
                FechaNacTxb.Text = "FECHA NACIMIENTO";
                LugarNaciTxb.Text = "LUGAR DE NACIMIENTO";
                Direcciontxb.Text = "DIRECCION";
                TelefonoTxb.Text = "TELEFONO";
                CorreoETxb.Text = "CORREO ELECTRONICO";
                OcupacionTxb.Text = "OCUPACION";
                LugarTrabajoTxb.Text = "LUGAR DE TRABAJO";
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        

        private void BuscarTbx_OnTextChange(object sender, EventArgs e)
        {

        }

        private void DiagnosticoBtn_Click(object sender, EventArgs e)
        {
            int idPaciente = int.Parse(BuscarTbx.text);

            Modelos.Diagnostico diagnostico = new Modelos.Diagnostico();
            MessageBox.Show(idPaciente.ToString());
            Form VDiag = new Diagnostico(idPaciente);
            VDiag.Show();
        }
    }
}
