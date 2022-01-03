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
                Modelos.InformacionMedica im1 = new Modelos.InformacionMedica(idPaciente, dato1Txb.Text, dato2Tbx.Text, dato3Tbx.Text, dato4ComboBox.selectedValue,
                                                                        dato4OpcTbx.Text, dato5ComboBox.selectedValue, dato5OpcTbx.Text, dato6ComboBox.selectedValue, dato6OpcTbx.Text,
                                                                        dato7ComboBox.selectedValue, dato7OpcTbx.Text, dato8ComboBox.selectedValue, dato8OpcTbx.Text,
                                                                        dato9ComboBox.selectedValue, dato9OpcTbx.Text);
                Form AbrirPreguntas = new Preguntas(im1, idPaciente);
                AbrirPreguntas.Show();
            }
            else
            {
                MessageBox.Show("No pueden haber campos vacíos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validarCampos()
        {
            if (dato1Txb.Text != "" && dato2Tbx.Text != "" && dato3Tbx.Text != "" && dato4OpcTbx.Text != "" && dato5OpcTbx.Text != "" && dato6OpcTbx.Text != "" &&
                dato7OpcTbx.Text != "" && dato8OpcTbx.Text != "" && dato9OpcTbx.Text != "")
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
            dato1Txb.Text = "";
            dato2Tbx.Text = "";
            dato3Tbx.Text = "";
            dato4ComboBox.selectedIndex = 0;
            dato4OpcTbx.Text = "";
            dato5ComboBox.selectedIndex = 0;
            dato5OpcTbx.Text = "";
            dato6ComboBox.selectedIndex = 0;
            dato6OpcTbx.Text = "";
            dato7ComboBox.selectedIndex = 0;
            dato7OpcTbx.Text = "";
            dato8ComboBox.selectedIndex = 0;
            dato8OpcTbx.Text = "";
            dato9ComboBox.selectedIndex = 0;
            dato9OpcTbx.Text = "";
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
                            dato4ComboBox.selectedIndex = getIndex(leer["dato4"].ToString());
                            dato4OpcTbx.Text = leer["dato4Opc"].ToString();
                            dato5ComboBox.selectedIndex = getIndex(leer["dato5"].ToString());
                            dato5OpcTbx.Text = leer["dato5Opc"].ToString();
                            dato6ComboBox.selectedIndex = getIndex(leer["dato6"].ToString());
                            dato6OpcTbx.Text = leer["dato6Opc"].ToString();
                            dato7ComboBox.selectedIndex = getIndex(leer["dato7"].ToString());
                            dato7OpcTbx.Text = leer["dato7Opc"].ToString();
                            dato8ComboBox.selectedIndex = getIndex(leer["dato8"].ToString());
                            dato8OpcTbx.Text = leer["dato8Opc"].ToString();
                            dato9ComboBox.selectedIndex = getIndex(leer["dato9"].ToString());
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

        public int getIndex(String text)
        {
            if(String.Equals(text, "sí", StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            }
            else
            {
                return 2;
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

        private void dato4ItemOpc(object sender, EventArgs e)
        {
            var opc = dato4ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato4OpcTbx.Enabled == true) dato4OpcTbx.Enabled = false;
                    dato4OpcTbx.LineIdleColor = Color.Purple;
                    dato4OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato4OpcTbx.Text = "";
                    break;
                case 1:
                    dato4OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato4OpcTbx.Enabled = true;
                    dato4OpcTbx.Enabled = false;
                    break;
            }
        }

        private void dato4OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if(dato4OpcTbx.Enabled == true)
            {
                dato4OpcTbx.LineIdleColor = Color.Purple;
                dato4OpcTbx.LineMouseHoverColor = Color.Blue;
                dato4OpcTbx.Text = "";
            }
            else
            {
                dato4OpcTbx.LineIdleColor = Color.Gray;
                dato4OpcTbx.LineMouseHoverColor = Color.Gray;
                dato4OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void dato5ItemOpc(object sender, EventArgs e)
        {
            var opc = dato5ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato5OpcTbx.Enabled == true) dato4OpcTbx.Enabled = false;
                    dato5OpcTbx.LineIdleColor = Color.Purple;
                    dato5OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato5OpcTbx.Text = "";
                    break;
                case 1:
                    dato5OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato5OpcTbx.Enabled = true;
                    dato5OpcTbx.Enabled = false;
                    break;
            }
        }

        private void dato5OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if (dato5OpcTbx.Enabled == true)
            {
                dato5OpcTbx.LineIdleColor = Color.Purple;
                dato5OpcTbx.LineMouseHoverColor = Color.Blue;
                dato5OpcTbx.Text = "";
            }
            else
            {
                dato5OpcTbx.LineIdleColor = Color.Gray;
                dato5OpcTbx.LineMouseHoverColor = Color.Gray;
                dato5OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void dato6ItemOpc(object sender, EventArgs e)
        {
            var opc = dato6ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato6OpcTbx.Enabled == true) dato4OpcTbx.Enabled = false;
                    dato6OpcTbx.LineIdleColor = Color.Purple;
                    dato6OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato6OpcTbx.Text = "";
                    break;
                case 1:
                    dato6OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato6OpcTbx.Enabled = true;
                    dato6OpcTbx.Enabled = false;
                    break;
            }
        }

        private void dato6OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if (dato6OpcTbx.Enabled == true)
            {
                dato6OpcTbx.LineIdleColor = Color.Purple;
                dato6OpcTbx.LineMouseHoverColor = Color.Blue;
                dato6OpcTbx.Text = "";
            }
            else
            {
                dato6OpcTbx.LineIdleColor = Color.Gray;
                dato6OpcTbx.LineMouseHoverColor = Color.Gray;
                dato6OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void dato7ItemOpc(object sender, EventArgs e)
        {
            var opc = dato7ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato7OpcTbx.Enabled == true) dato4OpcTbx.Enabled = false;
                    dato7OpcTbx.LineIdleColor = Color.Purple;
                    dato7OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato7OpcTbx.Text = "";
                    break;
                case 1:
                    dato7OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato7OpcTbx.Enabled = true;
                    dato7OpcTbx.Enabled = false;
                    break;
            }
        }

        private void dato7OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if (dato7OpcTbx.Enabled == true)
            {
                dato7OpcTbx.LineIdleColor = Color.Purple;
                dato7OpcTbx.LineMouseHoverColor = Color.Blue;
                dato7OpcTbx.Text = "";
            }
            else
            {
                dato7OpcTbx.LineIdleColor = Color.Gray;
                dato7OpcTbx.LineMouseHoverColor = Color.Gray;
                dato7OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void dato8ItemOpc(object sender, EventArgs e)
        {
            var opc = dato8ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato8OpcTbx.Enabled == true) dato4OpcTbx.Enabled = false;
                    dato8OpcTbx.LineIdleColor = Color.Purple;
                    dato8OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato8OpcTbx.Text = "";
                    break;
                case 1:
                    dato8OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato8OpcTbx.Enabled = true;
                    dato8OpcTbx.Enabled = false;
                    dato9ComboBox.selectedIndex = 2;
                    dato9ComboBox.Enabled = false;
                    break;
            }
        }

        private void dato8OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if (dato8OpcTbx.Enabled == true)
            {
                dato8OpcTbx.LineIdleColor = Color.Purple;
                dato8OpcTbx.LineMouseHoverColor = Color.Blue;
                dato8OpcTbx.Text = "";
            }
            else
            {
                dato8OpcTbx.LineIdleColor = Color.Gray;
                dato8OpcTbx.LineMouseHoverColor = Color.Gray;
                dato8OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void dato9ItemOpc(object sender, EventArgs e)
        {
            var opc = dato9ComboBox.selectedIndex;
            switch (opc)
            {
                case 0:
                    if (dato9OpcTbx.Enabled == true) dato4OpcTbx.Enabled = false;
                    dato9OpcTbx.LineIdleColor = Color.Purple;
                    dato9OpcTbx.LineMouseHoverColor = Color.Purple;
                    dato9OpcTbx.Text = "";
                    break;
                case 1:
                    dato9OpcTbx.Enabled = true;
                    break;
                case 2:
                    dato9OpcTbx.Enabled = true;
                    dato9OpcTbx.Enabled = false;
                    break;
            }
        }

        private void dato9OpcTbx_EnabledChanged(object sender, EventArgs e)
        {
            if (dato9OpcTbx.Enabled == true)
            {
                dato9OpcTbx.LineIdleColor = Color.Purple;
                dato9OpcTbx.LineMouseHoverColor = Color.Blue;
                dato9OpcTbx.Text = "";
            }
            else
            {
                dato9OpcTbx.LineIdleColor = Color.Gray;
                dato9OpcTbx.LineMouseHoverColor = Color.Gray;
                dato9OpcTbx.Text = "ㅤㅤ";
            }
        }

        private void bloqueoBtnMas(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                MasBtn.Enabled = true;
            }
            else
            {
                MasBtn.Enabled = false;
            }
        }

        private void MasBtn_EnabledChanged(object sender, EventArgs e)
        {
            if (MasBtn.Enabled == true)
            {
                MasBtn.Padding = new Padding(0);
                MasBtn.IdleFillColor = Color.White;
            }
            else
            {
                MasBtn.Padding = new Padding(58, 10, 0, 10);
                MasBtn.IdleFillColor = Color.Gray;
            }
        }
    }
}
