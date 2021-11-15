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

namespace SistemaConsultorioMedico
{
    public partial class Preguntas : Form
    {
        private Modelos.InformacionMedica im1;

        public Preguntas(Modelos.InformacionMedica im1)
        {
            this.im1 = im1;
            InitializeComponent();
            obtenerFecha();
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
            return dato10Tbx.Text;
        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void obtenerFecha()
        {
            var fecha = DateTime.Today;
            DiaLbl.Text = Convert.ToString(fecha.Day);
            AñoLbl.Text = Convert.ToString(fecha.Year);
            switch (fecha.Month)
            {
                case 1: MesLbl.Text = "ENERO"; break;
                case 2: MesLbl.Text = "FEBRERO"; break;
                case 3: MesLbl.Text = "MARZO"; break;
                case 4: MesLbl.Text = "ABRIL"; break;
                case 5: MesLbl.Text = "MAYO"; break;
                case 6: MesLbl.Text = "JUNIO"; break;
                case 7: MesLbl.Text = "JULIO"; break;
                case 8: MesLbl.Text = "AGOSTO"; break;
                case 9: MesLbl.Text = "SEPTIEMBRE"; break;
                case 10: MesLbl.Text = "OCTUBRE"; break;
                case 11: MesLbl.Text = "NOVIEMBRE"; break;
                case 12: MesLbl.Text = "DICIEMBRE"; break;
                default: break;
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

    }
}
