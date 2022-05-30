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
        private Modelos.Cita cita;
        private Controladores.CitaController citaController = new Controladores.CitaController();

        public CitasForm()
        {
            InitializeComponent();
            bunifuDatepicker1.Value = DateTime.Now.Date;
            comboBox1.Items.Insert(0, "----- Seleccione la hora----");
            comboBox1.SelectedIndex = 0;

           
            //Controladores.PropiedadController.BunifuMaterial(PacienteCitaTxb, 8);
            //errorDigit.Visible = false;


        }
        int indice;

        private void GuardarCitaBtn_Click(object sender, EventArgs e)
        {

            //errorDigit.Visible = false;

            if (/*(PacienteCitaTxb.Text != "PACIENTE")&&*/(comboBox1.Text !="----- Seleccione la hora----") && (comboBox1.SelectedIndex != -1))
            {
                cita = new Modelos.Cita();
                int idPacienteV = int.Parse(pacientesCbo.SelectedValue.ToString());
                DateTime fechaV = bunifuDatepicker1.Value;
                TimeSpan horaV = TimeSpan.Parse(comboBox1.Text);

                cita.setIdPaciente(idPacienteV);
                cita.setFecha(fechaV);
                cita.setHora(horaV);

                if (citaController.ValidarSiExistePaciente(cita) == true)
                {

                    if (citaController.ValidarSiExisteCita(cita) == false)
                    {
                        citaController.CrearFolio(cita);
                        citaController.InsertarCita(cita);

                        bunifuCustomDataGrid2.DataSource = null;
                        Controladores.CitaController da = new Controladores.CitaController();
                        var dt = da.CargarGridCitas();

                        bunifuCustomDataGrid2.DataSource = dt;
                        bunifuCustomDataGrid2.Columns[0].Visible = false;
                        bunifuCustomDataGrid2.Columns[4].Visible = false;
                    }
                    else
                    {
                        if (citaController.ValidarSiExisteCita(cita) == true)
                        {
                            MessageBox.Show("Error Fecha y hora Ocupada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (citaController.ValidarSiExistePaciente(cita) == false)
                    {
                        MessageBox.Show("Error Paciente no Registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                //PacienteCitaTxb.Text = " ";
                bunifuDatepicker1.Value = DateTime.Parse("24/07/2022");
                bunifuDatepicker1.Value = DateTime.Now.Date;
                comboBox1.Items.Insert(0, "----- Seleccione la hora----");
                comboBox1.SelectedIndex = 0;
                folioCitaLb.Text = "";
                //PacienteCitaTxb.Enabled = true;
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

            //---------------------------------------------------
            var dtPacientes = da.LlenarComboBoxDePacientes();
            pacientesCbo.DataSource = dtPacientes;
            pacientesCbo.DisplayMember = "Nombre";
            pacientesCbo.ValueMember = "idPaciente";

        }

    
        private void EliminarCitaBtn_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "----- Seleccione la hora----") && (comboBox1.SelectedIndex != -1))
            {
                Modelos.Cita cita = new Modelos.Cita();

                String folioCita = folioCitaLb.Text;
                int idPacienteV = int.Parse(pacientesCbo.SelectedValue.ToString());
                DateTime fechaV = bunifuDatepicker1.Value;
                TimeSpan horaV = TimeSpan.Parse(comboBox1.Text);

                cita.setIdPaciente(idPacienteV);
                cita.setFecha(fechaV);
                cita.setHora(horaV);
                cita.setFolioCita(folioCita);

                citaController.EliminarCita(cita);
                Controladores.CitaController da = new Controladores.CitaController();
                var dt = da.CargarGridCitas();

                bunifuCustomDataGrid2.DataSource = dt;

                //PacienteCitaTxb.Text = " ";
                bunifuDatepicker1.Value = DateTime.Parse("24/07/2022");
                bunifuDatepicker1.Value = DateTime.Now.Date;
                comboBox1.Items.Insert(0, "----- Seleccione la hora----");
                comboBox1.SelectedIndex = 0;
                folioCitaLb.Text = "";
                //PacienteCitaTxb.Enabled = true;
                AgregarCBtn.Visible = false;
                GuardarCitaBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Los campos deben ser llenados");

            }
           
        }

        private void ModificarCitaBtn_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "----- Seleccione la hora----") && (comboBox1.SelectedIndex != -1))
            {

                Modelos.Cita cita = new Modelos.Cita();

                String folioCita = folioCitaLb.Text;
                int idPacienteV = int.Parse(pacientesCbo.SelectedValue.ToString());
                DateTime fechaV = bunifuDatepicker1.Value;
                TimeSpan horaV = TimeSpan.Parse(comboBox1.Text);

                cita.setIdPaciente(idPacienteV);
                cita.setFecha(fechaV);
                cita.setHora(horaV);
                cita.setFolioCita(folioCita);

                citaController.ModificarCita(cita);
                Controladores.CitaController da = new Controladores.CitaController();
                var dt = da.CargarGridCitas();

                bunifuCustomDataGrid2.DataSource = dt;

                //PacienteCitaTxb.Text = " ";
                bunifuDatepicker1.Value = DateTime.Parse("24/07/2022");
                bunifuDatepicker1.Value = DateTime.Now.Date;
                comboBox1.Items.Insert(0, "----- Seleccione la hora----");
                comboBox1.SelectedIndex = 0;
                folioCitaLb.Text = "";
                //PacienteCitaTxb.Enabled = true;
                AgregarCBtn.Visible = false;
                GuardarCitaBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Los campos deben ser llenados");

            }
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indice = bunifuCustomDataGrid2.CurrentRow.Index;
            pacientesCbo.SelectedValue = bunifuCustomDataGrid2[0, indice].Value.ToString();
            bunifuDatepicker1.Value = Convert.ToDateTime(bunifuCustomDataGrid2[2, indice].Value);
            comboBox1.Items.Insert(0,bunifuCustomDataGrid2[3, indice].Value.ToString().Substring(0, 5));
            comboBox1.SelectedIndex = 0;
            folioCitaLb.Text=bunifuCustomDataGrid2[4, indice].Value.ToString();

            //PacienteCitaTxb.Enabled = false;
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

            if (citaController.ValidarSiExisteFechaHora(cita)== false)
            {
                comboBox1.Items.Add("02:00");
            }
            TimeSpan hora2 = TimeSpan.Parse("02:20");
            cita.setHora(hora2);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                 comboBox1.Items.Add("02:20");

            }
            TimeSpan hora3 = TimeSpan.Parse("02:40");
            cita.setHora(hora3);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("02:40");

            }
            TimeSpan hora4 = TimeSpan.Parse("03:00");
            cita.setHora(hora4);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("03:00");

            }
            TimeSpan hora5 = TimeSpan.Parse("03:20");
            cita.setHora(hora5);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("03:20");

            }
            TimeSpan hora6 = TimeSpan.Parse("03:40");
            cita.setHora(hora6);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("03:40");
            }
            TimeSpan hora7 = TimeSpan.Parse("04:00");
            cita.setHora(hora7);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("04:00");
            }
            TimeSpan hora8 = TimeSpan.Parse("04:20");
            cita.setHora(hora8);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("04:20");
            }
            TimeSpan hora9 = TimeSpan.Parse("04:40");
            cita.setHora(hora9);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("04:40");

            }
            TimeSpan hora10 = TimeSpan.Parse("05:00");
            cita.setHora(hora10);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("05:00");
            }
            TimeSpan hora11 = TimeSpan.Parse("05:20");
            cita.setHora(hora11);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("05:20");

            }
            TimeSpan hora12 = TimeSpan.Parse("05:40");
            cita.setHora(hora12);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("05:40");
            }
            TimeSpan hora13 = TimeSpan.Parse("06:00");
            cita.setHora(hora13);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("06:00");
            }
            TimeSpan hora14 = TimeSpan.Parse("06:20");
            cita.setHora(hora14);

            if (citaController.ValidarSiExisteFechaHora(cita) == false)
            {
                comboBox1.Items.Add("06:20");
            }

        }

        private void AgregarCBtn_Click(object sender, EventArgs e)
        {
            AgregarCBtn.Visible = false;
            GuardarCitaBtn.Visible = true;
            //PacienteCitaTxb.Text = " ";
            //pacientesCbo.SelectedItem.ToString();
            bunifuDatepicker1.Value = DateTime.Parse("24/07/2022");
            bunifuDatepicker1.Value = DateTime.Now.Date;
            comboBox1.Items.Insert(0, "----- Seleccione la hora----");
            comboBox1.SelectedIndex = 0;
            folioCitaLb.Text = "";
            //PacienteCitaTxb.Enabled = true;
        }

        private void PacienteCitaTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pacientesCbo.SelectedValue.ToString(), "Prueba");
        }
    }
}
