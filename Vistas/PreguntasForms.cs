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
        private Modelos.InformacionMedica im2;
        int idPaciente;
        bool flagME;

        public Preguntas(Modelos.InformacionMedica im1, int idPaciente, bool flagME)
        {
            this.im1 = im1;
            this.idPaciente = idPaciente;
            this.flagME = flagME;
            InitializeComponent();
            obtenerFecha();
            llenarInformacion(idPaciente);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateTime hoy = DateTime.Today;
                im2 = new Modelos.InformacionMedica(obtenerEnfermedadFamiliar(), dato10OpcTbx.Text, dato11ComboBox.selectedValue, dato11OpcTbx.Text,
                                                                            dato12Tbx.Text, dato13ComboBox.selectedValue, dato13OpcTbx.Text, dato13Opc2Tbx.Text, dato14ComboBox.selectedValue,
                                                                            dato14OpcTbx.Text, dato14Opc2Tbx.Text, dato15ComboBox.selectedValue, dato15OpcTbx.Text,
                                                                            dato15Opc2Tbx.Text, dato15Opc3Tbx.Text, dato15Opc4Tbx.Text, dato16Tbx.Text,
                                                                            dato17ComboBox.selectedValue, dato18Tbx.Text, hoy);
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
            if (dato10Rbtn1.Checked == true && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return dato10Rbtn1.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == true && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return dato10Rbtn2.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == true && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return dato10Rbtn3.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == true && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return dato10Rbtn4.Text;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == true)
            {
                return dato10Rbtn5.Text;
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
            FechaLbl.Text = FechaLbl.Text + fecha.Day.ToString() + " DE " + fecha.ToString("MMMMM").ToUpper() + " DEL " + fecha.Year.ToString();
        }

        private bool validarCampos()
        {
            if (validarDato10() && dato10OpcTbx.Text != "" && dato11ComboBox.selectedIndex > 0 && dato11OpcTbx.Text != "" && (dato12Tbx.Text != "" && isNumeric(dato12Tbx.Text)) && dato13ComboBox.selectedIndex > 0 && dato13OpcTbx.Text != "" && dato13Opc2Tbx.Text != "" &&
                dato14ComboBox.selectedIndex > 0 && dato14OpcTbx.Text != "" && dato14Opc2Tbx.Text != "" && dato15ComboBox.selectedIndex > 0 && dato15OpcTbx.Text != "" && dato15Opc2Tbx.Text != "" && dato15Opc3Tbx.Text != "" && dato15Opc4Tbx.Text != "" && (dato16Tbx.Text != "" &&
                isNumeric(dato16Tbx.Text)) && dato17ComboBox.selectedIndex > 0 && dato18Tbx.Text != "")
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
            if (dato10Rbtn1.Checked == true && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == true && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == true && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == true && dato10Tbx.Text == "" && dato10Rbtn5.Checked == false)
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text != "" && dato10Rbtn5.Checked == false)
            {
                return true;
            }
            else if (dato10Rbtn1.Checked == false && dato10Rbtn2.Checked == false && dato10Rbtn3.Checked == false && dato10Rbtn4.Checked == false && dato10Tbx.Text == "" && dato10Rbtn5.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void llenarDato10(String dato10)
        {
            if (dato10.Contains("DIABETES"))
            {
                dato10Rbtn1.Checked = true;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10Tbx.Text = "";
            }
            else if (dato10.Contains("CANCER DE SENOS"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = true;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10Tbx.Text = "";
            }
            else if (dato10.Contains("CANCER SERVICOUTERINO"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = true;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10Tbx.Text = "";
            }
            else if (dato10.Contains("EPILEPSIA"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = true;
                dato10Rbtn5.Checked = false;
                dato10Tbx.Text = "";
            }
            else if (dato10.Contains("OMITIR"))
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10OpcTbx.Text = "";
                dato10Rbtn5.Checked = true;
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
            dato10Tbx.Text = "";
            dato10Rbtn5.Checked = false;
            dato10OpcTbx.Text = "";
            dato11ComboBox.selectedIndex = 0;
            dato11OpcTbx.Text = "";
            dato12Tbx.Text = "";
            dato13ComboBox.selectedIndex = 0;
            dato13OpcTbx.Text = "";
            dato13Opc2Tbx.Text = "";
            dato14ComboBox.selectedIndex = 0;
            dato14OpcTbx.Text = "";
            dato14Opc2Tbx.Text = "";
            dato15ComboBox.selectedIndex = 0;
            dato15OpcTbx.Text = "";
            dato15Opc2Tbx.Text = "";
            dato15Opc3Tbx.Text = "";
            dato15Opc4Tbx.Text = "";
            dato16Tbx.Text = "";
            dato17ComboBox.selectedIndex = 0;
            dato18Tbx.Text = "";
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
                            dato11ComboBox.selectedIndex = getIndex(leer["dato11"].ToString());
                            dato11OpcTbx.Text = leer["dato11Opc"].ToString();
                            dato12Tbx.Text = leer["dato12"].ToString();
                            dato13ComboBox.selectedIndex = getIndex(leer["dato13"].ToString());
                            dato13OpcTbx.Text = leer["dato13Opc"].ToString();
                            dato13Opc2Tbx.Text = leer["dato13Opc2"].ToString();
                            dato14ComboBox.selectedIndex = getIndex(leer["dato14"].ToString());
                            dato14OpcTbx.Text = leer["dato14Opc"].ToString();
                            dato14Opc2Tbx.Text = leer["dato14Opc2"].ToString();
                            dato15ComboBox.selectedIndex = getIndex(leer["dato15"].ToString());
                            dato15OpcTbx.Text = leer["dato15Opc"].ToString();
                            dato15Opc2Tbx.Text = leer["dato15Opc2"].ToString();
                            dato15Opc3Tbx.Text = leer["dato15Opc3"].ToString();
                            dato15Opc4Tbx.Text = leer["dato15Opc4"].ToString();
                            dato16Tbx.Text = leer["dato16"].ToString();
                            dato17ComboBox.selectedIndex = getIndex(leer["dato17"].ToString());
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

        public int getIndex(String text)
        {
            if (String.Equals(text, "sí", StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DateTime hoy = DateTime.Today;
                Modelos.InformacionMedica im2 = new Modelos.InformacionMedica(obtenerEnfermedadFamiliar(), dato10OpcTbx.Text, dato11ComboBox.selectedValue, dato11OpcTbx.Text,
                                                                            dato12Tbx.Text, dato13ComboBox.selectedValue, dato13OpcTbx.Text, dato13Opc2Tbx.Text, dato14ComboBox.selectedValue,
                                                                            dato14OpcTbx.Text, dato14Opc2Tbx.Text, dato15ComboBox.selectedValue, dato15OpcTbx.Text,
                                                                            dato15Opc2Tbx.Text, dato15Opc3Tbx.Text, dato15Opc4Tbx.Text, dato16Tbx.Text,
                                                                            dato17ComboBox.selectedValue, dato18Tbx.Text, hoy);
                Controladores.InformacionMedicaController.modificarInformacionMedica(im1, im2);
                reestablecerCampos();
                this.Close();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            Modelos.InformacionMedica im2 = new Modelos.InformacionMedica(obtenerEnfermedadFamiliar(), dato10OpcTbx.Text, dato11ComboBox.selectedValue, dato11OpcTbx.Text,
                                                                            dato12Tbx.Text, dato13ComboBox.selectedValue, dato13OpcTbx.Text, dato13Opc2Tbx.Text, dato14ComboBox.selectedValue,
                                                                            dato14OpcTbx.Text, dato14Opc2Tbx.Text, dato15ComboBox.selectedValue, dato15OpcTbx.Text,
                                                                            dato15Opc2Tbx.Text, dato15Opc3Tbx.Text, dato15Opc4Tbx.Text, dato16Tbx.Text,
                                                                            dato17ComboBox.selectedValue, dato18Tbx.Text, hoy);
            Controladores.InformacionMedicaController.EliminarInformacionMedica(im1, im2);
            reestablecerCampos();
            this.Close();
        }

        private void dato10Rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (dato10Rbtn1.Checked == true)
            {
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10OpcTbx.Enabled = true;
                if (dato10Tbx.Text != "") dato10Tbx.Text = "";
                dato10OpcTbx.Text = "";
            }
        }

        private void dato10Rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (dato10Rbtn2.Checked == true)
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10OpcTbx.Enabled = true;
                if (dato10Tbx.Text != "") dato10Tbx.Text = "";
                dato10OpcTbx.Text = "";
            }
        }

        private void dato10Rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (dato10Rbtn3.Checked == true)
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10OpcTbx.Enabled = true;
                if (dato10Tbx.Text != "") dato10Tbx.Text = "";
                dato10OpcTbx.Text = "";
            }
        }

        private void dato10Rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (dato10Rbtn4.Checked == true)
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10OpcTbx.Enabled = true;
                if (dato10Tbx.Text != "") dato10Tbx.Text = "";
                dato10OpcTbx.Text = "";
            }
        }

        private void dato10Tbx_OnValueChanged(object sender, EventArgs e)
        {
            if (dato10Tbx.Text != "")
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                dato10Rbtn5.Checked = false;
                dato10OpcTbx.Enabled = true;
                dato10OpcTbx.Text = "";
            }
        }

        private void dato10Rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            if (dato10Rbtn5.Checked == true)
            {
                dato10Rbtn1.Checked = false;
                dato10Rbtn2.Checked = false;
                dato10Rbtn3.Checked = false;
                dato10Rbtn4.Checked = false;
                if (dato10Tbx.Text != "") dato10Tbx.Text = "";
                dato10OpcTbx.Enabled = true;
                dato10OpcTbx.Enabled = false;
                dato10OpcTbx.Text = "ㅤㅤ"; 
            }
        }

        private void dato10OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if(dato10OpcTbx.Enabled == true)
            {
                dato10OpcTbx.LineIdleColor = Color.Purple;
                dato10OpcTbx.LineMouseHoverColor = Color.Blue;
                dato10OpcTbx.Text = "";
            }
            else
            {
                dato10OpcTbx.LineIdleColor = Color.Gray;
                dato10OpcTbx.LineMouseHoverColor = Color.Gray;
            }
        }

        private void dato11ItemOpc(object sender, EventArgs e)
        {
            var opc = dato11ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato11OpcTbx.Enabled == true) dato11OpcTbx.Enabled = false;
                    dato11OpcTbx.Text = "";
                    dato11OpcTbx.LineIdleColor = Color.Purple;
                    dato11OpcTbx.LineMouseHoverColor = Color.Purple;
                    break;
                case 1:
                    dato11OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato11OpcTbx.Enabled = true;
                    dato11OpcTbx.Enabled = false;
                    break;
            }
        }

        private void dato11OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if(dato11OpcTbx.Enabled == true)
            {
                dato11OpcTbx.LineIdleColor = Color.Purple;
                dato11OpcTbx.LineMouseHoverColor = Color.Blue;
                dato11OpcTbx.Text = "";
            }
            else
            {
                dato11OpcTbx.LineIdleColor = Color.Gray;
                dato11OpcTbx.LineMouseHoverColor = Color.Gray;
                dato11OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void dato13ItemOpc(object sender, EventArgs e)
        {
            var opc = dato13ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato13OpcTbx.Enabled == true) dato13OpcTbx.Enabled = false;
                    if (dato13Opc2Tbx.Enabled == true) dato13Opc2Tbx.Enabled = false;
                    dato13OpcTbx.Text = "";
                    dato13OpcTbx.LineIdleColor = Color.Purple;
                    dato13OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato13Opc2Tbx.Text = "";
                    dato13Opc2Tbx.LineIdleColor = Color.Purple;
                    dato13Opc2Tbx.LineMouseHoverColor = Color.Purple;
                    break;
                case 1:
                    dato13OpcTbx.Enabled = true;
                    dato13Opc2Tbx.Enabled = true;
                    break;
                case 2:
                    dato13OpcTbx.Enabled = true;
                    dato13OpcTbx.Enabled = false;
                    dato13Opc2Tbx.Enabled = true;
                    dato13Opc2Tbx.Enabled = false;
                    break;
            }
        }

        private void dato13Opc(object sender, EventArgs e)
        {
            if (dato13OpcTbx.Enabled == true || dato13Opc2Tbx.Enabled == true)
            {
                dato13OpcTbx.LineIdleColor = Color.Purple;
                dato13OpcTbx.LineMouseHoverColor = Color.Blue;
                dato13OpcTbx.Text = "";
                dato13Opc2Tbx.LineIdleColor = Color.Purple;
                dato13Opc2Tbx.LineMouseHoverColor = Color.Blue;
                dato13Opc2Tbx.Text = "";
            }
            else
            {
                dato13OpcTbx.LineIdleColor = Color.Gray;
                dato13OpcTbx.LineMouseHoverColor = Color.Gray;
                dato13OpcTbx.Text = "ㅤㅤ";
                dato13Opc2Tbx.LineIdleColor = Color.Gray;
                dato13Opc2Tbx.LineMouseHoverColor = Color.Gray;
                dato13Opc2Tbx.Text = "ㅤㅤ";
            }
        }

        private void dato14ItemOpc(object sender, EventArgs e)
        {
            var opc = dato14ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato14OpcTbx.Enabled == true) dato14OpcTbx.Enabled = false;
                    if (dato14Opc2Tbx.Enabled == true) dato14Opc2Tbx.Enabled = false;
                    dato14OpcTbx.Text = "";
                    dato14OpcTbx.LineIdleColor = Color.Purple;
                    dato14OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato14Opc2Tbx.Text = "";
                    dato14Opc2Tbx.LineIdleColor = Color.Purple;
                    dato14Opc2Tbx.LineMouseHoverColor = Color.Purple;
                    break;
                case 1:
                    dato14OpcTbx.Enabled = true;
                    dato14Opc2Tbx.Enabled = true;
                    break;
                case 2:
                    dato14OpcTbx.Enabled = true;
                    dato14OpcTbx.Enabled = false;
                    dato14Opc2Tbx.Enabled = true;
                    dato14Opc2Tbx.Enabled = false;
                    break;
            }
        }

        private void dato14Opc(object sender, EventArgs e)
        {
            if (dato14OpcTbx.Enabled == true || dato14Opc2Tbx.Enabled == true)
            {
                dato14OpcTbx.LineIdleColor = Color.Purple;
                dato14OpcTbx.LineMouseHoverColor = Color.Blue;
                dato14OpcTbx.Text = "";
                dato14Opc2Tbx.LineIdleColor = Color.Purple;
                dato14Opc2Tbx.LineMouseHoverColor = Color.Blue;
                dato14Opc2Tbx.Text = "";
            }
            else
            {
                dato14OpcTbx.LineIdleColor = Color.Gray;
                dato14OpcTbx.LineMouseHoverColor = Color.Gray;
                dato14OpcTbx.Text = "ㅤㅤ";
                dato14Opc2Tbx.LineIdleColor = Color.Gray;
                dato14Opc2Tbx.LineMouseHoverColor = Color.Gray;
                dato14Opc2Tbx.Text = "ㅤㅤ";
            }
        }

        private void dato15ItemOpc(object sender, EventArgs e)
        {
            var opc = dato15ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato15OpcTbx.Enabled == true) dato15OpcTbx.Enabled = false;
                    if (dato15Opc2Tbx.Enabled == true) dato15Opc2Tbx.Enabled = false;
                    if (dato15Opc3Tbx.Enabled == true) dato15Opc3Tbx.Enabled = false;
                    if (dato15Opc4Tbx.Enabled == true) dato15Opc4Tbx.Enabled = false;
                    dato15OpcTbx.Text = "";
                    dato15OpcTbx.LineIdleColor = Color.Purple;
                    dato15OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato15Opc2Tbx.Text = "";
                    dato15Opc2Tbx.LineIdleColor = Color.Purple;
                    dato15Opc2Tbx.LineMouseHoverColor = Color.Purple;
                    dato15Opc3Tbx.Text = "";
                    dato15Opc3Tbx.LineIdleColor = Color.Purple;
                    dato15Opc3Tbx.LineMouseHoverColor = Color.Purple;
                    dato15Opc4Tbx.Text = "";
                    dato15Opc4Tbx.LineIdleColor = Color.Purple;
                    dato15Opc4Tbx.LineMouseHoverColor = Color.Purple;
                    break;
                case 1:
                    dato15OpcTbx.Enabled = true;
                    dato15Opc2Tbx.Enabled = true;
                    dato15Opc3Tbx.Enabled = true;
                    dato15Opc4Tbx.Enabled = true;
                    break;
                case 2:
                    dato15OpcTbx.Enabled = true;
                    dato15OpcTbx.Enabled = false;
                    dato15Opc2Tbx.Enabled = true;
                    dato15Opc2Tbx.Enabled = false;
                    dato15Opc3Tbx.Enabled = true;
                    dato15Opc3Tbx.Enabled = false;
                    dato15Opc4Tbx.Enabled = true;
                    dato15Opc4Tbx.Enabled = false;
                    break;
            }
        }

        private void dato15Opc(object sender, EventArgs e)
        {
            if(dato15OpcTbx.Enabled == true || dato15Opc2Tbx.Enabled == true || dato15Opc3Tbx.Enabled == true || dato15Opc4Tbx.Enabled == true)
            {
                dato15OpcTbx.LineIdleColor = Color.Purple;
                dato15OpcTbx.LineMouseHoverColor = Color.Blue;
                dato15OpcTbx.Text = "";
                dato15Opc2Tbx.LineIdleColor = Color.Purple;
                dato15Opc2Tbx.LineMouseHoverColor = Color.Blue;
                dato15Opc2Tbx.Text = "";
                dato15Opc3Tbx.LineIdleColor = Color.Purple;
                dato15Opc3Tbx.LineMouseHoverColor = Color.Blue;
                dato15Opc3Tbx.Text = "";
                dato15Opc4Tbx.LineIdleColor = Color.Purple;
                dato15Opc4Tbx.LineMouseHoverColor = Color.Blue;
                dato15Opc4Tbx.Text = "";
            }
            else
            {
                dato15OpcTbx.LineIdleColor = Color.Gray;
                dato15OpcTbx.LineMouseHoverColor = Color.Gray;
                dato15OpcTbx.Text = "ㅤㅤ";
                dato15Opc2Tbx.LineIdleColor = Color.Gray;
                dato15Opc2Tbx.LineMouseHoverColor = Color.Gray;
                dato15Opc2Tbx.Text = "ㅤㅤ";
                dato15Opc3Tbx.LineIdleColor = Color.Gray;
                dato15Opc3Tbx.LineMouseHoverColor = Color.Gray;
                dato15Opc3Tbx.Text = "ㅤㅤ";
                dato15Opc4Tbx.LineIdleColor = Color.Gray;
                dato15Opc4Tbx.LineMouseHoverColor = Color.Gray;
                dato15Opc4Tbx.Text = "ㅤㅤ";
            }
        }

        private void bloqueoBtnGuardar(object sender, EventArgs e)
        {
            if (validarCampos() && flagME)
            {
                GuardarBtn.Enabled = true;
            }
            else
            {
                GuardarBtn.Enabled = false;
                EliminarBtn.Enabled = true;
                if (validarCampos())
                {
                    ModificarBtn.Enabled = true;
                }
                else
                {
                    ModificarBtn.Enabled = false;
                }
            }
        }

        private void GuardarBtn_EnabledChanged(object sender, EventArgs e)
        {
            if(GuardarBtn.Enabled == true)
            {
                GuardarBtn.Padding = new Padding(0);
                GuardarBtn.IdleFillColor = Color.White;
            }
            else
            {
                GuardarBtn.Padding = new Padding(34, 10, 0, 10);
                GuardarBtn.IdleFillColor = Color.Gray;
            }
        }

        private void verificarNumero1(object sender, EventArgs e)
        {
            if (isNumeric(dato12Tbx.Text))
            {
                dato12Tbx.LineIdleColor = Color.Purple;
                dato12Tbx.LineMouseHoverColor = Color.Blue;
                dato12Tbx.LineFocusedColor = Color.Blue;
                errorDigit.Visible = false;
                if (validarCampos() && flagME)
                {
                    GuardarBtn.Enabled = true;
                }
                else
                {
                    GuardarBtn.Enabled = false;
                    if (validarCampos())
                    {
                        ModificarBtn.Enabled = true;
                    }
                    else
                    {
                        ModificarBtn.Enabled = false;
                    }
                }
            }
            else
            {
                dato12Tbx.LineIdleColor = Color.Crimson;
                dato12Tbx.LineMouseHoverColor = Color.Crimson;
                dato12Tbx.LineFocusedColor = Color.Crimson;
                errorDigit.Visible = true;
                GuardarBtn.Enabled = false;
                ModificarBtn.Enabled = false;
            }
        }

        private void verificarNumero2(object sender, EventArgs e)
        {
            if (isNumeric(dato16Tbx.Text))
            {
                dato16Tbx.LineIdleColor = Color.Purple;
                dato16Tbx.LineMouseHoverColor = Color.Blue;
                dato16Tbx.LineFocusedColor = Color.Blue;
                errorDigit.Visible = false;
                if (validarCampos() && flagME)
                {
                    GuardarBtn.Enabled = true;
                }
                else
                {
                    GuardarBtn.Enabled = false;
                    if (validarCampos())
                    {
                        ModificarBtn.Enabled = true;
                    }
                    else
                    {
                        ModificarBtn.Enabled = false;
                    }
                }
            }
            else
            {
                dato16Tbx.LineIdleColor = Color.Crimson;
                dato16Tbx.LineMouseHoverColor = Color.Crimson;
                dato16Tbx.LineFocusedColor = Color.Crimson;
                errorDigit2.Visible = true;
                GuardarBtn.Enabled = false;
                ModificarBtn.Enabled = false;
            }
        }

        private void ModificarBtn_EnabledChanged(object sender, EventArgs e)
        {
            if(ModificarBtn.Enabled == true)
            {
                ModificarBtn.IdleFillColor = Color.White;
                ModificarBtn.Padding = new Padding(0);
            }
            else
            {
                ModificarBtn.IdleFillColor = Color.Gray;
                ModificarBtn.Padding = new Padding(30, 10, 0, 0);
            }
        }

        private void EliminarBtn_EnabledChanged(object sender, EventArgs e)
        {
            if(EliminarBtn.Enabled == true)
            {
                EliminarBtn.IdleFillColor = Color.White;
                EliminarBtn.Padding = new Padding(0);
            }
            else
            {
                EliminarBtn.IdleFillColor = Color.Gray;
                EliminarBtn.Padding = new Padding(37, 10, 0, 10);
            }
        }
    }
}
