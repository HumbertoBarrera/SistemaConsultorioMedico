
namespace SistemaConsultorioMedico
{
    partial class CitasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GuardarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ModificarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EliminarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FechaCitaTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PacienteCitaTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HoraCitaTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BuscarTbx = new Bunifu.Framework.UI.BunifuTextbox();
            this.PacientesBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarCitaBtn
            // 
            this.GuardarCitaBtn.ActiveBorderThickness = 1;
            this.GuardarCitaBtn.ActiveCornerRadius = 20;
            this.GuardarCitaBtn.ActiveFillColor = System.Drawing.Color.White;
            this.GuardarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.GuardarCitaBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarCitaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarCitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarCitaBtn.BackgroundImage")));
            this.GuardarCitaBtn.ButtonText = "GUARDAR";
            this.GuardarCitaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarCitaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarCitaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.GuardarCitaBtn.IdleBorderThickness = 1;
            this.GuardarCitaBtn.IdleCornerRadius = 20;
            this.GuardarCitaBtn.IdleFillColor = System.Drawing.Color.White;
            this.GuardarCitaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GuardarCitaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GuardarCitaBtn.Location = new System.Drawing.Point(22, 474);
            this.GuardarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.GuardarCitaBtn.Name = "GuardarCitaBtn";
            this.GuardarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.GuardarCitaBtn.TabIndex = 16;
            this.GuardarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuardarCitaBtn.Click += new System.EventHandler(this.GuardarCitaBtn_Click);
            // 
            // ModificarCitaBtn
            // 
            this.ModificarCitaBtn.ActiveBorderThickness = 1;
            this.ModificarCitaBtn.ActiveCornerRadius = 20;
            this.ModificarCitaBtn.ActiveFillColor = System.Drawing.Color.White;
            this.ModificarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ModificarCitaBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ModificarCitaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarCitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModificarCitaBtn.BackgroundImage")));
            this.ModificarCitaBtn.ButtonText = "MODIFICAR";
            this.ModificarCitaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarCitaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarCitaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.ModificarCitaBtn.IdleBorderThickness = 1;
            this.ModificarCitaBtn.IdleCornerRadius = 20;
            this.ModificarCitaBtn.IdleFillColor = System.Drawing.Color.White;
            this.ModificarCitaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModificarCitaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModificarCitaBtn.Location = new System.Drawing.Point(204, 474);
            this.ModificarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ModificarCitaBtn.Name = "ModificarCitaBtn";
            this.ModificarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.ModificarCitaBtn.TabIndex = 15;
            this.ModificarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModificarCitaBtn.Click += new System.EventHandler(this.ModificarCitaBtn_Click);
            // 
            // EliminarCitaBtn
            // 
            this.EliminarCitaBtn.ActiveBorderThickness = 1;
            this.EliminarCitaBtn.ActiveCornerRadius = 20;
            this.EliminarCitaBtn.ActiveFillColor = System.Drawing.Color.White;
            this.EliminarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EliminarCitaBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EliminarCitaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarCitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EliminarCitaBtn.BackgroundImage")));
            this.EliminarCitaBtn.ButtonText = "ELIMINAR";
            this.EliminarCitaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarCitaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCitaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.EliminarCitaBtn.IdleBorderThickness = 1;
            this.EliminarCitaBtn.IdleCornerRadius = 20;
            this.EliminarCitaBtn.IdleFillColor = System.Drawing.Color.White;
            this.EliminarCitaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EliminarCitaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EliminarCitaBtn.Location = new System.Drawing.Point(22, 525);
            this.EliminarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EliminarCitaBtn.Name = "EliminarCitaBtn";
            this.EliminarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.EliminarCitaBtn.TabIndex = 14;
            this.EliminarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliminarCitaBtn.Click += new System.EventHandler(this.EliminarCitaBtn_Click);
            // 
            // FechaCitaTxb
            // 
            this.FechaCitaTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FechaCitaTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FechaCitaTxb.ForeColor = System.Drawing.Color.Black;
            this.FechaCitaTxb.HintForeColor = System.Drawing.Color.Empty;
            this.FechaCitaTxb.HintText = "";
            this.FechaCitaTxb.isPassword = false;
            this.FechaCitaTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.FechaCitaTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.FechaCitaTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FechaCitaTxb.LineThickness = 3;
            this.FechaCitaTxb.Location = new System.Drawing.Point(33, 154);
            this.FechaCitaTxb.Margin = new System.Windows.Forms.Padding(4);
            this.FechaCitaTxb.Name = "FechaCitaTxb";
            this.FechaCitaTxb.Size = new System.Drawing.Size(379, 33);
            this.FechaCitaTxb.TabIndex = 19;
            this.FechaCitaTxb.Text = "FECHA";
            this.FechaCitaTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FechaCitaTxb.MouseEnter += new System.EventHandler(this.FechaCitaTxb_MouseEnter);
            this.FechaCitaTxb.MouseLeave += new System.EventHandler(this.FechaCitaTxb_MouseLeave);
            // 
            // PacienteCitaTxb
            // 
            this.PacienteCitaTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PacienteCitaTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PacienteCitaTxb.ForeColor = System.Drawing.Color.Black;
            this.PacienteCitaTxb.HintForeColor = System.Drawing.Color.Empty;
            this.PacienteCitaTxb.HintText = "";
            this.PacienteCitaTxb.isPassword = false;
            this.PacienteCitaTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PacienteCitaTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.PacienteCitaTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PacienteCitaTxb.LineThickness = 3;
            this.PacienteCitaTxb.Location = new System.Drawing.Point(33, 113);
            this.PacienteCitaTxb.Margin = new System.Windows.Forms.Padding(4);
            this.PacienteCitaTxb.Name = "PacienteCitaTxb";
            this.PacienteCitaTxb.Size = new System.Drawing.Size(379, 33);
            this.PacienteCitaTxb.TabIndex = 21;
            this.PacienteCitaTxb.Text = "PACIENTE";
            this.PacienteCitaTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PacienteCitaTxb.MouseEnter += new System.EventHandler(this.PacienteCitaTxb_MouseEnter);
            this.PacienteCitaTxb.MouseLeave += new System.EventHandler(this.PacienteCitaTxb_MouseLeave);
            // 
            // HoraCitaTxb
            // 
            this.HoraCitaTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HoraCitaTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.HoraCitaTxb.ForeColor = System.Drawing.Color.Black;
            this.HoraCitaTxb.HintForeColor = System.Drawing.Color.Empty;
            this.HoraCitaTxb.HintText = "";
            this.HoraCitaTxb.isPassword = false;
            this.HoraCitaTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.HoraCitaTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.HoraCitaTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.HoraCitaTxb.LineThickness = 3;
            this.HoraCitaTxb.Location = new System.Drawing.Point(33, 195);
            this.HoraCitaTxb.Margin = new System.Windows.Forms.Padding(4);
            this.HoraCitaTxb.Name = "HoraCitaTxb";
            this.HoraCitaTxb.Size = new System.Drawing.Size(379, 33);
            this.HoraCitaTxb.TabIndex = 22;
            this.HoraCitaTxb.Text = "HORA";
            this.HoraCitaTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HoraCitaTxb.MouseEnter += new System.EventHandler(this.HoraCitaTxb_MouseEnter);
            this.HoraCitaTxb.MouseLeave += new System.EventHandler(this.HoraCitaTxb_MouseLeave);
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(441, 102);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(541, 346);
            this.bunifuCustomDataGrid2.TabIndex = 25;
            this.bunifuCustomDataGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellClick);
            // 
            // BuscarTbx
            // 
            this.BuscarTbx.BackColor = System.Drawing.Color.White;
            this.BuscarTbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarTbx.BackgroundImage")));
            this.BuscarTbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarTbx.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTbx.ForeColor = System.Drawing.Color.Purple;
            this.BuscarTbx.Icon = ((System.Drawing.Image)(resources.GetObject("BuscarTbx.Icon")));
            this.BuscarTbx.Location = new System.Drawing.Point(615, 68);
            this.BuscarTbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarTbx.Name = "BuscarTbx";
            this.BuscarTbx.Size = new System.Drawing.Size(367, 27);
            this.BuscarTbx.TabIndex = 26;
            this.BuscarTbx.text = "";
            this.BuscarTbx.MouseEnter += new System.EventHandler(this.BuscarTbx_MouseEnter);
            this.BuscarTbx.MouseLeave += new System.EventHandler(this.BuscarTbx_MouseLeave);
            // 
            // PacientesBtn
            // 
            this.PacientesBtn.ActiveBorderThickness = 1;
            this.PacientesBtn.ActiveCornerRadius = 20;
            this.PacientesBtn.ActiveFillColor = System.Drawing.Color.White;
            this.PacientesBtn.ActiveForecolor = System.Drawing.Color.White;
            this.PacientesBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PacientesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PacientesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PacientesBtn.BackgroundImage")));
            this.PacientesBtn.ButtonText = "PACIENTES";
            this.PacientesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PacientesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacientesBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.PacientesBtn.IdleBorderThickness = 1;
            this.PacientesBtn.IdleCornerRadius = 20;
            this.PacientesBtn.IdleFillColor = System.Drawing.Color.White;
            this.PacientesBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PacientesBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PacientesBtn.Location = new System.Drawing.Point(825, 474);
            this.PacientesBtn.Margin = new System.Windows.Forms.Padding(5);
            this.PacientesBtn.Name = "PacientesBtn";
            this.PacientesBtn.Size = new System.Drawing.Size(157, 41);
            this.PacientesBtn.TabIndex = 27;
            this.PacientesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(335, 58);
            this.linea.Margin = new System.Windows.Forms.Padding(4);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(170, 10);
            this.linea.TabIndex = 29;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(383, 32);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 23);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "CITAS";
            // 
            // CitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.PacientesBtn);
            this.Controls.Add(this.BuscarTbx);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.HoraCitaTxb);
            this.Controls.Add(this.PacienteCitaTxb);
            this.Controls.Add(this.FechaCitaTxb);
            this.Controls.Add(this.GuardarCitaBtn);
            this.Controls.Add(this.ModificarCitaBtn);
            this.Controls.Add(this.EliminarCitaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CitasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitasForm";
            this.Load += new System.EventHandler(this.CitasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 GuardarCitaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ModificarCitaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EliminarCitaBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FechaCitaTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PacienteCitaTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HoraCitaTxb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuTextbox BuscarTbx;
        private Bunifu.Framework.UI.BunifuThinButton2 PacientesBtn;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}