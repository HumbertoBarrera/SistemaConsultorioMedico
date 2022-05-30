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
        bool flagME = true, flagS;
        int indice;
        private Modelos.Paciente paciente;
        private Controladores.PacienteController controlador = new Controladores.PacienteController();

        public Paciente(bool flagS)
        {
            InitializeComponent();
            Controladores.PropiedadController.BunifuMaterial(TelefonoTbx, 10);
            errorDigit.Visible = false;
            this.flagS = flagS;
            if (!flagS) DiagnosticoBtn.Visible = false;
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
            if (validarCampos())
            {
                var random = new Random().Next(10000000, 99999999);
                paciente = new Modelos.Paciente(random, ((curDate.Year) - Convert.ToInt32(fechaNacDatePicker.Value.Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                    ApellidoMaternoTbx.Text, LugarNaciTbx.Text, DireccionTbx.Text, TelefonoTbx.Text, CorreoETbx.Text,
                                                                    OcupacionTbx.Text, TelefonoTbx.Text, LugarTrabajoTbx.Text, fechaNacDatePicker.Value);
                controlador.RegistrarPaciente(paciente);
                ActualizarTabla();
                reestablecerCampos();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                if (controlador.ValidarSiExistePaciente(idPaciente))
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
                int idPaciente = int.Parse(IdPacienteLbl.Text.Substring(13));
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
                return true;
            else
                return false;
        }

        private void reestablecerCampos()
        {
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
            IdPacienteLbl.Visible = false;
            correoErrorLbl.Visible = false;
            errorDigit.Visible = false;
            flagME = true;
            guardarPac_Btn.Enabled = false;
            ModifPacienteBtn.Enabled = false;
            EliPacienteBtn.Enabled = false;
            this.ActiveControl = bunifuCustomLabel1;
        }

        private void InforMedicaBtn_Click(object sender, EventArgs e)
        {
            if (BuscarTbx.text != "")
            {
                int idPaciente = int.Parse(BuscarTbx.text);
                if (controlador.ValidarSiExistePaciente(idPaciente))
                {
                    Form VInfoMedica = new InformacionMedica(idPaciente, flagME);
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
                int idPaciente = int.Parse(IdPacienteLbl.Text.Substring(13));
                Form VInfoMedica = new InformacionMedica(idPaciente, flagME);
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
            paciente = new Modelos.Paciente(Convert.ToInt32(IdPacienteLbl.Text.Substring(13)), ((curDate.Year) - Convert.ToInt32(fechaNacDatePicker.Value.Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                ApellidoMaternoTbx.Text, LugarNaciTbx.Text, DireccionTbx.Text, TelefonoTbx.Text, CorreoETbx.Text,
                                                                OcupacionTbx.Text, TelefonoTbx.Text, LugarTrabajoTbx.Text, fechaNacDatePicker.Value);
            controlador.ActualizarPaciente(paciente);
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
            flagME = false;
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
            if (validarCampos() && flagME)
            {
                guardarPac_Btn.Enabled = true;
            }
            else
            {
                guardarPac_Btn.Enabled = false;
                if (validarCampos())
                {
                    ModifPacienteBtn.Enabled = true;
                }
                else
                {
                    ModifPacienteBtn.Enabled = false;
                }
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
            if(CorreoETbx.Text.Length == 0)
            {
                CorreoETbx.LineIdleColor = Color.Purple;
                CorreoETbx.LineMouseHoverColor = Color.Blue;
                CorreoETbx.LineFocusedColor = Color.Blue;
                correoErrorLbl.Visible = false;
                guardarPac_Btn.Enabled = false;
                ModifPacienteBtn.Enabled = false;
            }
            else
            {
                if (isValidEmail(CorreoETbx.Text))
                {
                    CorreoETbx.LineFocusedColor = Color.Blue;
                    correoErrorLbl.Visible = false;
                    if (validarCampos() && flagME)
                    {
                        guardarPac_Btn.IdleFillColor = Color.White;
                        guardarPac_Btn.Enabled = true;
                    }
                    else
                    {
                        guardarPac_Btn.IdleFillColor = Color.Gray;
                        guardarPac_Btn.Enabled = false;
                        if (validarCampos())
                        {
                            ModifPacienteBtn.Enabled = true;
                        }
                        else
                        {
                            ModifPacienteBtn.Enabled = false;
                        }
                    }
                }
                else
                {
                    CorreoETbx.LineFocusedColor = Color.Crimson;
                    correoErrorLbl.Visible = true;
                    guardarPac_Btn.IdleFillColor = Color.Gray;
                    guardarPac_Btn.Enabled = false;
                    ModifPacienteBtn.Enabled = false;
                } 
            }
        }

        private void bloqueoBotonGuardar(object sender, EventArgs e)
        {
            if (guardarPac_Btn.Enabled == true)
            {
                guardarPac_Btn.IdleFillColor = Color.White;
                guardarPac_Btn.Padding = new Padding(0);
            }
            else
            {
                guardarPac_Btn.IdleFillColor = Color.Gray;
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
                ModifPacienteBtn.Padding = new Padding(30, 10, 0, 0);
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

        private void EliPacienteBtn_Click(object sender, EventArgs e)
        {
            paciente = new Modelos.Paciente(Convert.ToInt32(IdPacienteLbl.Text.Substring(13)), ((curDate.Year) - Convert.ToInt32(fechaNacDatePicker.Value.Year)), NombreTxb.Text, ApellidoPaternoTbx.Text,
                                                                ApellidoMaternoTbx.Text, LugarNaciTbx.Text, DireccionTbx.Text, TelefonoTbx.Text, CorreoETbx.Text,
                                                                OcupacionTbx.Text, TelefonoTbx.Text, LugarTrabajoTbx.Text, fechaNacDatePicker.Value);
            controlador.EliminarPaciente(paciente);
            ActualizarTabla();
            reestablecerCampos();
        }

        private void validarNumeros(object sender, EventArgs e)
        {
           /* if (isNumeric(TelefonoTbx.Text))
            {
                if (TelefonoTbx.Text.Length == 0)
                {
                    errorDigit.Visible = false;
                    TelefonoTbx.LineIdleColor = Color.Purple;
                    TelefonoTbx.LineMouseHoverColor = Color.Blue;
                    TelefonoTbx.LineFocusedColor = Color.Blue;
                    guardarPac_Btn.Enabled = false;
                    ModifPacienteBtn.Enabled = false;
                }
                else
                {
                    if (TelefonoTbx.Text.Length != 10)
                    {
                        TelefonoTbx.LineIdleColor = Color.Crimson;
                        TelefonoTbx.LineMouseHoverColor = Color.Crimson;
                        TelefonoTbx.LineFocusedColor = Color.Crimson;
                        errorDigit.Text = "El teléfono debe contener mínimo 10 dígitos.";
                        errorDigit.Visible = true;
                        ModifPacienteBtn.Enabled = false;
                        guardarPac_Btn.Enabled = false;
                    }
                    else
                    {
                        TelefonoTbx.LineIdleColor = Color.Purple;
                        TelefonoTbx.LineMouseHoverColor = Color.Blue;
                        TelefonoTbx.LineFocusedColor = Color.Blue;
                        errorDigit.Visible = false;
                        if (validarCampos() && flagME)
                        {
                            guardarPac_Btn.Enabled = true;
                        }
                        else
                        {
                            guardarPac_Btn.Enabled = false;
                            if (validarCampos())
                            {
                                ModifPacienteBtn.Enabled = true;
                            }
                            else
                            {
                                ModifPacienteBtn.Enabled = false;
                            }
                        }
                    }
                }*/
            }

        private void lostFocus(object sender, EventArgs e)
        {
            if (isNumeric(TelefonoTbx.Text))
            {
                if (TelefonoTbx.Text.Length == 0)
                {
                    errorDigit.Visible = false;
                    TelefonoTbx.LineIdleColor = Color.Purple;
                    TelefonoTbx.LineMouseHoverColor = Color.Blue;
                    TelefonoTbx.LineFocusedColor = Color.Blue;
                    guardarPac_Btn.Enabled = false;
                    ModifPacienteBtn.Enabled = false;
                }
                else
                {
                    if (TelefonoTbx.Text.Length != 10)
                    {
                        TelefonoTbx.LineIdleColor = Color.Crimson;
                        TelefonoTbx.LineMouseHoverColor = Color.Crimson;
                        TelefonoTbx.LineFocusedColor = Color.Crimson;
                        errorDigit.Text = "El teléfono debe contener mínimo 10 dígitos.";
                        errorDigit.Visible = true;
                        ModifPacienteBtn.Enabled = false;
                        guardarPac_Btn.Enabled = false;
                    }
                    else
                    {
                        TelefonoTbx.LineIdleColor = Color.Purple;
                        TelefonoTbx.LineMouseHoverColor = Color.Blue;
                        TelefonoTbx.LineFocusedColor = Color.Blue;
                        errorDigit.Visible = false;
                        if (validarCampos() && flagME)
                        {
                            guardarPac_Btn.Enabled = true;
                        }
                        else
                        {
                            guardarPac_Btn.Enabled = false;
                            if (validarCampos())
                            {
                                ModifPacienteBtn.Enabled = true;
                            }
                            else
                            {
                                ModifPacienteBtn.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            (bunifuCustomDataGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nombresP LIKE '%{0}%'", BuscarTbx.text);
        }

        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
