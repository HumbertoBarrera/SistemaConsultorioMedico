﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GuardarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ModificarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EliminarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PacienteCitaTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.folioCitaLb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AgregarCBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorDigit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarCitaBtn
            // 
            this.GuardarCitaBtn.ActiveBorderThickness = 1;
            this.GuardarCitaBtn.ActiveCornerRadius = 20;
            this.GuardarCitaBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.GuardarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.GuardarCitaBtn.ActiveLineColor = System.Drawing.Color.Plum;
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
            this.GuardarCitaBtn.Location = new System.Drawing.Point(20, 495);
            this.GuardarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.GuardarCitaBtn.Name = "GuardarCitaBtn";
            this.GuardarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.GuardarCitaBtn.TabIndex = 4;
            this.GuardarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuardarCitaBtn.Click += new System.EventHandler(this.GuardarCitaBtn_Click);
            // 
            // ModificarCitaBtn
            // 
            this.ModificarCitaBtn.ActiveBorderThickness = 1;
            this.ModificarCitaBtn.ActiveCornerRadius = 20;
            this.ModificarCitaBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.ModificarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ModificarCitaBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.ModificarCitaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarCitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModificarCitaBtn.BackgroundImage")));
            this.ModificarCitaBtn.ButtonText = "MODIFICAR";
            this.ModificarCitaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarCitaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarCitaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.ModificarCitaBtn.IdleBorderThickness = 1;
            this.ModificarCitaBtn.IdleCornerRadius = 20;
            this.ModificarCitaBtn.IdleFillColor = System.Drawing.Color.White;
            this.ModificarCitaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModificarCitaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ModificarCitaBtn.Location = new System.Drawing.Point(202, 495);
            this.ModificarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ModificarCitaBtn.Name = "ModificarCitaBtn";
            this.ModificarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.ModificarCitaBtn.TabIndex = 5;
            this.ModificarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModificarCitaBtn.Click += new System.EventHandler(this.ModificarCitaBtn_Click);
            // 
            // EliminarCitaBtn
            // 
            this.EliminarCitaBtn.ActiveBorderThickness = 1;
            this.EliminarCitaBtn.ActiveCornerRadius = 20;
            this.EliminarCitaBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.EliminarCitaBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EliminarCitaBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.EliminarCitaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarCitaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EliminarCitaBtn.BackgroundImage")));
            this.EliminarCitaBtn.ButtonText = "ELIMINAR";
            this.EliminarCitaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarCitaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCitaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.EliminarCitaBtn.IdleBorderThickness = 1;
            this.EliminarCitaBtn.IdleCornerRadius = 20;
            this.EliminarCitaBtn.IdleFillColor = System.Drawing.Color.White;
            this.EliminarCitaBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EliminarCitaBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EliminarCitaBtn.Location = new System.Drawing.Point(385, 495);
            this.EliminarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EliminarCitaBtn.Name = "EliminarCitaBtn";
            this.EliminarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.EliminarCitaBtn.TabIndex = 6;
            this.EliminarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliminarCitaBtn.Click += new System.EventHandler(this.EliminarCitaBtn_Click);
            // 
            // PacienteCitaTxb
            // 
            this.PacienteCitaTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PacienteCitaTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PacienteCitaTxb.ForeColor = System.Drawing.Color.Black;
            this.PacienteCitaTxb.HintForeColor = System.Drawing.Color.DimGray;
            this.PacienteCitaTxb.HintText = "PACIENTE";
            this.PacienteCitaTxb.isPassword = false;
            this.PacienteCitaTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PacienteCitaTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.PacienteCitaTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PacienteCitaTxb.LineThickness = 3;
            this.PacienteCitaTxb.Location = new System.Drawing.Point(33, 113);
            this.PacienteCitaTxb.Margin = new System.Windows.Forms.Padding(4);
            this.PacienteCitaTxb.Name = "PacienteCitaTxb";
            this.PacienteCitaTxb.Size = new System.Drawing.Size(379, 33);
            this.PacienteCitaTxb.TabIndex = 1;
            this.PacienteCitaTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PacienteCitaTxb.OnValueChanged += new System.EventHandler(this.PacienteCitaTxb_OnValueChanged);
            this.PacienteCitaTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PacienteCitaTxb_KeyPress);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.Purple;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(441, 104);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid2.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(541, 346);
            this.bunifuCustomDataGrid2.TabIndex = 25;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellClick);
            this.bunifuCustomDataGrid2.Validating += new System.ComponentModel.CancelEventHandler(this.bunifuCustomDataGrid2_Validating);
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
            // folioCitaLb
            // 
            this.folioCitaLb.AutoSize = true;
            this.folioCitaLb.Enabled = false;
            this.folioCitaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folioCitaLb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.folioCitaLb.Location = new System.Drawing.Point(30, 68);
            this.folioCitaLb.Name = "folioCitaLb";
            this.folioCitaLb.Size = new System.Drawing.Size(0, 15);
            this.folioCitaLb.TabIndex = 30;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Purple;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(33, 191);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(379, 36);
            this.bunifuDatepicker1.TabIndex = 32;
            this.bunifuDatepicker1.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Purple;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(379, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // AgregarCBtn
            // 
            this.AgregarCBtn.ActiveBorderThickness = 1;
            this.AgregarCBtn.ActiveCornerRadius = 20;
            this.AgregarCBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.AgregarCBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AgregarCBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.AgregarCBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarCBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgregarCBtn.BackgroundImage")));
            this.AgregarCBtn.ButtonText = "NUEVA CITA";
            this.AgregarCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarCBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AgregarCBtn.IdleBorderThickness = 1;
            this.AgregarCBtn.IdleCornerRadius = 20;
            this.AgregarCBtn.IdleFillColor = System.Drawing.Color.White;
            this.AgregarCBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AgregarCBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AgregarCBtn.Location = new System.Drawing.Point(20, 495);
            this.AgregarCBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AgregarCBtn.Name = "AgregarCBtn";
            this.AgregarCBtn.Size = new System.Drawing.Size(157, 41);
            this.AgregarCBtn.TabIndex = 38;
            this.AgregarCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarCBtn.Visible = false;
            this.AgregarCBtn.Click += new System.EventHandler(this.AgregarCBtn_Click);
            // 
            // errorDigit
            // 
            this.errorDigit.AutoSize = true;
            this.errorDigit.BackColor = System.Drawing.Color.Transparent;
            this.errorDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDigit.ForeColor = System.Drawing.Color.Crimson;
            this.errorDigit.Location = new System.Drawing.Point(30, 150);
            this.errorDigit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorDigit.Name = "errorDigit";
            this.errorDigit.Size = new System.Drawing.Size(225, 15);
            this.errorDigit.TabIndex = 76;
            this.errorDigit.Text = "El ID debe contener minimo 8 numeros.";
            this.errorDigit.Visible = false;
            // 
            // CitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.errorDigit);
            this.Controls.Add(this.AgregarCBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.folioCitaLb);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.PacienteCitaTxb);
            this.Controls.Add(this.GuardarCitaBtn);
            this.Controls.Add(this.ModificarCitaBtn);
            this.Controls.Add(this.EliminarCitaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CitasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.CitasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 GuardarCitaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ModificarCitaBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EliminarCitaBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PacienteCitaTxb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel folioCitaLb;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 AgregarCBtn;
        private System.Windows.Forms.Label errorDigit;
    }
}