using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SistemaConsultorioMedico
{
    public partial class CitasForm : Form
    {
        public CitasForm()
        {
            InitializeComponent();
            bunifuDatepicker1.Value = DateTime.Now.Date;
            comboBox1.Items.Insert(0, "----- Seleccione la hora----");
            comboBox1.SelectedIndex = 0;

        }
        int indice;

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

        private void GuardarCitaBtn_Click(object sender, EventArgs e)
        {


            if (PacienteCitaTxb.Text != "PACIENTE")
            {
                Modelos.Cita cita = new Modelos.Cita();

                int idPacienteV = int.Parse(PacienteCitaTxb.Text);
                DateTime fechaV = bunifuDatepicker1.Value;
                TimeSpan horaV = TimeSpan.Parse(comboBox1.Text);

                cita.setIdPaciente(idPacienteV);
                cita.setFecha(fechaV);
                cita.setHora(horaV);

               

                if (Controladores.CitaController.validaExisPaciente(cita) == true)
                {

                    if (Controladores.CitaController.validaExisCita(cita) == false)
                    {
                        Controladores.CitaController.folio(cita);
                        Controladores.CitaController.insertarCita(cita);

                        bunifuCustomDataGrid2.DataSource = null;
                        Controladores.CitaController da = new Controladores.CitaController();
                        var dt = da.CargarGridCitas();

                        bunifuCustomDataGrid2.DataSource = dt;
                        bunifuCustomDataGrid2.Columns[0].Visible = false;
                        bunifuCustomDataGrid2.Columns[4].Visible = false;

                    }
                    else
                    {
                        if (Controladores.CitaController.validaExisCita(cita) == true)
                        {
                            MessageBox.Show("Error Fecha y hora Ocupada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                else
                {
                    if (Controladores.CitaController.validaExisPaciente(cita) == false)
                    {
                        MessageBox.Show("Error Paciente no Registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                PacienteCitaTxb.Text = " ";
                bunifuDatepicker1.Value = DateTime.Now.Date;
                comboBox1.Items.Insert(0, "----- Seleccione la hora----");
                comboBox1.SelectedIndex = 0;
                folioCitaLb.Text = "";
                PacienteCitaTxb.Enabled = true;

            }
            else
            {
                MessageBox.Show("Los campos deben ser llenados");

            }

        }

        private void CitasForm_Load(object sender, EventArgs e)
        {
            Controladores.CitaController da = new Controladores.CitaController();
            var dt = da.CargarGridCitas();
            bunifuCustomDataGrid2.DataSource = dt;
            bunifuCustomDataGrid2.Columns[0].Visible = false;
            bunifuCustomDataGrid2.Columns[4].Visible = false;

        }

        private void EliminarCitaBtn_Click(object sender, EventArgs e)
        {
            Modelos.Cita cita = new Modelos.Cita();

            String folioCita = folioCitaLb.Text;
            int idPacienteV = int.Parse(PacienteCitaTxb.Text);
            DateTime fechaV = bunifuDatepicker1.Value;
            TimeSpan horaV = TimeSpan.Parse(comboBox1.Text);

            cita.setIdPaciente(idPacienteV);
            cita.setFecha(fechaV);
            cita.setHora(horaV);
            cita.setFolioCita(folioCita);

            Controladores.CitaController.EliminarCita(cita);
            Controladores.CitaController da = new Controladores.CitaController();
            var dt = da.CargarGridCitas();

            bunifuCustomDataGrid2.DataSource = dt;

            PacienteCitaTxb.Text = " ";
            bunifuDatepicker1.Value = DateTime.Now.Date;
            comboBox1.Items.Insert(0, "----- Seleccione la hora----");
            comboBox1.SelectedIndex = 0;
            folioCitaLb.Text = "";
            PacienteCitaTxb.Enabled = true;
            AgregarCBtn.Visible = false;
            GuardarCitaBtn.Visible = true;
        }

        private void ModificarCitaBtn_Click(object sender, EventArgs e)
        {

            Modelos.Cita cita = new Modelos.Cita();

            String folioCita = folioCitaLb.Text;
            int idPacienteV = int.Parse(PacienteCitaTxb.Text);
            DateTime fechaV = bunifuDatepicker1.Value;
            TimeSpan horaV = TimeSpan.Parse(comboBox1.Text);

            cita.setIdPaciente(idPacienteV);
            cita.setFecha(fechaV);
            cita.setHora(horaV);
            cita.setFolioCita(folioCita);

            Controladores.CitaController.ModificarCita(cita);
            Controladores.CitaController da = new Controladores.CitaController();
            var dt = da.CargarGridCitas();

            bunifuCustomDataGrid2.DataSource = dt;

            PacienteCitaTxb.Text = " ";
            bunifuDatepicker1.Value = DateTime.Now.Date;
            comboBox1.Items.Insert(0, "----- Seleccione la hora----");
            comboBox1.SelectedIndex = 0;
            folioCitaLb.Text = "";
            PacienteCitaTxb.Enabled = true;
            AgregarCBtn.Visible = false;
            GuardarCitaBtn.Visible = true;

        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indice = bunifuCustomDataGrid2.CurrentRow.Index;
            PacienteCitaTxb.Text = bunifuCustomDataGrid2[0, indice].Value.ToString();
            bunifuDatepicker1.Value = Convert.ToDateTime(bunifuCustomDataGrid2[2, indice].Value);
            comboBox1.Items.Insert(0,bunifuCustomDataGrid2[3, indice].Value.ToString());
            comboBox1.SelectedIndex = 0;
            folioCitaLb.Text=bunifuCustomDataGrid2[4, indice].Value.ToString();

            PacienteCitaTxb.Enabled = false;
            GuardarCitaBtn.Visible = false;
            AgregarCBtn.Visible = true;

        }   

        private void bunifuDatepicker1_onValueChanged_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            if (bunifuDatepicker1.Value < DateTime.Now.Date)
            {
                MessageBox.Show("fecha no valida");
                bunifuDatepicker1.Value = DateTime.Now.Date;
            }
            Modelos.Cita cita = new Modelos.Cita();

            DateTime fechaV = bunifuDatepicker1.Value;
            TimeSpan hora1 = TimeSpan.Parse("02:00");

            cita.setFecha(fechaV);
            cita.setHora(hora1);

            if (Controladores.CitaController.validaExisFechaHora(cita)== false)
            {
                comboBox1.Items.Add("02:00");
            }
            TimeSpan hora2 = TimeSpan.Parse("02:20");
            cita.setHora(hora2);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                 comboBox1.Items.Add("02:20");

            }
            TimeSpan hora3 = TimeSpan.Parse("02:40");
            cita.setHora(hora3);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("02:40");

            }
            TimeSpan hora4 = TimeSpan.Parse("03:00");
            cita.setHora(hora4);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("03:00");

            }
            TimeSpan hora5 = TimeSpan.Parse("03:20");
            cita.setHora(hora5);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("03:20");

            }
            TimeSpan hora6 = TimeSpan.Parse("03:40");
            cita.setHora(hora6);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("03:40");
            }
            TimeSpan hora7 = TimeSpan.Parse("04:00");
            cita.setHora(hora7);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("04:00");
            }
            TimeSpan hora8 = TimeSpan.Parse("04:20");
            cita.setHora(hora8);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("04:20");
            }
            TimeSpan hora9 = TimeSpan.Parse("04:40");
            cita.setHora(hora9);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("04:40");

            }
            TimeSpan hora10 = TimeSpan.Parse("05:00");
            cita.setHora(hora10);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("05:00");
            }
            TimeSpan hora11 = TimeSpan.Parse("05:20");
            cita.setHora(hora11);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("05:20");

            }
            TimeSpan hora12 = TimeSpan.Parse("05:40");
            cita.setHora(hora12);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("05:40");
            }
            TimeSpan hora13 = TimeSpan.Parse("06:00");
            cita.setHora(hora13);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("06:00");
            }
            TimeSpan hora14 = TimeSpan.Parse("06:20");
            cita.setHora(hora14);

            if (Controladores.CitaController.validaExisFechaHora(cita) == false)
            {
                comboBox1.Items.Add("06:20");
            }

        }

        private void AgregarCBtn_Click(object sender, EventArgs e)
        {
            AgregarCBtn.Visible = false;
            GuardarCitaBtn.Visible = true;
            PacienteCitaTxb.Text = " ";
            bunifuDatepicker1.Value = DateTime.Now.Date;
            comboBox1.Items.Insert(0, "----- Seleccione la hora----");
            comboBox1.SelectedIndex = 0;
            folioCitaLb.Text = "";
            PacienteCitaTxb.Enabled = true;
        }
    }
}
