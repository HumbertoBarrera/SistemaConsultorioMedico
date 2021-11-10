
namespace SistemaConsultorioMedico
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Guardarbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BuscarTbx = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DiagnosticoBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CitasBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InforMedicaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guardarPac_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NombreTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FechaNacTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LugarNaciTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Direcciontxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TelefonoTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CorreoETxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OcupacionTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LugarTrabajoTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.ElipsePacientes = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ApellidoMaternoTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ApellidoPaternoTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.IdPacienteLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.ActiveBorderThickness = 1;
            this.Guardarbtn.ActiveCornerRadius = 20;
            this.Guardarbtn.ActiveFillColor = System.Drawing.Color.White;
            this.Guardarbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Guardarbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Guardarbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Guardarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guardarbtn.BackgroundImage")));
            this.Guardarbtn.ButtonText = "ELIMINAR";
            this.Guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardarbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Guardarbtn.IdleBorderThickness = 1;
            this.Guardarbtn.IdleCornerRadius = 20;
            this.Guardarbtn.IdleFillColor = System.Drawing.Color.White;
            this.Guardarbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Guardarbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Guardarbtn.Location = new System.Drawing.Point(24, 718);
            this.Guardarbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(209, 50);
            this.Guardarbtn.TabIndex = 13;
            this.Guardarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuscarTbx
            // 
            this.BuscarTbx.BackColor = System.Drawing.Color.White;
            this.BuscarTbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarTbx.BackgroundImage")));
            this.BuscarTbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarTbx.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTbx.ForeColor = System.Drawing.Color.Purple;
            this.BuscarTbx.Icon = ((System.Drawing.Image)(resources.GetObject("BuscarTbx.Icon")));
            this.BuscarTbx.Location = new System.Drawing.Point(833, 100);
            this.BuscarTbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarTbx.Name = "BuscarTbx";
            this.BuscarTbx.Size = new System.Drawing.Size(489, 33);
            this.BuscarTbx.TabIndex = 14;
            this.BuscarTbx.text = "";
            this.BuscarTbx.OnTextChange += new System.EventHandler(this.BuscarTbx_OnTextChange);
            this.BuscarTbx.MouseEnter += new System.EventHandler(this.BuscarTbx_MouseEnter);
            this.BuscarTbx.MouseLeave += new System.EventHandler(this.BuscarTbx_MouseLeave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(481, 33);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(134, 30);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "PACIENTES";
            // 
            // DiagnosticoBtn
            // 
            this.DiagnosticoBtn.ActiveBorderThickness = 1;
            this.DiagnosticoBtn.ActiveCornerRadius = 20;
            this.DiagnosticoBtn.ActiveFillColor = System.Drawing.Color.White;
            this.DiagnosticoBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DiagnosticoBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DiagnosticoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DiagnosticoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiagnosticoBtn.BackgroundImage")));
            this.DiagnosticoBtn.ButtonText = "DIAGNOSTICO";
            this.DiagnosticoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagnosticoBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticoBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DiagnosticoBtn.IdleBorderThickness = 1;
            this.DiagnosticoBtn.IdleCornerRadius = 20;
            this.DiagnosticoBtn.IdleFillColor = System.Drawing.Color.White;
            this.DiagnosticoBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DiagnosticoBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DiagnosticoBtn.Location = new System.Drawing.Point(1119, 655);
            this.DiagnosticoBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DiagnosticoBtn.Name = "DiagnosticoBtn";
            this.DiagnosticoBtn.Size = new System.Drawing.Size(209, 50);
            this.DiagnosticoBtn.TabIndex = 17;
            this.DiagnosticoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CitasBtn
            // 
            this.CitasBtn.ActiveBorderThickness = 1;
            this.CitasBtn.ActiveCornerRadius = 20;
            this.CitasBtn.ActiveFillColor = System.Drawing.Color.White;
            this.CitasBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CitasBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CitasBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CitasBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CitasBtn.BackgroundImage")));
            this.CitasBtn.ButtonText = "CITAS";
            this.CitasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CitasBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitasBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.CitasBtn.IdleBorderThickness = 1;
            this.CitasBtn.IdleCornerRadius = 20;
            this.CitasBtn.IdleFillColor = System.Drawing.Color.White;
            this.CitasBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CitasBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CitasBtn.Location = new System.Drawing.Point(863, 655);
            this.CitasBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CitasBtn.Name = "CitasBtn";
            this.CitasBtn.Size = new System.Drawing.Size(209, 50);
            this.CitasBtn.TabIndex = 16;
            this.CitasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InforMedicaBtn
            // 
            this.InforMedicaBtn.ActiveBorderThickness = 1;
            this.InforMedicaBtn.ActiveCornerRadius = 20;
            this.InforMedicaBtn.ActiveFillColor = System.Drawing.Color.White;
            this.InforMedicaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.InforMedicaBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InforMedicaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InforMedicaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InforMedicaBtn.BackgroundImage")));
            this.InforMedicaBtn.ButtonText = "INFORMACION MEDICA";
            this.InforMedicaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InforMedicaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InforMedicaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.InforMedicaBtn.IdleBorderThickness = 1;
            this.InforMedicaBtn.IdleCornerRadius = 20;
            this.InforMedicaBtn.IdleFillColor = System.Drawing.Color.White;
            this.InforMedicaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InforMedicaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InforMedicaBtn.Location = new System.Drawing.Point(563, 655);
            this.InforMedicaBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.InforMedicaBtn.Name = "InforMedicaBtn";
            this.InforMedicaBtn.Size = new System.Drawing.Size(287, 50);
            this.InforMedicaBtn.TabIndex = 15;
            this.InforMedicaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "MODIFICAR";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton24.Location = new System.Drawing.Point(267, 655);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(209, 50);
            this.bunifuThinButton24.TabIndex = 12;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guardarPac_Btn
            // 
            this.guardarPac_Btn.ActiveBorderThickness = 1;
            this.guardarPac_Btn.ActiveCornerRadius = 20;
            this.guardarPac_Btn.ActiveFillColor = System.Drawing.Color.White;
            this.guardarPac_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.guardarPac_Btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guardarPac_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarPac_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarPac_Btn.BackgroundImage")));
            this.guardarPac_Btn.ButtonText = "GUARDAR";
            this.guardarPac_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarPac_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarPac_Btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.guardarPac_Btn.IdleBorderThickness = 1;
            this.guardarPac_Btn.IdleCornerRadius = 20;
            this.guardarPac_Btn.IdleFillColor = System.Drawing.Color.White;
            this.guardarPac_Btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarPac_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarPac_Btn.Location = new System.Drawing.Point(24, 655);
            this.guardarPac_Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guardarPac_Btn.Name = "guardarPac_Btn";
            this.guardarPac_Btn.Size = new System.Drawing.Size(209, 50);
            this.guardarPac_Btn.TabIndex = 11;
            this.guardarPac_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guardarPac_Btn.Click += new System.EventHandler(this.guardarPac_Btn_Click);
            // 
            // NombreTxb
            // 
            this.NombreTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreTxb.ForeColor = System.Drawing.Color.Black;
            this.NombreTxb.HintForeColor = System.Drawing.Color.Empty;
            this.NombreTxb.HintText = "";
            this.NombreTxb.isPassword = false;
            this.NombreTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.NombreTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.NombreTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NombreTxb.LineThickness = 3;
            this.NombreTxb.Location = new System.Drawing.Point(20, 112);
            this.NombreTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NombreTxb.Name = "NombreTxb";
            this.NombreTxb.Size = new System.Drawing.Size(505, 41);
            this.NombreTxb.TabIndex = 1;
            this.NombreTxb.Text = "NOMBRES";
            this.NombreTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreTxb.OnValueChanged += new System.EventHandler(this.NombreTxb_OnValueChanged);
            this.NombreTxb.MouseEnter += new System.EventHandler(this.NombreTxb_MouseEnter);
            this.NombreTxb.MouseLeave += new System.EventHandler(this.NombreTxb_MouseLeave);
            // 
            // FechaNacTxb
            // 
            this.FechaNacTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaNacTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FechaNacTxb.ForeColor = System.Drawing.Color.Black;
            this.FechaNacTxb.HintForeColor = System.Drawing.Color.Empty;
            this.FechaNacTxb.HintText = "";
            this.FechaNacTxb.isPassword = false;
            this.FechaNacTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.FechaNacTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.FechaNacTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FechaNacTxb.LineThickness = 3;
            this.FechaNacTxb.Location = new System.Drawing.Point(17, 265);
            this.FechaNacTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FechaNacTxb.Name = "FechaNacTxb";
            this.FechaNacTxb.Size = new System.Drawing.Size(505, 41);
            this.FechaNacTxb.TabIndex = 4;
            this.FechaNacTxb.Text = "FECHA NACIMIENTO";
            this.FechaNacTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FechaNacTxb.OnValueChanged += new System.EventHandler(this.FechaNacTxb_OnValueChanged);
            this.FechaNacTxb.MouseEnter += new System.EventHandler(this.FechaNacTxb_MouseEnter);
            this.FechaNacTxb.MouseLeave += new System.EventHandler(this.FechaNacTxb_MouseLeave);
            // 
            // LugarNaciTxb
            // 
            this.LugarNaciTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LugarNaciTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LugarNaciTxb.ForeColor = System.Drawing.Color.Black;
            this.LugarNaciTxb.HintForeColor = System.Drawing.Color.Empty;
            this.LugarNaciTxb.HintText = "";
            this.LugarNaciTxb.isPassword = false;
            this.LugarNaciTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.LugarNaciTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.LugarNaciTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.LugarNaciTxb.LineThickness = 3;
            this.LugarNaciTxb.Location = new System.Drawing.Point(16, 315);
            this.LugarNaciTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LugarNaciTxb.Name = "LugarNaciTxb";
            this.LugarNaciTxb.Size = new System.Drawing.Size(505, 41);
            this.LugarNaciTxb.TabIndex = 5;
            this.LugarNaciTxb.Text = "LUGAR DE NACIMIENTO";
            this.LugarNaciTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LugarNaciTxb.OnValueChanged += new System.EventHandler(this.LugarNaciTxb_OnValueChanged);
            this.LugarNaciTxb.MouseEnter += new System.EventHandler(this.LugarNaciTxb_MouseEnter);
            this.LugarNaciTxb.MouseLeave += new System.EventHandler(this.LugarNaciTxb_MouseLeave);
            // 
            // Direcciontxb
            // 
            this.Direcciontxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Direcciontxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Direcciontxb.ForeColor = System.Drawing.Color.Black;
            this.Direcciontxb.HintForeColor = System.Drawing.Color.Empty;
            this.Direcciontxb.HintText = "";
            this.Direcciontxb.isPassword = false;
            this.Direcciontxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Direcciontxb.LineIdleColor = System.Drawing.Color.Purple;
            this.Direcciontxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Direcciontxb.LineThickness = 3;
            this.Direcciontxb.Location = new System.Drawing.Point(17, 366);
            this.Direcciontxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Direcciontxb.Name = "Direcciontxb";
            this.Direcciontxb.Size = new System.Drawing.Size(505, 41);
            this.Direcciontxb.TabIndex = 6;
            this.Direcciontxb.Text = "DIRECCION";
            this.Direcciontxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Direcciontxb.MouseEnter += new System.EventHandler(this.Direcciontxb_MouseEnter);
            this.Direcciontxb.MouseLeave += new System.EventHandler(this.Direcciontxb_MouseLeave);
            // 
            // TelefonoTxb
            // 
            this.TelefonoTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TelefonoTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TelefonoTxb.ForeColor = System.Drawing.Color.Black;
            this.TelefonoTxb.HintForeColor = System.Drawing.Color.Empty;
            this.TelefonoTxb.HintText = "";
            this.TelefonoTxb.isPassword = false;
            this.TelefonoTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.TelefonoTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.TelefonoTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TelefonoTxb.LineThickness = 3;
            this.TelefonoTxb.Location = new System.Drawing.Point(16, 416);
            this.TelefonoTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TelefonoTxb.Name = "TelefonoTxb";
            this.TelefonoTxb.Size = new System.Drawing.Size(505, 41);
            this.TelefonoTxb.TabIndex = 7;
            this.TelefonoTxb.Text = "TELEFONO";
            this.TelefonoTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TelefonoTxb.MouseEnter += new System.EventHandler(this.TelefonoTxb_MouseEnter);
            this.TelefonoTxb.MouseLeave += new System.EventHandler(this.TelefonoTxb_MouseLeave);
            // 
            // CorreoETxb
            // 
            this.CorreoETxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CorreoETxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorreoETxb.ForeColor = System.Drawing.Color.Black;
            this.CorreoETxb.HintForeColor = System.Drawing.Color.Empty;
            this.CorreoETxb.HintText = "";
            this.CorreoETxb.isPassword = false;
            this.CorreoETxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.CorreoETxb.LineIdleColor = System.Drawing.Color.Purple;
            this.CorreoETxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CorreoETxb.LineThickness = 3;
            this.CorreoETxb.Location = new System.Drawing.Point(16, 466);
            this.CorreoETxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CorreoETxb.Name = "CorreoETxb";
            this.CorreoETxb.Size = new System.Drawing.Size(505, 41);
            this.CorreoETxb.TabIndex = 8;
            this.CorreoETxb.Text = "CORREO ELECTRONICO";
            this.CorreoETxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CorreoETxb.MouseEnter += new System.EventHandler(this.CorreoETxb_MouseEnter);
            this.CorreoETxb.MouseLeave += new System.EventHandler(this.CorreoETxb_MouseLeave);
            // 
            // OcupacionTxb
            // 
            this.OcupacionTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OcupacionTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OcupacionTxb.ForeColor = System.Drawing.Color.Black;
            this.OcupacionTxb.HintForeColor = System.Drawing.Color.Empty;
            this.OcupacionTxb.HintText = "";
            this.OcupacionTxb.isPassword = false;
            this.OcupacionTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.OcupacionTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.OcupacionTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.OcupacionTxb.LineThickness = 3;
            this.OcupacionTxb.Location = new System.Drawing.Point(15, 517);
            this.OcupacionTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.OcupacionTxb.Name = "OcupacionTxb";
            this.OcupacionTxb.Size = new System.Drawing.Size(505, 41);
            this.OcupacionTxb.TabIndex = 9;
            this.OcupacionTxb.Text = "OCUPACION";
            this.OcupacionTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OcupacionTxb.MouseEnter += new System.EventHandler(this.OcupacionTxb_MouseEnter);
            this.OcupacionTxb.MouseLeave += new System.EventHandler(this.OcupacionTxb_MouseLeave);
            // 
            // LugarTrabajoTxb
            // 
            this.LugarTrabajoTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LugarTrabajoTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LugarTrabajoTxb.ForeColor = System.Drawing.Color.Black;
            this.LugarTrabajoTxb.HintForeColor = System.Drawing.Color.Empty;
            this.LugarTrabajoTxb.HintText = "";
            this.LugarTrabajoTxb.isPassword = false;
            this.LugarTrabajoTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.LugarTrabajoTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.LugarTrabajoTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.LugarTrabajoTxb.LineThickness = 3;
            this.LugarTrabajoTxb.Location = new System.Drawing.Point(15, 567);
            this.LugarTrabajoTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LugarTrabajoTxb.Name = "LugarTrabajoTxb";
            this.LugarTrabajoTxb.Size = new System.Drawing.Size(505, 41);
            this.LugarTrabajoTxb.TabIndex = 10;
            this.LugarTrabajoTxb.Text = "LUGAR DE TRABAJO";
            this.LugarTrabajoTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LugarTrabajoTxb.MouseEnter += new System.EventHandler(this.LugarTrabajoTxb_MouseEnter);
            this.LugarTrabajoTxb.MouseLeave += new System.EventHandler(this.LugarTrabajoTxb_MouseLeave);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(563, 142);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(783, 364);
            this.bunifuCustomDataGrid1.TabIndex = 26;
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(396, 65);
            this.linea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(327, 12);
            this.linea.TabIndex = 27;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // ElipsePacientes
            // 
            this.ElipsePacientes.ElipseRadius = 7;
            this.ElipsePacientes.TargetControl = this;
            // 
            // ApellidoMaternoTxb
            // 
            this.ApellidoMaternoTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApellidoMaternoTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ApellidoMaternoTxb.ForeColor = System.Drawing.Color.Black;
            this.ApellidoMaternoTxb.HintForeColor = System.Drawing.Color.Empty;
            this.ApellidoMaternoTxb.HintText = "";
            this.ApellidoMaternoTxb.isPassword = false;
            this.ApellidoMaternoTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ApellidoMaternoTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.ApellidoMaternoTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ApellidoMaternoTxb.LineThickness = 3;
            this.ApellidoMaternoTxb.Location = new System.Drawing.Point(16, 214);
            this.ApellidoMaternoTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ApellidoMaternoTxb.Name = "ApellidoMaternoTxb";
            this.ApellidoMaternoTxb.Size = new System.Drawing.Size(505, 41);
            this.ApellidoMaternoTxb.TabIndex = 3;
            this.ApellidoMaternoTxb.Text = "APELLIDO MATERNO";
            this.ApellidoMaternoTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ApellidoMaternoTxb.MouseEnter += new System.EventHandler(this.ApellidoMaternoTxb_MouseEnter);
            this.ApellidoMaternoTxb.MouseLeave += new System.EventHandler(this.ApellidoMaternoTxb_MouseLeave);
            // 
            // ApellidoPaternoTbx
            // 
            this.ApellidoPaternoTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApellidoPaternoTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ApellidoPaternoTbx.ForeColor = System.Drawing.Color.Black;
            this.ApellidoPaternoTbx.HintForeColor = System.Drawing.Color.Empty;
            this.ApellidoPaternoTbx.HintText = "";
            this.ApellidoPaternoTbx.isPassword = false;
            this.ApellidoPaternoTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.ApellidoPaternoTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.ApellidoPaternoTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ApellidoPaternoTbx.LineThickness = 3;
            this.ApellidoPaternoTbx.Location = new System.Drawing.Point(20, 162);
            this.ApellidoPaternoTbx.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ApellidoPaternoTbx.Name = "ApellidoPaternoTbx";
            this.ApellidoPaternoTbx.Size = new System.Drawing.Size(505, 41);
            this.ApellidoPaternoTbx.TabIndex = 2;
            this.ApellidoPaternoTbx.Text = "APELLIDO PATERNO";
            this.ApellidoPaternoTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ApellidoPaternoTbx.MouseEnter += new System.EventHandler(this.ApellidoPaternoTbx_MouseEnter);
            this.ApellidoPaternoTbx.MouseLeave += new System.EventHandler(this.ApellidoPaternoTbx_MouseLeave);
            // 
            // IdPacienteLbl
            // 
            this.IdPacienteLbl.AutoSize = true;
            this.IdPacienteLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPacienteLbl.Location = new System.Drawing.Point(20, 87);
            this.IdPacienteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdPacienteLbl.Name = "IdPacienteLbl";
            this.IdPacienteLbl.Size = new System.Drawing.Size(120, 23);
            this.IdPacienteLbl.TabIndex = 30;
            this.IdPacienteLbl.Text = "ID PACIENTE";
            this.IdPacienteLbl.Visible = false;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1361, 775);
            this.Controls.Add(this.IdPacienteLbl);
            this.Controls.Add(this.ApellidoPaternoTbx);
            this.Controls.Add(this.ApellidoMaternoTxb);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.LugarTrabajoTxb);
            this.Controls.Add(this.OcupacionTxb);
            this.Controls.Add(this.CorreoETxb);
            this.Controls.Add(this.TelefonoTxb);
            this.Controls.Add(this.Direcciontxb);
            this.Controls.Add(this.LugarNaciTxb);
            this.Controls.Add(this.FechaNacTxb);
            this.Controls.Add(this.NombreTxb);
            this.Controls.Add(this.guardarPac_Btn);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.InforMedicaBtn);
            this.Controls.Add(this.CitasBtn);
            this.Controls.Add(this.DiagnosticoBtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BuscarTbx);
            this.Controls.Add(this.Guardarbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Paciente";
            this.Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 Guardarbtn;
        private Bunifu.Framework.UI.BunifuTextbox BuscarTbx;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 DiagnosticoBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 CitasBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 InforMedicaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarPac_Btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FechaNacTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LugarNaciTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Direcciontxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TelefonoTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CorreoETxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OcupacionTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LugarTrabajoTxb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuElipse ElipsePacientes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ApellidoPaternoTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ApellidoMaternoTxb;
        private Bunifu.Framework.UI.BunifuCustomLabel IdPacienteLbl;
    }
}