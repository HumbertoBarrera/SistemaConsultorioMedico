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
    public partial class InformacionMedica : Form
    {
        public InformacionMedica()
        {
            InitializeComponent();
        }

        private void MasBtn_Click(object sender, EventArgs e)
        {
            Form AbrirPreguntas = new Preguntas();
            AbrirPreguntas.Show();
        }

        private void RecomendacionTxb_MouseEnter(object sender, EventArgs e)
        {
            if (RecomendacionTxb.Text == " ¿QUIEN LA RECOMENDO?")
            {
                RecomendacionTxb.Text = "";
                RecomendacionTxb.ForeColor = Color.DarkSlateGray;
            }
             
        }
        private void RecomendacionTxb_MouseLeave(object sender, EventArgs e)
        {
            if (RecomendacionTxb.Text == "")
            {
                RecomendacionTxb.Text = " ¿QUIEN LA RECOMENDO?";
                RecomendacionTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DoctorAnteriorTxb_MouseEnter(object sender, EventArgs e)
        {
            if (DoctorAnteriorTxb.Text == "¿QUE GINECOLOGO CONSULTABA ANTERIORMENTE?")
            {
                DoctorAnteriorTxb.Text = "";
                DoctorAnteriorTxb.ForeColor = Color.DarkSlateGray;
            }
            
        }

        private void DoctorAnteriorTxb_MouseLeave(object sender, EventArgs e)
        {
            if (DoctorAnteriorTxb.Text == "")
            {
                DoctorAnteriorTxb.Text = "¿QUE GINECOLOGO CONSULTABA ANTERIORMENTE?";
                DoctorAnteriorTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MotivoPrimeraCitaTbx_MouseEnter(object sender, EventArgs e)
        {
            if (MotivoPrimeraCitaTbx.Text == "MOTIVO DE ESTA PRIMERA CONSULTA")
            {
                MotivoPrimeraCitaTbx.Text = "";
                MotivoPrimeraCitaTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MotivoPrimeraCitaTbx_MouseLeave(object sender, EventArgs e)
        {
            if (MotivoPrimeraCitaTbx.Text == "")
            {
                MotivoPrimeraCitaTbx.Text = "MOTIVO DE ESTA PRIMERA CONSULTA";
                MotivoPrimeraCitaTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AlergiaOEnfermedadCronitxb_MouseEnter(object sender, EventArgs e)
        {
            if (AlergiaOEnfermedadCronitxb.Text == "¿PADECE USTED DE ALGUNA ALERGIA O ENFERMEDAD CRONICA?")
            {
                AlergiaOEnfermedadCronitxb.Text = "";
                AlergiaOEnfermedadCronitxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AlergiaOEnfermedadCronitxb_MouseLeave(object sender, EventArgs e)
        {
            if (AlergiaOEnfermedadCronitxb.Text == "")
            {
                AlergiaOEnfermedadCronitxb.Text = "¿PADECE USTED DE ALGUNA ALERGIA O ENFERMEDAD CRONICA?";
                AlergiaOEnfermedadCronitxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualtbxAlergia_MouseEnter(object sender, EventArgs e)
        {
            if (CualtbxAlergia.Text == " ¿CUAL?")
            {
                CualtbxAlergia.Text = "";
                CualtbxAlergia.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualtbxAlergia_MouseLeave(object sender, EventArgs e)
        {
            if (CualtbxAlergia.Text == "")
            {
                CualtbxAlergia.Text = " ¿CUAL?";
                CualtbxAlergia.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTbxAnimales_MouseEnter(object sender, EventArgs e)
        {
            if (CualTbxAnimales.Text == " ¿CUAL?")
            {
                CualTbxAnimales.Text = "";
                CualTbxAnimales.ForeColor = Color.DarkSlateGray;
            }

        }

        private void CualTbxAnimales_MouseLeave(object sender, EventArgs e)
        {
            if (CualTbxAnimales.Text == "")
            {
                CualTbxAnimales.Text = " ¿CUAL?";
                CualTbxAnimales.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbMedicamento_MouseEnter(object sender, EventArgs e)
        {
            if (CualTxbMedicamento.Text == " ¿CUAL?")
            {
                CualTxbMedicamento.Text = "";
                CualTxbMedicamento.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbMedicamento_MouseLeave(object sender, EventArgs e)
        {
            if (CualTxbMedicamento.Text == "")
            {
                CualTxbMedicamento.Text = " ¿CUAL?";
                CualTxbMedicamento.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbAlergiaMedicamento_MouseEnter(object sender, EventArgs e)
        {
            if (CualTxbAlergiaMedicamento.Text == " ¿CUAL?")
            {
                CualTxbAlergiaMedicamento.Text = "";
                CualTxbAlergiaMedicamento.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbAlergiaMedicamento_MouseLeave(object sender, EventArgs e)
        {
            if (CualTxbAlergiaMedicamento.Text == "")
            {
                CualTxbAlergiaMedicamento.Text = " ¿CUAL?";
                CualTxbAlergiaMedicamento.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CuaTxbCirugia_MouseEnter(object sender, EventArgs e)
        {
            if (CuaTxbCirugia.Text == " ¿CUAL?")
            {
                CuaTxbCirugia.Text = "";
                CuaTxbCirugia.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CuaTxbCirugia_MouseLeave(object sender, EventArgs e)
        {
            if (CuaTxbCirugia.Text == "")
            {
                CuaTxbCirugia.Text = " ¿CUAL?";
                CuaTxbCirugia.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbComplicacion_MouseEnter(object sender, EventArgs e)
        {
            if (CualTxbComplicacion.Text == " ¿CUAL?")
            {
                CualTxbComplicacion.Text = "";
                CualTxbComplicacion.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbComplicacion_MouseLeave(object sender, EventArgs e)
        {
            if (CualTxbComplicacion.Text == "")
            {
                CualTxbComplicacion.Text = " ¿CUAL?";
                CualTxbComplicacion.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AnimalesDomesticosTxb_MouseEnter(object sender, EventArgs e)
        {
            if (AnimalesDomesticosTxb.Text == "¿TIENE ANIMALES DOMESTICOS COMO PERROS, GATOS, PAJAROS, ETC..?")
            {
                AnimalesDomesticosTxb.Text = "";
                AnimalesDomesticosTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AnimalesDomesticosTxb_MouseLeave(object sender, EventArgs e)
        {
            if (AnimalesDomesticosTxb.Text == "")
            {
                AnimalesDomesticosTxb.Text = "¿TIENE ANIMALES DOMESTICOS COMO PERROS, GATOS, PAJAROS, ETC..?";
                AnimalesDomesticosTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MedicamentoRegularidadTxb_MouseEnter(object sender, EventArgs e)
        {
            if (MedicamentoRegularidadTxb.Text == "¿TOMA ALGUN MEDICAMENTO CON REGULARIDAD?")
            {
                MedicamentoRegularidadTxb.Text = "";
                MedicamentoRegularidadTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MedicamentoRegularidadTxb_MouseLeave(object sender, EventArgs e)
        {
            if (MedicamentoRegularidadTxb.Text == "")
            {
                MedicamentoRegularidadTxb.Text = "¿TOMA ALGUN MEDICAMENTO CON REGULARIDAD?";
                MedicamentoRegularidadTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AlergiaAlgunMedicamentoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (AlergiaAlgunMedicamentoTxb.Text == "¿ES ALERGICA A ALGUN MEDICAMENTO?")
            {
                AlergiaAlgunMedicamentoTxb.Text = "";
                AlergiaAlgunMedicamentoTxb.ForeColor = Color.DarkSlateGray;
            }
           
        }

        private void AlergiaAlgunMedicamentoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (AlergiaAlgunMedicamentoTxb.Text == "")
            {
                AlergiaAlgunMedicamentoTxb.Text = "¿ES ALERGICA A ALGUN MEDICAMENTO?";
                AlergiaAlgunMedicamentoTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void SometidaACirugiaTxb_MouseEnter(object sender, EventArgs e)
        {

            if (SometidaACirugiaTxb.Text == "¿HA SIDO SOMETIDA A ALGUNA CIRUGIA?")
            {
                SometidaACirugiaTxb.Text = "";
                SometidaACirugiaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void SometidaACirugiaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (SometidaACirugiaTxb.Text == "")
            {
                SometidaACirugiaTxb.Text = "¿HA SIDO SOMETIDA A ALGUNA CIRUGIA?";
                SometidaACirugiaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComplicacionTxb_MouseEnter(object sender, EventArgs e)
        {

            if (ComplicacionTxb.Text == "¿HUBO ALGUNA COMPLICACION?")
            {
                ComplicacionTxb.Text = "";
                ComplicacionTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComplicacionTxb_MouseLeave(object sender, EventArgs e)
        {
            if (ComplicacionTxb.Text == "")
            {
                ComplicacionTxb.Text = "¿HUBO ALGUNA COMPLICACION?";
                ComplicacionTxb.ForeColor = Color.DarkSlateGray;
            }
        }
    }
}
