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
        }
        int indice;

        private void PacienteCitaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (PacienteCitaTxb.Text == "PACIENTE")
            {
                PacienteCitaTxb.Text = "";
                PacienteCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PacienteCitaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (PacienteCitaTxb.Text == "")
            {
                PacienteCitaTxb.Text = "PACIENTE";
                PacienteCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaCitaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (FechaCitaTxb.Text == "FECHA")
            {
                FechaCitaTxb.Text = "";
                FechaCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaCitaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (FechaCitaTxb.Text == "")
            {
                FechaCitaTxb.Text = "FECHA";
                FechaCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void HoraCitaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (HoraCitaTxb.Text == "HORA")
            {
                HoraCitaTxb.Text = "";
                HoraCitaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void HoraCitaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (HoraCitaTxb.Text == "")
            {
                HoraCitaTxb.Text = "HORA";
                HoraCitaTxb.ForeColor = Color.DarkSlateGray;
            }
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

        private void GuardarCitaBtn_Click(object sender, EventArgs e)
        {

            if ((PacienteCitaTxb.Text != "PACIENTE") && (FechaCitaTxb.Text != "FECHA") && (HoraCitaTxb.Text != "HORA"))
            {
                Modelos.Cita cita = new Modelos.Cita();

                int idPacienteV = int.Parse(PacienteCitaTxb.Text);
                DateTime fechaV = Convert.ToDateTime(FechaCitaTxb.Text);
                TimeSpan horaV = TimeSpan.Parse(HoraCitaTxb.Text);

                cita.setIdPaciente(idPacienteV);
                cita.setFecha(fechaV);
                cita.setHora(horaV);

               
                if (Controladores.CitaController.validaExisCita(cita) == false)
                {
                    Controladores.CitaController.folio(cita);
                    Controladores.CitaController.insertarCita(cita);

                    bunifuCustomDataGrid2.DataSource = null;
                    Controladores.CitaController da = new Controladores.CitaController();
                    var dt = da.CargarGridCitas();

                    bunifuCustomDataGrid2.DataSource = dt;

                }
                else
                {
                    if(Controladores.CitaController.validaExisCita(cita) == true)
                    {
                        MessageBox.Show("Error Fecha y hora Ocupada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                PacienteCitaTxb.Text = " ";
                FechaCitaTxb.Text = " ";
                HoraCitaTxb.Text = " ";
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
        }

        private void EliminarCitaBtn_Click(object sender, EventArgs e)
        {
            Modelos.Cita cita = new Modelos.Cita();

            String folioCita = folioCitaLb.Text;
            int idPacienteV = int.Parse(PacienteCitaTxb.Text);
            DateTime fechaV = Convert.ToDateTime(FechaCitaTxb.Text);
            TimeSpan horaV = TimeSpan.Parse(HoraCitaTxb.Text);

            cita.setIdPaciente(idPacienteV);
            cita.setFecha(fechaV);
            cita.setHora(horaV);
            cita.setFolioCita(folioCita);

            Controladores.CitaController.EliminarCita(cita);
            Controladores.CitaController da = new Controladores.CitaController();
            var dt = da.CargarGridCitas();

            bunifuCustomDataGrid2.DataSource = dt;

            PacienteCitaTxb.Text = " ";
            FechaCitaTxb.Text = " ";
            HoraCitaTxb.Text = " ";
            folioCitaLb.Text = "";
            PacienteCitaTxb.Enabled = true;



        }

        private void ModificarCitaBtn_Click(object sender, EventArgs e)
        {

            Modelos.Cita cita = new Modelos.Cita();

            String folioCita = folioCitaLb.Text;
            int idPacienteV = int.Parse(PacienteCitaTxb.Text);
            DateTime fechaV = Convert.ToDateTime(FechaCitaTxb.Text);
            TimeSpan horaV = TimeSpan.Parse(HoraCitaTxb.Text);

            cita.setIdPaciente(idPacienteV);
            cita.setFecha(fechaV);
            cita.setHora(horaV);
            cita.setFolioCita(folioCita);

            Controladores.CitaController.ModificarCita(cita);
            Controladores.CitaController da = new Controladores.CitaController();
            var dt = da.CargarGridCitas();

            bunifuCustomDataGrid2.DataSource = dt;

            PacienteCitaTxb.Text = " ";
            FechaCitaTxb.Text = " ";
            HoraCitaTxb.Text = " ";
            folioCitaLb.Text = "";
            PacienteCitaTxb.Enabled = true;

        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indice = bunifuCustomDataGrid2.CurrentRow.Index;
            PacienteCitaTxb.Text = bunifuCustomDataGrid2[0, indice].Value.ToString();
            FechaCitaTxb.Text = bunifuCustomDataGrid2[1, indice].Value.ToString();
            HoraCitaTxb.Text = bunifuCustomDataGrid2[2, indice].Value.ToString();
            folioCitaLb.Text=bunifuCustomDataGrid2[3, indice].Value.ToString();

            PacienteCitaTxb.Enabled = false;

        }

        private void PacientesBtn_Click(object sender, EventArgs e)
        {
        }


    }
}
