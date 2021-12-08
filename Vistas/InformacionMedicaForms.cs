using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaConsultorioMedico
{
    public partial class InformacionMedica : Form
    {
        int idPaciente;

        public InformacionMedica(int idPaciente)
        {
            this.idPaciente = idPaciente;
            InitializeComponent();
            llenarInformacion(idPaciente);
        }

        private void MasBtn_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Modelos.InformacionMedica im1 = new Modelos.InformacionMedica(idPaciente, dato1Txb.Text, dato2Tbx.Text, dato3Tbx.Text, dato4Tbx.Text,
                                                                        dato4OpcTbx.Text, dato5Tbx.Text, dato5OpcTbx.Text, dato6Tbx.Text, dato6OpcTbx.Text,
                                                                        dato7Tbx.Text, dato7OpcTbx.Text, dato8Tbx.Text, dato8OpcTbx.Text,
                                                                        dato9Tbx.Text, dato9OpcTbx.Text);
                Form AbrirPreguntas = new Preguntas(im1, idPaciente);
                AbrirPreguntas.Show();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecomendacionTxb_MouseEnter(object sender, EventArgs e)
        {
            if(dato1Txb.Text == "¿QUIEN LA RECOMENDO?")
            {
                dato1Txb.Text = "";
                dato1Txb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void RecomendacionTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato1Txb.Text == "")
            {
                dato1Txb.Text = "¿QUIEN LA RECOMENDO?";
                dato1Txb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void DoctorAnteriorTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato2Tbx.Text == "¿QUE GINECOLOGO CONSULTABA ANTERIORMENTE?")
            {
                dato2Tbx.Text = "";
                dato2Tbx.ForeColor = Color.DarkSlateGray;
            }
            
        }

        private void DoctorAnteriorTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato2Tbx.Text == "")
            {
                dato2Tbx.Text = "¿QUE GINECOLOGO CONSULTABA ANTERIORMENTE?";
                dato2Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MotivoPrimeraCitaTbx_MouseEnter(object sender, EventArgs e)
        {
            if (dato3Tbx.Text == "MOTIVO DE ESTA PRIMERA CONSULTA")
            {
                dato3Tbx.Text = "";
                dato3Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MotivoPrimeraCitaTbx_MouseLeave(object sender, EventArgs e)
        {
            if (dato3Tbx.Text == "")
            {
                dato3Tbx.Text = "MOTIVO DE ESTA PRIMERA CONSULTA";
                dato3Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AlergiaOEnfermedadCronitxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato4Tbx.Text == "¿PADECE USTED DE ALGUNA ALERGIA O ENFERMEDAD CRONICA?")
            {
                dato4Tbx.Text = "";
                dato4Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AlergiaOEnfermedadCronitxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato4Tbx.Text == "")
            {
                dato4Tbx.Text = "¿PADECE USTED DE ALGUNA ALERGIA O ENFERMEDAD CRONICA?";
                dato4Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualtbxAlergia_MouseEnter(object sender, EventArgs e)
        {
            if (dato4OpcTbx.Text == "¿CUAL?")
            {
                dato4OpcTbx.Text = "";
                dato4OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualtbxAlergia_MouseLeave(object sender, EventArgs e)
        {
            if (dato4OpcTbx.Text == "")
            {
                dato4OpcTbx.Text = "¿CUAL?";
                dato4OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTbxAnimales_MouseEnter(object sender, EventArgs e)
        {
            if (dato5OpcTbx.Text == "¿CUAL?")
            {
                dato5OpcTbx.Text = "";
                dato5OpcTbx.ForeColor = Color.DarkSlateGray;
            }

        }

        private void CualTbxAnimales_MouseLeave(object sender, EventArgs e)
        {
            if (dato5OpcTbx.Text == "")
            {
                dato5OpcTbx.Text = "¿CUAL?";
                dato5OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbMedicamento_MouseEnter(object sender, EventArgs e)
        {
            if (dato6OpcTbx.Text == "¿CUAL?")
            {
                dato6OpcTbx.Text = "";
                dato6OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbMedicamento_MouseLeave(object sender, EventArgs e)
        {
            if (dato6OpcTbx.Text == "")
            {
                dato6OpcTbx.Text = "¿CUAL?";
                dato6OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbAlergiaMedicamento_MouseEnter(object sender, EventArgs e)
        {
            if (dato7OpcTbx.Text == "¿CUAL?")
            {
                dato7OpcTbx.Text = "";
                dato7OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbAlergiaMedicamento_MouseLeave(object sender, EventArgs e)
        {
            if (dato7OpcTbx.Text == "")
            {
                dato7OpcTbx.Text = "¿CUAL?";
                dato7OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CuaTxbCirugia_MouseEnter(object sender, EventArgs e)
        {
            if (dato8OpcTbx.Text == "¿CUAL?")
            {
                dato8OpcTbx.Text = "";
                dato8OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CuaTxbCirugia_MouseLeave(object sender, EventArgs e)
        {
            if (dato8OpcTbx.Text == "")
            {
                dato8OpcTbx.Text = "¿CUAL?";
                dato8OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbComplicacion_MouseEnter(object sender, EventArgs e)
        {
            if (dato9OpcTbx.Text == "¿CUAL?")
            {
                dato9OpcTbx.Text = "";
                dato9OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void CualTxbComplicacion_MouseLeave(object sender, EventArgs e)
        {
            if (dato9OpcTbx.Text == "")
            {
                dato9OpcTbx.Text = "¿CUAL?";
                dato9OpcTbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AnimalesDomesticosTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato5Tbx.Text == "¿TIENE ANIMALES DOMESTICOS COMO PERROS, GATOS, PAJAROS, ETC..?")
            {
                dato5Tbx.Text = "";
                dato5Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AnimalesDomesticosTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato5Tbx.Text == "")
            {
                dato5Tbx.Text = "¿TIENE ANIMALES DOMESTICOS COMO PERROS, GATOS, PAJAROS, ETC..?";
                dato5Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MedicamentoRegularidadTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato6Tbx.Text == "¿TOMA ALGUN MEDICAMENTO CON REGULARIDAD?")
            {
                dato6Tbx.Text = "";
                dato6Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void MedicamentoRegularidadTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato6Tbx.Text == "")
            {
                dato6Tbx.Text = "¿TOMA ALGUN MEDICAMENTO CON REGULARIDAD?";
                dato6Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void AlergiaAlgunMedicamentoTxb_MouseEnter(object sender, EventArgs e)
        {
            if (dato7Tbx.Text == "¿ES ALERGICA A ALGUN MEDICAMENTO?")
            {
                dato7Tbx.Text = "";
                dato7Tbx.ForeColor = Color.DarkSlateGray;
            }
           
        }

        private void AlergiaAlgunMedicamentoTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato7Tbx.Text == "")
            {
                dato7Tbx.Text = "¿ES ALERGICA A ALGUN MEDICAMENTO?";
                dato7Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void SometidaACirugiaTxb_MouseEnter(object sender, EventArgs e)
        {

            if (dato8Tbx.Text == "¿HA SIDO SOMETIDA A ALGUNA CIRUGIA?")
            {
                dato8Tbx.Text = "";
                dato8Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void SometidaACirugiaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato8Tbx.Text == "")
            {
                dato8Tbx.Text = "¿HA SIDO SOMETIDA A ALGUNA CIRUGIA?";
                dato8Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComplicacionTxb_MouseEnter(object sender, EventArgs e)
        {

            if (dato9Tbx.Text == "¿HUBO ALGUNA COMPLICACION?")
            {
                dato9Tbx.Text = "";
                dato9Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private void ComplicacionTxb_MouseLeave(object sender, EventArgs e)
        {
            if (dato9Tbx.Text == "")
            {
                dato9Tbx.Text = "¿HUBO ALGUNA COMPLICACION?";
                dato9Tbx.ForeColor = Color.DarkSlateGray;
            }
        }

        private bool validarCampos()
        {
            if (dato1Txb.Text != "¿QUIEN LA RECOMENDO?" && dato2Tbx.Text != "¿QUE GINECOLOGO CONSULTABA ANTERIORMENTE?" && dato3Tbx.Text != "MOTIVO DE ESTA PRIMERA CONSULTA" && dato4Tbx.Text != "¿PADECE USTED DE ALGUNA ALERGIA O ENFERMEDAD CRONICA?" && dato4OpcTbx.Text != "¿CUAL?" &&
                dato5Tbx.Text != "¿TIENE ANIMALES DOMESTICOS COMO PERROS, GATOS, PAJAROS, ETC..?" && dato5OpcTbx.Text != "¿CUAL?" && dato6Tbx.Text != "¿TOMA ALGUN MEDICAMENTO CON REGULARIDAD?" && dato6OpcTbx.Text != "¿CUAL?" && dato7Tbx.Text != "¿ES ALERGICA A ALGUN MEDICAMENTO?" &&
                dato7OpcTbx.Text != "¿CUAL?" && dato8Tbx.Text != "¿HA SIDO SOMETIDA A ALGUNA CIRUGIA?" && dato8OpcTbx.Text != "¿CUAL?" && dato9Tbx.Text != "¿HUBO ALGUNA COMPLICACION?" && dato9OpcTbx.Text != "¿CUAL?" && dato1Txb.Text != "" && dato2Tbx.Text != "" && dato3Tbx.Text != "" && 
                dato4Tbx.Text != "" && dato4OpcTbx.Text != "" && dato5Tbx.Text != "" && dato5OpcTbx.Text != "" && dato6Tbx.Text != "" && dato6OpcTbx.Text != "" && dato7Tbx.Text != "" && dato7OpcTbx.Text != "" && dato8Tbx.Text != "" && dato8OpcTbx.Text != "" && dato9Tbx.Text != "" && dato9OpcTbx.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void reestablecerCampos()
        {
            dato1Txb.Text = "¿QUIEN LA RECOMENDO?";
            dato2Tbx.Text = "¿QUE GINECOLOGO CONSULTABA ANTERIORMENTE?";
            dato3Tbx.Text = "MOTIVO DE ESTA PRIMERA CONSULTA";
            dato4Tbx.Text = "¿PADECE USTED DE ALGUNA ALERGIA O ENFERMEDAD CRONICA?";
            dato4OpcTbx.Text = "¿CUAL?";
            dato5Tbx.Text = "¿TIENE ANIMALES DOMESTICOS COMO PERROS, GATOS, PAJAROS, ETC..?";
            dato5OpcTbx.Text = "¿CUAL?";
            dato6Tbx.Text = "¿TOMA ALGUN MEDICAMENTO CON REGULARIDAD?";
            dato6OpcTbx.Text = "¿CUAL?";
            dato7Tbx.Text = "¿ES ALERGICA A ALGUN MEDICAMENTO?";
            dato7OpcTbx.Text = "¿CUAL?";
            dato8Tbx.Text = "¿HA SIDO SOMETIDA A ALGUNA CIRUGIA?";
            dato8OpcTbx.Text = "¿CUAL?";
            dato9Tbx.Text = "¿HUBO ALGUNA COMPLICACION?";
            dato9OpcTbx.Text = "¿CUAL?";
        }

        public void llenarInformacion(int idPaciente)
        {
            String query = "SELECT * FROM INFORMACIONMEDICA WHERE idPaciente = @idPaciente";
            try
            {
                using(SqlCommand comando = new SqlCommand(query, Controladores.ConexionController.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                    using(SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            dato1Txb.Text = leer["dato1"].ToString();
                            dato2Tbx.Text = leer["dato2"].ToString();
                            dato3Tbx.Text = leer["dato3"].ToString();
                            dato4Tbx.Text = leer["dato4"].ToString();
                            dato4OpcTbx.Text = leer["dato4Opc"].ToString();
                            dato5Tbx.Text = leer["dato5"].ToString();
                            dato5OpcTbx.Text = leer["dato5Opc"].ToString();
                            dato6Tbx.Text = leer["dato6"].ToString();
                            dato6OpcTbx.Text = leer["dato6Opc"].ToString();
                            dato7Tbx.Text = leer["dato7"].ToString();
                            dato7OpcTbx.Text = leer["dato7Opc"].ToString();
                            dato8Tbx.Text = leer["dato8"].ToString();
                            dato8OpcTbx.Text = leer["dato8Opc"].ToString();
                            dato9Tbx.Text = leer["dato9"].ToString();
                            dato9OpcTbx.Text = leer["dato9Opc"].ToString();
                        }
                    }
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Controladores.ConexionController.Desconectar();
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(buscarTbx.text))
            {
                MessageBox.Show("El campo de búsqueda no debe estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                idPaciente = Convert.ToInt32(buscarTbx.text);
                llenarInformacion(idPaciente);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
