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
        //bool modificarFlag = false;
        int indice;

        public Paciente()
        {
            InitializeComponent();
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

        private void guardarPac_Btn_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                var random = new Random().Next(10000000, 99999999);
                Modelos.Paciente paciente = new Modelos.Paciente(random, ((curDate.Year) - Convert.ToInt32(fechaNacDatePicker.Value.Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                ApellidoMaternoTbx.Text, LugarNaciTbx.Text, DireccionTbx.Text, TelefonoTbx.Text, CorreoETbx.Text,
                                                                OcupacionTbx.Text, TelefonoTbx.Text, LugarTrabajoTbx.Text, fechaNacDatePicker.Value);
                Controladores.PacienteController.altaPaciente(paciente);
                ActualizarTabla();
                reestablecerCampos();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //MessageBox.Show(fechaNacDatePicker.Value.ToString("dd/MM/yyyy"), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            Controladores.PacienteController da = new Controladores.PacienteController();
            var dt = da.CargarGridPacientes();

            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void DiagnosticoBtn_Click(object sender, EventArgs e)
        {
            if (BuscarTbx.Text != "")

            {
                int idPaciente = int.Parse(BuscarTbx.text);
                if (Controladores.PacienteController.validaExisPaciente(idPaciente))
                {
                    Modelos.Diagnostico diagnostico = new Modelos.Diagnostico();
                    Form VDiag = new Diagnostico(idPaciente);
                    this.Hide();
                    VDiag.Show();
                }
                else
                {
                    MessageBox.Show("Este paciente no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(IdPacienteLbl.Visible == true)
            {
                int idPaciente = int.Parse(IdPacienteLbl.Text);
                Modelos.Diagnostico diagnostico = new Modelos.Diagnostico();
                Form VDiag = new Diagnostico(idPaciente);
                this.Hide();
                VDiag.Show();
            }
            else
            {
                MessageBox.Show("Ingrese el ID del Paciente");
            }
            
        }

        private bool validarCampos()
        {
            if (NombreTxb.Text != "" && ApellidoPaternoTbx.Text != "" && ApellidoMaternoTbx.Text != "" && LugarNaciTbx.Text != "" && DireccionTbx.Text != "" && TelefonoTbx.Text != "" && CorreoETbx.Text != "" && OcupacionTbx.Text != "" &&
                LugarTrabajoTbx.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void reestablecerCampos()
        {
            IdPacienteLbl.Visible = false;
            correoErrorLbl.Visible = false;
            NombreTxb.Text = "";
            ApellidoPaternoTbx.Text = "";
            ApellidoMaternoTbx.Text = "";
            fechaNacDatePicker.Value = DateTime.Today;
            LugarNaciTbx.Text = "";
            DireccionTbx.Text = "";
            TelefonoTbx.Text = "";
            CorreoETbx.Text = "";
            OcupacionTbx.Text = "";
            LugarTrabajoTbx.Text = "";
        }

        private void InforMedicaBtn_Click(object sender, EventArgs e)
        {
            if (BuscarTbx.Text != "")
            {
                int idPaciente = int.Parse(BuscarTbx.text);
                if (Controladores.PacienteController.validaExisPaciente(idPaciente))
                {
                    Form VInfoMedica = new InformacionMedica(idPaciente);
                    this.Hide();
                    VInfoMedica.Show();
                }
                else
                {
                    MessageBox.Show("Este paciente no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(IdPacienteLbl.Visible == true)
            {
                int idPaciente = int.Parse(IdPacienteLbl.Text);
                Form VInfoMedica = new InformacionMedica(idPaciente);
                this.Hide();
                VInfoMedica.Show();
            }
            else
            {
                MessageBox.Show("Ingrese el ID del Paciente");
            }
        }

        private void ModifPacienteBtn_Click(object sender, EventArgs e)
        {
            Modelos.Paciente paciente = new Modelos.Paciente(Convert.ToInt32(IdPacienteLbl.Text.Substring(13)), ((curDate.Year) - Convert.ToInt32(fechaNacDatePicker.Value.Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                ApellidoMaternoTbx.Text, LugarNaciTbx.Text, DireccionTbx.Text, TelefonoTbx.Text, CorreoETbx.Text,
                                                                OcupacionTbx.Text, TelefonoTbx.Text, LugarTrabajoTbx.Text, fechaNacDatePicker.Value);
            Controladores.PacienteController.ActualizarPaciente(paciente);
            ActualizarTabla();

            reestablecerCampos();
        }

        private void EliPacienteBtn_Click(object sender, EventArgs e)
        {
            Modelos.Paciente paciente = new Modelos.Paciente(Convert.ToInt32(IdPacienteLbl.Text.Substring(13)), ((curDate.Year) - Convert.ToInt32(fechaNacDatePicker.Value.Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                ApellidoMaternoTbx.Text, LugarNaciTbx.Text, DireccionTbx.Text, TelefonoTbx.Text, CorreoETbx.Text,
                                                                OcupacionTbx.Text, TelefonoTbx.Text, LugarTrabajoTbx.Text, fechaNacDatePicker.Value);
            Controladores.PacienteController.EliminarPaciente(paciente);
            ActualizarTabla();
            reestablecerCampos();
        }

        private void ActualizarTabla()
        {
            Controladores.PacienteController da = new Controladores.PacienteController();
            var dt = da.CargarGridPacientes();

            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void llenarInfoPacientes_DataGrid(object sender, DataGridViewCellEventArgs e)
        {
            indice = bunifuCustomDataGrid1.CurrentRow.Index;
            IdPacienteLbl.Text = "ID PACIENTE: "+bunifuCustomDataGrid1[0, indice].Value.ToString();
            NombreTxb.Text = bunifuCustomDataGrid1[1, indice].Value.ToString();
            ApellidoPaternoTbx.Text = bunifuCustomDataGrid1[2, indice].Value.ToString();
            ApellidoMaternoTbx.Text = bunifuCustomDataGrid1[3, indice].Value.ToString();
            fechaNacDatePicker.Value = Convert.ToDateTime(bunifuCustomDataGrid1[4, indice].Value);
            LugarNaciTbx.Text = bunifuCustomDataGrid1[6, indice].Value.ToString();
            DireccionTbx.Text = bunifuCustomDataGrid1[7, indice].Value.ToString();
            TelefonoTbx.Text = bunifuCustomDataGrid1[8, indice].Value.ToString();
            CorreoETbx.Text = bunifuCustomDataGrid1[9, indice].Value.ToString();
            OcupacionTbx.Text = bunifuCustomDataGrid1[10, indice].Value.ToString();
            LugarTrabajoTbx.Text = bunifuCustomDataGrid1[11, indice].Value.ToString();
            IdPacienteLbl.Visible = true;
            ModifPacienteBtn.Enabled = true;
            EliPacienteBtn.Enabled = true;
        }

        private void bloqueoBtnGuardar(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                guardarPac_Btn.IdleFillColor = Color.White;
                guardarPac_Btn.Enabled = true;
            }
            else
            {
                guardarPac_Btn.IdleFillColor = Color.Gray;
                guardarPac_Btn.Enabled = false;
            }
        }

        private bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                CorreoETbx.LineFocusedColor = Color.Crimson;
                correoErrorLbl.Visible = true;
                return false;
            }
        }

        private void verificarEmail(object sender, EventArgs e)
        {
            if (isValidEmail(CorreoETbx.Text))
            {
                CorreoETbx.LineFocusedColor = Color.Blue;
                correoErrorLbl.Visible = false;
                if (validarCampos())
                {
                    guardarPac_Btn.IdleFillColor = Color.White;
                    guardarPac_Btn.Enabled = true;
                }
                else
                {
                    guardarPac_Btn.IdleFillColor = Color.Gray;
                    guardarPac_Btn.Enabled = false;
                }
            }
            else
            {
                CorreoETbx.LineFocusedColor = Color.Crimson;
                correoErrorLbl.Visible = true;
                guardarPac_Btn.IdleFillColor = Color.Gray;
                guardarPac_Btn.Enabled = false;
            }
        }

        private void bloqueoBotonGuardar(object sender, EventArgs e)
        {
            if (guardarPac_Btn.Enabled == true)
            {
                guardarPac_Btn.Padding = new Padding(0);
            }
            else
            {
                guardarPac_Btn.Padding = new Padding(34, 10, 0, 0);
            }
        }

        private void bloqueoBotonMod(object sender, EventArgs e)
        {
            if(ModifPacienteBtn.Enabled == true)
            {
                ModifPacienteBtn.IdleFillColor = Color.White;
                ModifPacienteBtn.Padding = new Padding(0);
            }
            else
            {
                ModifPacienteBtn.IdleFillColor = Color.Gray;
                ModifPacienteBtn.Padding = new Padding(20, 10, 0, 0);
            }
        }

        private void bloqueoBotonEli(object sender, EventArgs e)
        {
            if(EliPacienteBtn.Enabled == true)
            {
                EliPacienteBtn.IdleFillColor = Color.White;
                EliPacienteBtn.Padding = new Padding(0);
            }
            else
            {
                EliPacienteBtn.IdleFillColor = Color.Gray;
                EliPacienteBtn.Padding = new Padding(33, 10, 0, 10);
            }
        }
    }
}
