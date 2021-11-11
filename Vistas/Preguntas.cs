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
            if (DesdeCuandoTxb1.Text == "¿DESDE CUANDO?")
            {
                DesdeCuandoTxb1.Text = "";
                DesdeCuandoTxb1.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (DesdeCuandoTxb1.Text == "")
            {
                DesdeCuandoTxb1.Text = "¿DESDE CUANDO?";
                DesdeCuandoTxb1.ForeColor = Color.DarkSlateGray;
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

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TomaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (TomaTxb.Text == "¿TOMA?")
            {
                TomaTxb.Text = "";
                TomaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void TomaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (TomaTxb.Text == "")
            {
                TomaTxb.Text = "¿TOMA?";
                TomaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx2_MouseEnter(object sender, EventArgs e)
        {
            if (DesdeCuandoTbx2.Text == "¿DESDE CUANDO?")
            {
                DesdeCuandoTbx2.Text = "";
                DesdeCuandoTbx2.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx2_MouseLeave(object sender, EventArgs e)
        {
            if (DesdeCuandoTbx2.Text == "")
            {
                DesdeCuandoTbx2.Text = "¿DESDE CUANDO?";
                DesdeCuandoTbx2.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTandoDiarioTxb2_MouseEnter(object sender, EventArgs e)
        {
            if (QueTandoDiarioTxb2.Text == "¿QUE TANTO DIARIO?")
            {
                QueTandoDiarioTxb2.Text = "";
                QueTandoDiarioTxb2.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTandoDiarioTxb2_MouseLeave(object sender, EventArgs e)
        {
            if (QueTandoDiarioTxb2.Text == "")
            {
                QueTandoDiarioTxb2.Text = "¿QUE TANTO DIARIO?";
                QueTandoDiarioTxb2.ForeColor = Color.DarkSlateGray;
            }
        }

        private void EsAdictaADrogasTbx_MouseEnter(object sender, EventArgs e)
        {
            if (EsAdictaADrogasTbx.Text == "¿ES ADICTO A DROGAS?")
            {
                EsAdictaADrogasTbx.Text = "";
                EsAdictaADrogasTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void EsAdictaADrogasTbx_MouseLeave(object sender, EventArgs e)
        {
            if (EsAdictaADrogasTbx.Text == "")
            {
                EsAdictaADrogasTbx.Text = "¿ES ADICTO A DROGAS?";
                EsAdictaADrogasTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualesTbx_MouseEnter(object sender, EventArgs e)
        {
            if (CualesTbx.Text == "¿CUALES?")
            {
                CualesTbx.Text = "";
                CualesTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualesTbx_MouseLeave(object sender, EventArgs e)
        {
            if (CualesTbx.Text == "")
            {
                CualesTbx.Text = "¿CUALES?";
                CualesTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx3_MouseEnter(object sender, EventArgs e)
        {
            if (DesdeCuandoTbx3.Text == "¿DESDE CUANDO?")
            {
                DesdeCuandoTbx3.Text = "";
                DesdeCuandoTbx3.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DesdeCuandoTbx3_MouseLeave(object sender, EventArgs e)
        {
            if (DesdeCuandoTbx3.Text == "")
            {
                DesdeCuandoTbx3.Text = "¿DESDE CUANDO?";
                DesdeCuandoTbx3.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiariamenteTbx_MouseEnter(object sender, EventArgs e)
        {
            if (QueTantoDiariamenteTbx.Text == "¿QUE TANTO DIARIO?")
            {
                QueTantoDiariamenteTbx.Text = "";
                QueTantoDiariamenteTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void QueTantoDiariamenteTbx_MouseLeave(object sender, EventArgs e)
        {
            if (QueTantoDiariamenteTbx.Text == "")
            {
                QueTantoDiariamenteTbx.Text = "¿QUE TANTO DIARIAMENTE?";
                QueTantoDiariamenteTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MensualmenteTbx_MouseEnter(object sender, EventArgs e)
        {
            if (MensualmenteTbx.Text == "¿MENSUALMENTE?")
            {
                MensualmenteTbx.Text = "";
                MensualmenteTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MensualmenteTbx_MouseLeave(object sender, EventArgs e)
        {
            if (MensualmenteTbx.Text == "")
            {
                MensualmenteTbx.Text = "¿MENSUALMENTE?";
                MensualmenteTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PersonasDuermenEnCuartoTbx_MouseEnter(object sender, EventArgs e)
        {
            if (PersonasDuermenEnCuartoTbx.Text == "¿CUANTAS PERSONAS DUERMEN EN SU CUARTO??")
            {
                PersonasDuermenEnCuartoTbx.Text = "";
                PersonasDuermenEnCuartoTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PersonasDuermenEnCuartoTbx_MouseLeave(object sender, EventArgs e)
        {
            if (PersonasDuermenEnCuartoTbx.Text == "")
            {
                PersonasDuermenEnCuartoTbx.Text = "¿CUANTAS PERSONAS DUERMEN EN SU CUARTO?";
                PersonasDuermenEnCuartoTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ConsideraBuenaAlimentacionTbx_MouseEnter(object sender, EventArgs e)
        {
            if (ConsideraBuenaAlimentacionTbx.Text == "¿CONSIDERA QUE SE ALIMENTA BIEN?")
            {
                ConsideraBuenaAlimentacionTbx.Text = "";
                ConsideraBuenaAlimentacionTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ConsideraBuenaAlimentacionTbx_MouseLeave(object sender, EventArgs e)
        {
            if (ConsideraBuenaAlimentacionTbx.Text == "")
            {
                ConsideraBuenaAlimentacionTbx.Text = "¿CONSIDERA QUE SE ALIMENTA BIEN?";
                ConsideraBuenaAlimentacionTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComentarioTbx_MouseEnter(object sender, EventArgs e)
        {
            if (ComentarioTbx.Text == "¿ALGUN COMENTARIO AL RESPECTO?")
            {
                ComentarioTbx.Text = "";
                ComentarioTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComentarioTbx_MouseLeave(object sender, EventArgs e)
        {
            if (ComentarioTbx.Text == "")
            {
                ComentarioTbx.Text = "¿ALGUN COMENTARIO AL RESPECTO?";
                ComentarioTbx.ForeColor = Color.DarkSlateGray;
            }
        }
    }
}
