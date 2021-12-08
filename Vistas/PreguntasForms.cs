using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaConsultorioMedico;
using System.Data.SqlClient;

namespace SistemaConsultorioMedico
{
    public partial class Preguntas : Form
    {
        private Modelos.InformacionMedica im1;
        int idPaciente;

        public Preguntas(Modelos.InformacionMedica im1, int idPaciente)
        {
            this.im1 = im1;
            this.idPaciente = idPaciente;
            InitializeComponent();
            obtenerFecha();
            llenarInformacion(idPaciente);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuienTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato10OpcTbx.Text == "¿QUIEN?")
            {
                dato10OpcTbx.Text = "";
                dato10OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void OtroTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato10Tbx.Text == "OTRO")
            {
                dato10Tbx.Text = "";
                dato10Tbx.ForeColor = Color.DarkSlateGray;
            }
            dato10Rbtn1.Checked = false;
            dato10Rbtn2.Checked = false;
            dato10Rbtn3.Checked = false;
            dato10Rbtn4.Checked = false;
        }

        private void QuienTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato10OpcTbx.Text == "")
            {
                dato10OpcTbx.Text = "¿QUIEN?";
                dato10OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FamiliarInfertilrTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato11Tbx.Text == "¿TIENE ALGUN FAMILIAR INFERTIL?")
            {
                dato11Tbx.Text = "";
                dato11Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FamiliarInfertilrTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato11Tbx.Text == "")
            {
                dato11Tbx.Text = "¿TIENE ALGUN FAMILIAR INFERTIL?";
                dato11Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ParejasSexualesTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato12Tbx.Text == "¿CUANTAS PERSONAS SEXUALES A TENIDO?")
            {
                dato12Tbx.Text = "";
                dato12Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ParejasSexualesTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato12Tbx.Text == "")
            {
                dato12Tbx.Text = "¿CUANTAS PERSONAS SEXUALES A TENIDO?";
                dato12Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Fumatxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato13Tbx.Text == "¿FUMA?")
            {
                dato13Tbx.Text = "";
                dato13Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Fumatxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato13Tbx.Text == "")
            {
                dato13Tbx.Text = "¿FUMA?";
                dato13Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato13OpcTbx.Text == "¿DESDE CUANDO?")
            {
                dato13OpcTbx.Text = "";
                dato13OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato13OpcTbx.Text == "")
            {
                dato13OpcTbx.Text = "¿DESDE CUANDO?";
                dato13OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiarioTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato13Opc2Tbx.Text == "¿QUE TANTO DIARIO?")
            {
                dato13Opc2Tbx.Text = "";
                dato13Opc2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiarioTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato13Opc2Tbx.Text == "")
            {
                dato13Opc2Tbx.Text = "¿QUE TANTO DIARIO?";
                dato13Opc2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void OtroTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato10Tbx.Text == "")
            {
                dato10Tbx.Text = "OTRO";
                dato10Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TomaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato14Tbx.Text == "¿TOMA?")
            {
                dato14Tbx.Text = "";
                dato14Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void TomaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato14Tbx.Text == "")
            {
                dato14Tbx.Text = "¿TOMA?";
                dato14Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx2_MouseEnter(object sender, EventArgs e)
        {
            if (dato14OpcTbx.Text == "¿DESDE CUANDO?")
            {
                dato14OpcTbx.Text = "";
                dato14OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx2_MouseLeave(object sender, EventArgs e)
        {
            if (dato14OpcTbx.Text == "")
            {
                dato14OpcTbx.Text = "¿DESDE CUANDO?";
                dato14OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTandoDiarioTxb2_MouseEnter(object sender, EventArgs e)
        {
            if (dato14Opc2Tbx.Text == "¿QUE TANTO DIARIO?")
            {
                dato14Opc2Tbx.Text = "";
                dato14Opc2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTandoDiarioTxb2_MouseLeave(object sender, EventArgs e)
        {
            if (dato14Opc2Tbx.Text == "")
            {
                dato14Opc2Tbx.Text = "¿QUE TANTO DIARIO?";
                dato14Opc2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void EsAdictaADrogasTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato15Tbx.Text == "¿ES ADICTA A DROGAS?")
            {
                dato15Tbx.Text = "";
                dato15Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void EsAdictaADrogasTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato15Tbx.Text == "")
            {
                dato15Tbx.Text = "¿ES ADICTA A DROGAS?";
                dato15Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualesTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato15OpcTbx.Text == "¿CUALES?")
            {
                dato15OpcTbx.Text = "";
                dato15OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualesTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato15OpcTbx.Text == "")
            {
                dato15OpcTbx.Text = "¿CUALES?";
                dato15OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx3_MouseEnter(object sender, EventArgs e)
        {
            if (dato15Opc2Tbx.Text == "¿DESDE CUANDO?")
            {
                dato15Opc2Tbx.Text = "";
                dato15Opc2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx3_MouseLeave(object sender, EventArgs e)
        {
            if (dato15Opc2Tbx.Text == "")
            {
                dato15Opc2Tbx.Text = "¿DESDE CUANDO?";
                dato15Opc2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiariamenteTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato15Opc3Tbx.Text == "¿QUE TANTO DIARIAMENTE?")
            {
                dato15Opc3Tbx.Text = "";
                dato15Opc3Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiariamenteTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato15Opc3Tbx.Text == "")
            {
                dato15Opc3Tbx.Text = "¿QUE TANTO DIARIAMENTE?";
                dato15Opc3Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MensualmenteTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato15Opc4Tbx.Text == "¿MENSUALMENTE?")
            {
                dato15Opc4Tbx.Text = "";
                dato15Opc4Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MensualmenteTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato15Opc4Tbx.Text == "")
            {
                dato15Opc4Tbx.Text = "¿MENSUALMENTE?";
                dato15Opc4Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PersonasDuermenEnCuartoTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato16Tbx.Text == "¿CUANTAS PERSONAS DUERMEN EN SU CUARTO?")
            {
                dato16Tbx.Text = "";
                dato16Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PersonasDuermenEnCuartoTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato16Tbx.Text == "")
            {
                dato16Tbx.Text = "¿CUANTAS PERSONAS DUERMEN EN SU CUARTO?";
                dato16Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ConsideraBuenaAlimentacionTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato17Tbx.Text == "¿CONSIDERA QUE SE ALIMENTA BIEN?")
            {
                dato17Tbx.Text = "";
                dato17Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ConsideraBuenaAlimentacionTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato17Tbx.Text == "")
            {
                dato17Tbx.Text = "¿CONSIDERA QUE SE ALIMENTA BIEN?";
                dato17Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComentarioTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato18Tbx.Text == "¿ALGUN COMENTARIO AL RESPECTO?")
            {
                dato18Tbx.Text = "";
                dato18Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComentarioTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato18Tbx.Text == "")
            {
                dato18Tbx.Text = "¿ALGUN COMENTARIO AL RESPECTO?";
                dato18Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateTime hoy = DateTime.Today;
                Modelos.InformacionMedica im2 = new Modelos.InformacionMedica(obtenerEnfermedadFamiliar(), dato10OpcTbx.Text, dato11Tbx.Text, dato11OpcTbx.Text,
                                                                            dato12Tbx.Text, dato13Tbx.Text, dato13OpcTbx.Text, dato13Opc2Tbx.Text, dato14Tbx.Text,
                                                                            dato14OpcTbx.Text, dato14Opc2Tbx.Text, dato15Tbx.Text, dato15OpcTbx.Text,
                                                                            dato15Opc2Tbx.Text, dato15Opc3Tbx.Text, dato15Opc4Tbx.Text, dato16Tbx.Text,
                                                                            dato17Tbx.Text, dato18Tbx.Text, hoy);
                Controladores.InformacionMedicaController.altaInformacionMedica(im1, im2);
                reestablecerCampos();
                this.Close();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private String obtenerEnfermedadFamiliar()
        {
            if (dato10Rbtn1.Checked == true && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && (dato10Tbx.Text == "OTRO" | dato10Tbx.Text == ""))
            {
                return dato10Rbtn1.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == true && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && (dato10Tbx.Text == "OTRO" | dato10Tbx.Text == ""))
            {
                return dato10Rbtn2.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == true && dato10Rbtn4.Checked == false && (dato10Tbx.Text == "OTRO" | dato10Tbx.Text == ""))
            {
                return dato10Rbtn3.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == true && (dato10Tbx.Text == "OTRO" | dato10Tbx.Text == ""))
            {
                return dato10Rbtn4.Text;
            }
            else
            {
                return dato10Tbx.Text;
            }
        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void obtenerFecha()
        {
            var fecha = DateTime.Today;
            FechaLbl.Text = FechaLbl.Text + fecha.Day.ToString() + " DE " + obtenerMes(fecha) + " DEL " + fecha.Year.ToString();
        }

        public String obtenerMes(DateTime fecha)
        {
            String mes;
            switch (fecha.Month)
            {
                case 1: mes = "ENERO"; return mes;
                case 2: mes = "FEBRERO"; return mes;
                case 3: mes = "MARZO"; return mes;
                case 4: mes = "ABRIL"; return mes;
                case 5: mes = "MAYO"; return mes;
                case 6: mes = "JUNIO"; return mes;
                case 7: mes = "JULIO"; return mes;
                case 8: mes = "AGOSTO"; return mes;
                case 9: mes = "SEPTIEMBRE"; return mes;
                case 10: mes = "OCTUBRE"; return mes;
                case 11: mes = "NOVIEMBRE"; return mes;
                case 12: mes = "DICIEMBRE"; return mes;
                default: return "error";
            }
        }

        private void QuienFamiliarTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato11OpcTbx.Text == "¿QUIEN?")
            {
                dato11OpcTbx.Text = "";
                dato11OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QuienFamiliarTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato11OpcTbx.Text == "")
            {
                dato11OpcTbx.Text = "¿QUIEN?";
                dato11OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private bool validarCampos()
        {
            if (validarDato10() && dato11OpcTbx.Text != "¿QUIEN?" && dato11Tbx.Text != "¿TIENE ALGUN FAMILIAR INFERTIL?" && dato11OpcTbx.Text != "¿QUIEN?" && dato12Tbx.Text != "¿CUANTAS PERSONAS SEXUALES A TENIDO?" && dato13Tbx.Text != "¿FUMA?" &&
                dato13OpcTbx.Text != "¿DESDE CUANDO?" && dato13Opc2Tbx.Text != "¿QUE TANTO DIARIO?" && dato14Tbx.Text != "¿TOMA?" && dato14OpcTbx.Text != "¿DESDE CUANDO?" && dato14Opc2Tbx.Text != "¿QUE TANTO DIARIO?" && dato15Tbx.Text != "¿ES ADICTA A DROGAS?" &&
                dato15OpcTbx.Text != "¿CUALES?" && dato15Opc2Tbx.Text != "¿DESDE CUANDO?" && dato15Opc3Tbx.Text != "¿QUE TANTO DIARIAMENTE?" && dato15Opc4Tbx.Text != "¿MENSUALMENTE?" && dato16Tbx.Text != "¿CUANTAS PERSONAS DUERMEN EN SU CUARTO?" &&
                dato17Tbx.Text != "¿CONSIDERA QUE SE ALIMENTA BIEN?" && dato18Tbx.Text != "¿ALGUN COMENTARIO AL RESPECTO?" && dato11OpcTbx.Text != "" && dato11Tbx.Text != "" && dato11OpcTbx.Text != "" && dato12Tbx.Text != "" && dato13Tbx.Text != "" &&
                dato13OpcTbx.Text != "" && dato13Opc2Tbx.Text != "" && dato14Tbx.Text != "" && dato14OpcTbx.Text != "" && dato14Opc2Tbx.Text != "" && dato15Tbx.Text != "" && dato15OpcTbx.Text != "" && dato15Opc2Tbx.Text != "" && dato15Opc3Tbx.Text != "" &&
                dato15Opc4Tbx.Text != "" && dato16Tbx.Text != "" && dato17Tbx.Text != "" && dato18Tbx.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarDato10()
        {
            if (dato10Rbtn1.Checked == true && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "OTRO" || dato10Tbx.Text == "")
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == true && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "OTRO" || dato10Tbx.Text == "")
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == true && dato10Rbtn4.Checked == false && dato10Tbx.Text == "OTRO" || dato10Tbx.Text == "")
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == true && dato10Tbx.Text == "OTRO" || dato10Tbx.Text == "")
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text != "OTRO" || dato10Tbx.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void llenarDato10(String dato10)
        {
            if (dato10.Contains("DIABETES"))
            {
                dato10Rbtn1.Checked = true;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Tbx.Text = "OTRO";
            }
            else if (dato10.Contains("CANCER DE SENOS"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = true;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Tbx.Text = "OTRO";
            }
            else if (dato10.Contains("CANCER SERVICOUTERINO"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = true;
                dato10Rbtn4.Checked = false;
                dato10Tbx.Text = "OTRO";
            }
            else if (dato10.Contains("EPILEPSIA"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = true;
                dato10Tbx.Text = "OTRO";
            }
            else
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Tbx.Text = dato10;
            }
        }

        private void reestablecerCampos()
        {
            dato10Rbtn1.Checked = false;
            dato10Rbtn2.Checked = false;
            dato10Rbtn3.Checked = false;
            dato10Rbtn4.Checked = false;
            dato10Tbx.Text = "OTRO";
            dato10OpcTbx.Text = "¿QUIEN?";
            dato11Tbx.Text = "¿TIENE ALGUN FAMILIAR INFERTIL?";
            dato11OpcTbx.Text = "¿QUIEN?";
            dato12Tbx.Text = "¿CUANTAS PERSONAS SEXUALES A TENIDO?";
            dato13Tbx.Text = "¿FUMA?";
            dato13OpcTbx.Text = "¿DESDE CUANDO?";
            dato13Opc2Tbx.Text = "¿QUE TANTO DIARIO?";
            dato14Tbx.Text = "¿TOMA?";
            dato14OpcTbx.Text = "¿DESDE CUANDO?";
            dato14Opc2Tbx.Text = "¿QUE TANTO DIARIO?";
            dato15Tbx.Text = "¿ES ADICTA A DROGAS?";
            dato15OpcTbx.Text = "¿CUALES?";
            dato15Opc2Tbx.Text = "¿DESDE CUANDO?";
            dato15Opc3Tbx.Text = "¿QUE TANTO DIARIAMENTE?";
            dato15Opc4Tbx.Text = "¿MENSUALMENTE?";
            dato16Tbx.Text = "¿CUANTAS PERSONAS DUERMEN EN SU CUARTO?";
            dato17Tbx.Text = "¿CONSIDERA QUE SE ALIMENTA BIEN?";
            dato18Tbx.Text = "¿ALGUN COMENTARIO AL RESPECTO?";
        }

        public void llenarInformacion(int idPaciente)
        {
            String query = "SELECT * FROM INFORMACIONMEDICA WHERE idPaciente = @idPaciente";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            llenarDato10(leer["dato10"].ToString().Trim());
                            dato10OpcTbx.Text = leer["dato10Opc"].ToString();
                            dato11Tbx.Text = leer["dato11"].ToString();
                            dato11OpcTbx.Text = leer["dato11Opc"].ToString();
                            dato12Tbx.Text = leer["dato12"].ToString();
                            dato13Tbx.Text = leer["dato13"].ToString();
                            dato13OpcTbx.Text = leer["dato13Opc"].ToString();
                            dato13Opc2Tbx.Text = leer["dato13Opc2"].ToString();
                            dato14Tbx.Text = leer["dato14"].ToString();
                            dato14OpcTbx.Text = leer["dato14Opc"].ToString();
                            dato14Opc2Tbx.Text = leer["dato14Opc2"].ToString();
                            dato15Tbx.Text = leer["dato15"].ToString();
                            dato15OpcTbx.Text = leer["dato15Opc"].ToString();
                            dato15Opc2Tbx.Text = leer["dato15Opc2"].ToString();
                            dato15Opc3Tbx.Text = leer["dato15Opc3"].ToString();
                            dato15Opc4Tbx.Text = leer["dato15Opc4"].ToString();
                            dato16Tbx.Text = leer["dato16"].ToString();
                            dato17Tbx.Text = leer["dato17"].ToString();
                            dato18Tbx.Text = leer["dato18"].ToString();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateTime hoy = DateTime.Today;
                Modelos.InformacionMedica im2 = new Modelos.InformacionMedica(obtenerEnfermedadFamiliar(), dato10OpcTbx.Text, dato11Tbx.Text, dato11OpcTbx.Text,
                                                                            dato12Tbx.Text, dato13Tbx.Text, dato13OpcTbx.Text, dato13Opc2Tbx.Text, dato14Tbx.Text,
                                                                            dato14OpcTbx.Text, dato14Opc2Tbx.Text, dato15Tbx.Text, dato15OpcTbx.Text,
                                                                            dato15Opc2Tbx.Text, dato15Opc3Tbx.Text, dato15Opc4Tbx.Text, dato16Tbx.Text,
                                                                            dato17Tbx.Text, dato18Tbx.Text, hoy);
                Controladores.InformacionMedicaController.modificarInformacionMedica(im1, im2);
                reestablecerCampos();
                this.Close();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RadioBtnChecked(object sender, EventArgs e)
        {
            dato10Tbx.Text = "OTRO";
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            Modelos.InformacionMedica im2 = new Modelos.InformacionMedica(obtenerEnfermedadFamiliar(), dato10OpcTbx.Text, dato11Tbx.Text, dato11OpcTbx.Text,
                                                                             dato12Tbx.Text, dato13Tbx.Text, dato13OpcTbx.Text, dato13Opc2Tbx.Text, dato14Tbx.Text,
                                                                             dato14OpcTbx.Text, dato14Opc2Tbx.Text, dato15Tbx.Text, dato15OpcTbx.Text,
                                                                             dato15Opc2Tbx.Text, dato15Opc3Tbx.Text, dato15Opc4Tbx.Text, dato16Tbx.Text,
                                                                             dato17Tbx.Text, dato18Tbx.Text, hoy);
            Controladores.InformacionMedicaController.EliminarInformacionMedica(im1, im2);
            reestablecerCampos();
            this.Close();
        }
      
    }
}
