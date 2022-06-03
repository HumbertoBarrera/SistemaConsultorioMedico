
namespace SistemaConsultorioMedico
{
    partial class Diagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnostico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FechaTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Descripciontxb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Agregarbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BuscarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PacienteTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pacientesCbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(420, 58);
            this.linea.Margin = new System.Windows.Forms.Padding(5);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(327, 12);
            this.linea.TabIndex = 29;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(492, 26);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(181, 30);
            this.bunifuCustomLabel1.TabIndex = 28;
            this.bunifuCustomLabel1.Text = "DIAGNOSTICO";
            // 
            // FechaTxb
            // 
            this.FechaTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaTxb.Enabled = false;
            this.FechaTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FechaTxb.ForeColor = System.Drawing.Color.Black;
            this.FechaTxb.HintForeColor = System.Drawing.Color.Empty;
            this.FechaTxb.HintText = "";
            this.FechaTxb.isPassword = false;
            this.FechaTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.FechaTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.FechaTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FechaTxb.LineThickness = 3;
            this.FechaTxb.Location = new System.Drawing.Point(29, 149);
            this.FechaTxb.Margin = new System.Windows.Forms.Padding(5);
            this.FechaTxb.Name = "FechaTxb";
            this.FechaTxb.Size = new System.Drawing.Size(336, 41);
            this.FechaTxb.TabIndex = 30;
            this.FechaTxb.Text = "FECHA";
            this.FechaTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FechaTxb.MouseEnter += new System.EventHandler(this.FechaTxb_MouseEnter);
            this.FechaTxb.MouseLeave += new System.EventHandler(this.FechaTxb_MouseLeave);
            // 
            // Descripciontxb
            // 
            this.Descripciontxb.BackColor = System.Drawing.Color.Gainsboro;
            this.Descripciontxb.BorderColor = System.Drawing.Color.SeaGreen;
            this.Descripciontxb.Location = new System.Drawing.Point(29, 198);
            this.Descripciontxb.Margin = new System.Windows.Forms.Padding(4);
            this.Descripciontxb.Multiline = true;
            this.Descripciontxb.Name = "Descripciontxb";
            this.Descripciontxb.Size = new System.Drawing.Size(843, 301);
            this.Descripciontxb.TabIndex = 32;
            this.Descripciontxb.Text = "DESCRIPCION";
            this.Descripciontxb.MouseEnter += new System.EventHandler(this.Descripciontxb_MouseEnter);
            this.Descripciontxb.MouseLeave += new System.EventHandler(this.Descripciontxb_MouseLeave);
            // 
            // guardarbtn
            // 
            this.guardarbtn.ActiveBorderThickness = 1;
            this.guardarbtn.ActiveCornerRadius = 20;
            this.guardarbtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.guardarbtn.ActiveForecolor = System.Drawing.Color.White;
            this.guardarbtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.guardarbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarbtn.BackgroundImage")));
            this.guardarbtn.ButtonText = "GUARDAR";
            this.guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.guardarbtn.IdleBorderThickness = 1;
            this.guardarbtn.IdleCornerRadius = 20;
            this.guardarbtn.IdleFillColor = System.Drawing.Color.White;
            this.guardarbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarbtn.Location = new System.Drawing.Point(420, 619);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(5);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(209, 50);
            this.guardarbtn.TabIndex = 34;
            this.guardarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.ActiveBorderThickness = 1;
            this.Agregarbtn.ActiveCornerRadius = 20;
            this.Agregarbtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.Agregarbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Agregarbtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.Agregarbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Agregarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agregarbtn.BackgroundImage")));
            this.Agregarbtn.ButtonText = "AGREGAR NUEVO";
            this.Agregarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Agregarbtn.IdleBorderThickness = 1;
            this.Agregarbtn.IdleCornerRadius = 20;
            this.Agregarbtn.IdleFillColor = System.Drawing.Color.White;
            this.Agregarbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Agregarbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Agregarbtn.Location = new System.Drawing.Point(63, 619);
            this.Agregarbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(209, 50);
            this.Agregarbtn.TabIndex = 35;
            this.Agregarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // BuscarCitaBtn
            // 
            this.BuscarCitaBtn.ActiveBorderThickness = 1;
            this.BuscarCitaBtn.ActiveCornerRadius = 20;
            this.BuscarCitaBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.BuscarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.BuscarCitaBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.BuscarCitaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuscarCitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarCitaBtn.BackgroundImage")));
            this.BuscarCitaBtn.ButtonText = "BUSCAR";
            this.BuscarCitaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarCitaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCitaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.BuscarCitaBtn.IdleBorderThickness = 1;
            this.BuscarCitaBtn.IdleCornerRadius = 20;
            this.BuscarCitaBtn.IdleFillColor = System.Drawing.Color.White;
            this.BuscarCitaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BuscarCitaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BuscarCitaBtn.Location = new System.Drawing.Point(1204, 149);
            this.BuscarCitaBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BuscarCitaBtn.Name = "BuscarCitaBtn";
            this.BuscarCitaBtn.Size = new System.Drawing.Size(103, 50);
            this.BuscarCitaBtn.TabIndex = 36;
            this.BuscarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BuscarCitaBtn.Click += new System.EventHandler(this.BuscarCitaBtn_Click);
            // 
            // PacienteTxb
            // 
            this.PacienteTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PacienteTxb.Enabled = false;
            this.PacienteTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PacienteTxb.ForeColor = System.Drawing.Color.Black;
            this.PacienteTxb.HintForeColor = System.Drawing.Color.Empty;
            this.PacienteTxb.HintText = "";
            this.PacienteTxb.isPassword = false;
            this.PacienteTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PacienteTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.PacienteTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PacienteTxb.LineThickness = 3;
            this.PacienteTxb.Location = new System.Drawing.Point(425, 149);
            this.PacienteTxb.Margin = new System.Windows.Forms.Padding(5);
            this.PacienteTxb.Name = "PacienteTxb";
            this.PacienteTxb.Size = new System.Drawing.Size(369, 41);
            this.PacienteTxb.TabIndex = 38;
            this.PacienteTxb.Text = "PACIENTE";
            this.PacienteTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PacienteTxb.MouseEnter += new System.EventHandler(this.PacienteTxb_MouseEnter);
            this.PacienteTxb.MouseLeave += new System.EventHandler(this.PacienteTxb_MouseLeave);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(900, 198);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(407, 301);
            this.bunifuCustomDataGrid1.TabIndex = 39;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1312, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pacientesCbo
            // 
            this.pacientesCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pacientesCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pacientesCbo.BackColor = System.Drawing.Color.Purple;
            this.pacientesCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientesCbo.ForeColor = System.Drawing.Color.White;
            this.pacientesCbo.FormattingEnabled = true;
            this.pacientesCbo.Location = new System.Drawing.Point(900, 163);
            this.pacientesCbo.Name = "pacientesCbo";
            this.pacientesCbo.Size = new System.Drawing.Size(294, 28);
            this.pacientesCbo.TabIndex = 80;
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1379, 743);
            this.Controls.Add(this.pacientesCbo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.PacienteTxb);
            this.Controls.Add(this.BuscarCitaBtn);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.Descripciontxb);
            this.Controls.Add(this.FechaTxb);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.Diagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FechaTxb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Descripciontxb;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Agregarbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 BuscarCitaBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PacienteTxb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox pacientesCbo;
    }
}