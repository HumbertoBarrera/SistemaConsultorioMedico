
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EliPacienteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BuscarTbx = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DiagnosticoBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InforMedicaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ModifPacienteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guardarPac_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NombreTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LugarNaciTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DireccionTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TelefonoTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CorreoETbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OcupacionTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LugarTrabajoTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.ApellidoMaternoTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ApellidoPaternoTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.IdPacienteLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fechaNacDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.correoErrorLbl = new System.Windows.Forms.Label();
            this.errorDigit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // EliPacienteBtn
            // 
            this.EliPacienteBtn.ActiveBorderThickness = 1;
            this.EliPacienteBtn.ActiveCornerRadius = 20;
            this.EliPacienteBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.EliPacienteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EliPacienteBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.EliPacienteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliPacienteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EliPacienteBtn.BackgroundImage")));
            this.EliPacienteBtn.ButtonText = "ELIMINAR";
            this.EliPacienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliPacienteBtn.Enabled = false;
            this.EliPacienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliPacienteBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.EliPacienteBtn.IdleBorderThickness = 1;
            this.EliPacienteBtn.IdleCornerRadius = 20;
            this.EliPacienteBtn.IdleFillColor = System.Drawing.Color.Gray;
            this.EliPacienteBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EliPacienteBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EliPacienteBtn.Location = new System.Drawing.Point(27, 726);
            this.EliPacienteBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EliPacienteBtn.Name = "EliPacienteBtn";
            this.EliPacienteBtn.Padding = new System.Windows.Forms.Padding(48, 12, 0, 12);
            this.EliPacienteBtn.Size = new System.Drawing.Size(209, 50);
            this.EliPacienteBtn.TabIndex = 13;
            this.EliPacienteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliPacienteBtn.Click += new System.EventHandler(this.EliPacienteBtn_Click);
            this.EliPacienteBtn.EnabledChanged += new System.EventHandler(this.bloqueoBotonEli);
            // 
            // BuscarTbx
            // 
            this.BuscarTbx.BackColor = System.Drawing.Color.White;
            this.BuscarTbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarTbx.BackgroundImage")));
            this.BuscarTbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarTbx.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTbx.ForeColor = System.Drawing.Color.Purple;
            this.BuscarTbx.Icon = ((System.Drawing.Image)(resources.GetObject("BuscarTbx.Icon")));
            this.BuscarTbx.Location = new System.Drawing.Point(857, 114);
            this.BuscarTbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarTbx.Name = "BuscarTbx";
            this.BuscarTbx.Size = new System.Drawing.Size(489, 33);
            this.BuscarTbx.TabIndex = 14;
            this.BuscarTbx.text = "";
            this.BuscarTbx.MouseEnter += new System.EventHandler(this.BuscarTbx_MouseEnter);
            this.BuscarTbx.MouseLeave += new System.EventHandler(this.BuscarTbx_MouseLeave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(597, 27);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 29);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "PACIENTES";
            // 
            // DiagnosticoBtn
            // 
            this.DiagnosticoBtn.ActiveBorderThickness = 1;
            this.DiagnosticoBtn.ActiveCornerRadius = 20;
            this.DiagnosticoBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.DiagnosticoBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DiagnosticoBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.DiagnosticoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DiagnosticoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiagnosticoBtn.BackgroundImage")));
            this.DiagnosticoBtn.ButtonText = "DIAGNOSTICO";
            this.DiagnosticoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagnosticoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticoBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.DiagnosticoBtn.IdleBorderThickness = 1;
            this.DiagnosticoBtn.IdleCornerRadius = 20;
            this.DiagnosticoBtn.IdleFillColor = System.Drawing.Color.White;
            this.DiagnosticoBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DiagnosticoBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DiagnosticoBtn.Location = new System.Drawing.Point(864, 668);
            this.DiagnosticoBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DiagnosticoBtn.Name = "DiagnosticoBtn";
            this.DiagnosticoBtn.Size = new System.Drawing.Size(209, 50);
            this.DiagnosticoBtn.TabIndex = 17;
            this.DiagnosticoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiagnosticoBtn.Click += new System.EventHandler(this.DiagnosticoBtn_Click);
            // 
            // InforMedicaBtn
            // 
            this.InforMedicaBtn.ActiveBorderThickness = 1;
            this.InforMedicaBtn.ActiveCornerRadius = 20;
            this.InforMedicaBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.InforMedicaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.InforMedicaBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.InforMedicaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InforMedicaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InforMedicaBtn.BackgroundImage")));
            this.InforMedicaBtn.ButtonText = "INFORMACION MEDICA";
            this.InforMedicaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InforMedicaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InforMedicaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.InforMedicaBtn.IdleBorderThickness = 1;
            this.InforMedicaBtn.IdleCornerRadius = 20;
            this.InforMedicaBtn.IdleFillColor = System.Drawing.Color.White;
            this.InforMedicaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InforMedicaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InforMedicaBtn.Location = new System.Drawing.Point(563, 668);
            this.InforMedicaBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.InforMedicaBtn.Name = "InforMedicaBtn";
            this.InforMedicaBtn.Size = new System.Drawing.Size(287, 50);
            this.InforMedicaBtn.TabIndex = 15;
            this.InforMedicaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InforMedicaBtn.Click += new System.EventHandler(this.InforMedicaBtn_Click);
            // 
            // ModifPacienteBtn
            // 
            this.ModifPacienteBtn.ActiveBorderThickness = 1;
            this.ModifPacienteBtn.ActiveCornerRadius = 20;
            this.ModifPacienteBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.ModifPacienteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ModifPacienteBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.ModifPacienteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModifPacienteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModifPacienteBtn.BackgroundImage")));
            this.ModifPacienteBtn.ButtonText = "MODIFICAR";
            this.ModifPacienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifPacienteBtn.Enabled = false;
            this.ModifPacienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifPacienteBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.ModifPacienteBtn.IdleBorderThickness = 1;
            this.ModifPacienteBtn.IdleCornerRadius = 20;
            this.ModifPacienteBtn.IdleFillColor = System.Drawing.Color.Gray;
            this.ModifPacienteBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModifPacienteBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModifPacienteBtn.Location = new System.Drawing.Point(275, 668);
            this.ModifPacienteBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ModifPacienteBtn.Name = "ModifPacienteBtn";
            this.ModifPacienteBtn.Padding = new System.Windows.Forms.Padding(40, 12, 0, 12);
            this.ModifPacienteBtn.Size = new System.Drawing.Size(209, 50);
            this.ModifPacienteBtn.TabIndex = 12;
            this.ModifPacienteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModifPacienteBtn.Click += new System.EventHandler(this.ModifPacienteBtn_Click);
            this.ModifPacienteBtn.EnabledChanged += new System.EventHandler(this.bloqueoBotonMod);
            // 
            // guardarPac_Btn
            // 
            this.guardarPac_Btn.ActiveBorderThickness = 1;
            this.guardarPac_Btn.ActiveCornerRadius = 20;
            this.guardarPac_Btn.ActiveFillColor = System.Drawing.Color.Plum;
            this.guardarPac_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.guardarPac_Btn.ActiveLineColor = System.Drawing.Color.Plum;
            this.guardarPac_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarPac_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarPac_Btn.BackgroundImage")));
            this.guardarPac_Btn.ButtonText = "GUARDAR";
            this.guardarPac_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarPac_Btn.Enabled = false;
            this.guardarPac_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarPac_Btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.guardarPac_Btn.IdleBorderThickness = 1;
            this.guardarPac_Btn.IdleCornerRadius = 20;
            this.guardarPac_Btn.IdleFillColor = System.Drawing.Color.Gray;
            this.guardarPac_Btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarPac_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarPac_Btn.Location = new System.Drawing.Point(27, 668);
            this.guardarPac_Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guardarPac_Btn.Name = "guardarPac_Btn";
            this.guardarPac_Btn.Padding = new System.Windows.Forms.Padding(44, 12, 0, 12);
            this.guardarPac_Btn.Size = new System.Drawing.Size(209, 50);
            this.guardarPac_Btn.TabIndex = 11;
            this.guardarPac_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guardarPac_Btn.Click += new System.EventHandler(this.guardarPac_Btn_Click);
            this.guardarPac_Btn.EnabledChanged += new System.EventHandler(this.bloqueoBotonGuardar);
            // 
            // NombreTxb
            // 
            this.NombreTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NombreTxb.ForeColor = System.Drawing.Color.Black;
            this.NombreTxb.HintForeColor = System.Drawing.Color.DimGray;
            this.NombreTxb.HintText = "NOMBRES";
            this.NombreTxb.isPassword = false;
            this.NombreTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.NombreTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.NombreTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NombreTxb.LineThickness = 3;
            this.NombreTxb.Location = new System.Drawing.Point(21, 138);
            this.NombreTxb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NombreTxb.Name = "NombreTxb";
            this.NombreTxb.Size = new System.Drawing.Size(511, 41);
            this.NombreTxb.TabIndex = 1;
            this.NombreTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreTxb.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // LugarNaciTbx
            // 
            this.LugarNaciTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LugarNaciTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LugarNaciTbx.ForeColor = System.Drawing.Color.Black;
            this.LugarNaciTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.LugarNaciTbx.HintText = "LUGAR DE NACIMIENTO";
            this.LugarNaciTbx.isPassword = false;
            this.LugarNaciTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.LugarNaciTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.LugarNaciTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.LugarNaciTbx.LineThickness = 3;
            this.LugarNaciTbx.Location = new System.Drawing.Point(21, 350);
            this.LugarNaciTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LugarNaciTbx.Name = "LugarNaciTbx";
            this.LugarNaciTbx.Size = new System.Drawing.Size(505, 41);
            this.LugarNaciTbx.TabIndex = 5;
            this.LugarNaciTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LugarNaciTbx.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // DireccionTbx
            // 
            this.DireccionTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DireccionTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DireccionTbx.ForeColor = System.Drawing.Color.Black;
            this.DireccionTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.DireccionTbx.HintText = "DIRECCION";
            this.DireccionTbx.isPassword = false;
            this.DireccionTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.DireccionTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.DireccionTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.DireccionTbx.LineThickness = 3;
            this.DireccionTbx.Location = new System.Drawing.Point(21, 402);
            this.DireccionTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DireccionTbx.Name = "DireccionTbx";
            this.DireccionTbx.Size = new System.Drawing.Size(505, 41);
            this.DireccionTbx.TabIndex = 6;
            this.DireccionTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DireccionTbx.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // TelefonoTbx
            // 
            this.TelefonoTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TelefonoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TelefonoTbx.ForeColor = System.Drawing.Color.Black;
            this.TelefonoTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.TelefonoTbx.HintText = "TELEFONO";
            this.TelefonoTbx.isPassword = false;
            this.TelefonoTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.TelefonoTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.TelefonoTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TelefonoTbx.LineThickness = 3;
            this.TelefonoTbx.Location = new System.Drawing.Point(20, 455);
            this.TelefonoTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TelefonoTbx.Name = "TelefonoTbx";
            this.TelefonoTbx.Size = new System.Drawing.Size(505, 41);
            this.TelefonoTbx.TabIndex = 7;
            this.TelefonoTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TelefonoTbx.OnValueChanged += new System.EventHandler(this.validarNumeros);
            // 
            // CorreoETbx
            // 
            this.CorreoETbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CorreoETbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CorreoETbx.ForeColor = System.Drawing.Color.Black;
            this.CorreoETbx.HintForeColor = System.Drawing.Color.DimGray;
            this.CorreoETbx.HintText = "CORREO ELECTRONICO";
            this.CorreoETbx.isPassword = false;
            this.CorreoETbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.CorreoETbx.LineIdleColor = System.Drawing.Color.Purple;
            this.CorreoETbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CorreoETbx.LineThickness = 3;
            this.CorreoETbx.Location = new System.Drawing.Point(16, 510);
            this.CorreoETbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CorreoETbx.Name = "CorreoETbx";
            this.CorreoETbx.Size = new System.Drawing.Size(505, 41);
            this.CorreoETbx.TabIndex = 8;
            this.CorreoETbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CorreoETbx.OnValueChanged += new System.EventHandler(this.verificarEmail);
            // 
            // OcupacionTbx
            // 
            this.OcupacionTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OcupacionTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OcupacionTbx.ForeColor = System.Drawing.Color.Black;
            this.OcupacionTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.OcupacionTbx.HintText = "OCUPACION";
            this.OcupacionTbx.isPassword = false;
            this.OcupacionTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.OcupacionTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.OcupacionTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.OcupacionTbx.LineThickness = 3;
            this.OcupacionTbx.Location = new System.Drawing.Point(16, 562);
            this.OcupacionTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OcupacionTbx.Name = "OcupacionTbx";
            this.OcupacionTbx.Size = new System.Drawing.Size(505, 41);
            this.OcupacionTbx.TabIndex = 9;
            this.OcupacionTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OcupacionTbx.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // LugarTrabajoTbx
            // 
            this.LugarTrabajoTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LugarTrabajoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LugarTrabajoTbx.ForeColor = System.Drawing.Color.Black;
            this.LugarTrabajoTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.LugarTrabajoTbx.HintText = "LUGAR DE TRABAJO";
            this.LugarTrabajoTbx.isPassword = false;
            this.LugarTrabajoTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.LugarTrabajoTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.LugarTrabajoTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.LugarTrabajoTbx.LineThickness = 3;
            this.LugarTrabajoTbx.Location = new System.Drawing.Point(16, 615);
            this.LugarTrabajoTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LugarTrabajoTbx.Name = "LugarTrabajoTbx";
            this.LugarTrabajoTbx.Size = new System.Drawing.Size(505, 41);
            this.LugarTrabajoTbx.TabIndex = 10;
            this.LugarTrabajoTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LugarTrabajoTbx.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(563, 169);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(783, 487);
            this.bunifuCustomDataGrid1.TabIndex = 26;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.llenarInfoPacientes_DataGrid);
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(508, 63);
            this.linea.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(327, 12);
            this.linea.TabIndex = 27;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // ApellidoMaternoTbx
            // 
            this.ApellidoMaternoTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApellidoMaternoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ApellidoMaternoTbx.ForeColor = System.Drawing.Color.Black;
            this.ApellidoMaternoTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.ApellidoMaternoTbx.HintText = "APELLIDO MATERNO";
            this.ApellidoMaternoTbx.isPassword = false;
            this.ApellidoMaternoTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.ApellidoMaternoTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.ApellidoMaternoTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ApellidoMaternoTbx.LineThickness = 3;
            this.ApellidoMaternoTbx.Location = new System.Drawing.Point(21, 244);
            this.ApellidoMaternoTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ApellidoMaternoTbx.Name = "ApellidoMaternoTbx";
            this.ApellidoMaternoTbx.Size = new System.Drawing.Size(511, 41);
            this.ApellidoMaternoTbx.TabIndex = 3;
            this.ApellidoMaternoTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ApellidoMaternoTbx.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // ApellidoPaternoTbx
            // 
            this.ApellidoPaternoTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApellidoPaternoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ApellidoPaternoTbx.ForeColor = System.Drawing.Color.Black;
            this.ApellidoPaternoTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.ApellidoPaternoTbx.HintText = "APELLIDO PATERNO";
            this.ApellidoPaternoTbx.isPassword = false;
            this.ApellidoPaternoTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.ApellidoPaternoTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.ApellidoPaternoTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ApellidoPaternoTbx.LineThickness = 3;
            this.ApellidoPaternoTbx.Location = new System.Drawing.Point(20, 191);
            this.ApellidoPaternoTbx.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ApellidoPaternoTbx.Name = "ApellidoPaternoTbx";
            this.ApellidoPaternoTbx.Size = new System.Drawing.Size(509, 41);
            this.ApellidoPaternoTbx.TabIndex = 2;
            this.ApellidoPaternoTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ApellidoPaternoTbx.OnValueChanged += new System.EventHandler(this.bloqueoBtnGuardar);
            // 
            // IdPacienteLbl
            // 
            this.IdPacienteLbl.AutoSize = true;
            this.IdPacienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPacienteLbl.Location = new System.Drawing.Point(20, 87);
            this.IdPacienteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdPacienteLbl.Name = "IdPacienteLbl";
            this.IdPacienteLbl.Size = new System.Drawing.Size(137, 24);
            this.IdPacienteLbl.TabIndex = 30;
            this.IdPacienteLbl.Text = "ID PACIENTE";
            this.IdPacienteLbl.Visible = false;
            // 
            // fechaNacDatePicker
            // 
            this.fechaNacDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fechaNacDatePicker.BorderRadius = 0;
            this.fechaNacDatePicker.ForeColor = System.Drawing.Color.White;
            this.fechaNacDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaNacDatePicker.FormatCustom = null;
            this.fechaNacDatePicker.Location = new System.Drawing.Point(17, 295);
            this.fechaNacDatePicker.Margin = new System.Windows.Forms.Padding(5);
            this.fechaNacDatePicker.Name = "fechaNacDatePicker";
            this.fechaNacDatePicker.Size = new System.Drawing.Size(512, 44);
            this.fechaNacDatePicker.TabIndex = 4;
            this.fechaNacDatePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // correoErrorLbl
            // 
            this.correoErrorLbl.AutoSize = true;
            this.correoErrorLbl.BackColor = System.Drawing.Color.Transparent;
            this.correoErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.correoErrorLbl.Location = new System.Drawing.Point(17, 551);
            this.correoErrorLbl.Name = "correoErrorLbl";
            this.correoErrorLbl.Size = new System.Drawing.Size(261, 17);
            this.correoErrorLbl.TabIndex = 32;
            this.correoErrorLbl.Text = "Dirección de correo electrónico inválida.";
            this.correoErrorLbl.Visible = false;
            // 
            // errorDigit
            // 
            this.errorDigit.AutoSize = true;
            this.errorDigit.BackColor = System.Drawing.Color.Transparent;
            this.errorDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDigit.ForeColor = System.Drawing.Color.Crimson;
            this.errorDigit.Location = new System.Drawing.Point(17, 498);
            this.errorDigit.Name = "errorDigit";
            this.errorDigit.Size = new System.Drawing.Size(288, 17);
            this.errorDigit.TabIndex = 77;
            this.errorDigit.Text = "El teléfono debe contener mínimo 10 dígitos.";
            this.errorDigit.Visible = false;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1361, 780);
            this.Controls.Add(this.errorDigit);
            this.Controls.Add(this.correoErrorLbl);
            this.Controls.Add(this.fechaNacDatePicker);
            this.Controls.Add(this.IdPacienteLbl);
            this.Controls.Add(this.ApellidoPaternoTbx);
            this.Controls.Add(this.ApellidoMaternoTbx);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.LugarTrabajoTbx);
            this.Controls.Add(this.OcupacionTbx);
            this.Controls.Add(this.CorreoETbx);
            this.Controls.Add(this.TelefonoTbx);
            this.Controls.Add(this.DireccionTbx);
            this.Controls.Add(this.LugarNaciTbx);
            this.Controls.Add(this.NombreTxb);
            this.Controls.Add(this.guardarPac_Btn);
            this.Controls.Add(this.ModifPacienteBtn);
            this.Controls.Add(this.InforMedicaBtn);
            this.Controls.Add(this.DiagnosticoBtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BuscarTbx);
            this.Controls.Add(this.EliPacienteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.PacientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 EliPacienteBtn;
        private Bunifu.Framework.UI.BunifuTextbox BuscarTbx;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 DiagnosticoBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 InforMedicaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ModifPacienteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarPac_Btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LugarNaciTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DireccionTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TelefonoTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CorreoETbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OcupacionTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LugarTrabajoTbx;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ApellidoPaternoTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ApellidoMaternoTbx;
        private Bunifu.Framework.UI.BunifuCustomLabel IdPacienteLbl;
        private Bunifu.Framework.UI.BunifuDatepicker fechaNacDatePicker;
        private System.Windows.Forms.Label correoErrorLbl;
        private System.Windows.Forms.Label errorDigit;
    }
}