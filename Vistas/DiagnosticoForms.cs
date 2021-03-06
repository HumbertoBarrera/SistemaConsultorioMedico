using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaConsultorioMedico.Controladores;

namespace SistemaConsultorioMedico
{
    public partial class Diagnostico : Form
    {
        int idPaciente;
        DateTime fecha;
        int indice;
        private Modelos.Diagnostico diagnostico;
        private DiagnosticoController diagnosticoController = new DiagnosticoController();

        public Diagnostico(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            if (idPaciente == 0) 
                PacienteTxb.Text = "";
            else
                PacienteTxb.Text = idPaciente.ToString();
            fecha = DateTime.Now;
            FechaTxb.Text = fecha.ToString("MM/dd/yyyy");
            guardarbtn.Visible = true;
        }

        int pacienteExt;

        private void FechaTxb_MouseEnter(object sender, EventArgs e)
        {
            if (FechaTxb.Text == "FECHA")
            {
                FechaTxb.Text = "";
                FechaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void FechaTxb_MouseLeave(object sender, EventArgs e)
        {
            if (FechaTxb.Text == "")
            {
                FechaTxb.Text = "FECHA";
                FechaTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Descripciontxb_MouseEnter(object sender, EventArgs e)
        {
            if (Descripciontxb.Text == "DESCRIPCION")
            {
                Descripciontxb.Text = "";
                Descripciontxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Descripciontxb_MouseLeave(object sender, EventArgs e)
        {
            if (Descripciontxb.Text == "")
            {
                Descripciontxb.Text = "DESCRIPCION";
                Descripciontxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PacienteTxb_MouseEnter(object sender, EventArgs e)
        {
            if (PacienteTxb.Text == "PACIENTE")
            {
                PacienteTxb.Text = "";
                PacienteTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void PacienteTxb_MouseLeave(object sender, EventArgs e)
        {
            if (PacienteTxb.Text == "")
            {
                PacienteTxb.Text = "PACIENTE";
                PacienteTxb.ForeColor = Color.DarkSlateGray;
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            guardarbtn.Visible = false;

            if ((FechaTxb.Text != "FECHA") && (Descripciontxb.Text != "DESCRIPCION"))
            {
                diagnostico = new Modelos.Diagnostico();
                pacienteExt = int.Parse(PacienteTxb.Text); 
                diagnostico.setIdPaciente(pacienteExt);
                diagnostico.setFecha(fecha);
                diagnostico.setDescripcion(Descripciontxb.Text);

                if (diagnosticoController.validaExisPaciente(diagnostico))
                {
                    diagnosticoController.folio(diagnostico);
                    diagnosticoController.insertarDiagnostico(diagnostico);
                    Controladores.DiagnosticoController da = new Controladores.DiagnosticoController();
                    var dt = da.CargarGridDiagnostico(diagnostico);

                    bunifuCustomDataGrid1.DataSource = dt;
                    DataGridViewColumn Column = bunifuCustomDataGrid1.Columns[2];
                    Column.Visible = false;

                }
                else
                {
                    if (diagnosticoController.validaExisPaciente(diagnostico) == false)
                    {
                        MessageBox.Show("Error paciente no Registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              

            }
            else
            {
                MessageBox.Show("Los campos deben ser llenados");
            }
        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {
            diagnostico = new Modelos.Diagnostico();
            diagnostico.setIdPaciente(idPaciente);
            Controladores.DiagnosticoController da = new Controladores.DiagnosticoController();
            var dt = da.CargarGridDiagnostico(diagnostico);

            bunifuCustomDataGrid1.DataSource = dt;
            DataGridViewColumn Column = bunifuCustomDataGrid1.Columns[2];
            Column.Visible = false;

            Controladores.CitaController citaCont = new Controladores.CitaController();
            var dtPacientes = citaCont.LlenarComboBoxDePacientes();
            pacientesCbo.DataSource = dtPacientes;
            pacientesCbo.DisplayMember = "Nombre";
            pacientesCbo.ValueMember = "idPaciente";
            if (idPaciente == 0)
                pacientesCbo.SelectedIndex = -1;
            else
                pacientesCbo.SelectedValue = idPaciente;

            //------------------------------------------------------
            //Controladores.CitaController daC = new Controladores.CitaController();
            //var dtPacientes = daC.LlenarComboBoxDePacientes();
            //pacientesCbo.DataSource = dtPacientes;
            //pacientesCbo.DisplayMember = "Nombre";
            //pacientesCbo.ValueMember = "idPaciente";
        }

        private void BuscarCitaBtn_Click(object sender, EventArgs e)
        {
            int idPacienteV = int.Parse(pacientesCbo.SelectedValue.ToString());
            PacienteTxb.Text = pacientesCbo.SelectedValue.ToString();
            bunifuCustomDataGrid1.DataSource = null;
            Descripciontxb.Text = "";

            diagnostico = new Modelos.Diagnostico();
            diagnostico.setIdPaciente(idPacienteV);

            if (diagnosticoController.validaExisPaciente(diagnostico) == true)
            {
                Controladores.DiagnosticoController da = new Controladores.DiagnosticoController();
                var dt = da.CargarGridDiagnostico(diagnostico);

                bunifuCustomDataGrid1.DataSource = dt;
                DataGridViewColumn Column = bunifuCustomDataGrid1.Columns[2];
                Column.Visible = false;
            }
            else
            {
                if (diagnosticoController.validaExisPaciente(diagnostico) == false)
                {
                    MessageBox.Show("Error paciente no Registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PacienteTxb.Text = " ";

                }
            }
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            fecha = DateTime.Now;
            FechaTxb.Text = fecha.ToString("MM/dd/yyyy");
            Descripciontxb.Text = "";
            Descripciontxb.Enabled = true;
            guardarbtn.Visible = true;

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = bunifuCustomDataGrid1.CurrentRow.Index;
            FechaTxb.Text = bunifuCustomDataGrid1[1, indice].Value.ToString();
            Descripciontxb.Text = bunifuCustomDataGrid1[2, indice].Value.ToString();
            Descripciontxb.Enabled = false;
            guardarbtn.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
