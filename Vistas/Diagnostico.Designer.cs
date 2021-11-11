
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
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FechaTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Descripciontxb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EliminarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PacienteCbx = new Bunifu.Framework.UI.BunifuDropdown();
            this.PacienteTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(420, 58);
            this.linea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.FechaTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FechaTxb.ForeColor = System.Drawing.Color.Black;
            this.FechaTxb.HintForeColor = System.Drawing.Color.Empty;
            this.FechaTxb.HintText = "";
            this.FechaTxb.isPassword = false;
            this.FechaTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.FechaTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.FechaTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FechaTxb.LineThickness = 3;
            this.FechaTxb.Location = new System.Drawing.Point(63, 149);
            this.FechaTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FechaTxb.Name = "FechaTxb";
            this.FechaTxb.Size = new System.Drawing.Size(505, 41);
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
            this.Descripciontxb.Location = new System.Drawing.Point(63, 198);
            this.Descripciontxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Descripciontxb.Multiline = true;
            this.Descripciontxb.Name = "Descripciontxb";
            this.Descripciontxb.Size = new System.Drawing.Size(843, 301);
            this.Descripciontxb.TabIndex = 32;
            this.Descripciontxb.Text = "DESCRIPCION";
            this.Descripciontxb.MouseEnter += new System.EventHandler(this.Descripciontxb_MouseEnter);
            this.Descripciontxb.MouseLeave += new System.EventHandler(this.Descripciontxb_MouseLeave);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "GUARDAR";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuThinButton25.Location = new System.Drawing.Point(680, 655);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(209, 50);
            this.bunifuThinButton25.TabIndex = 34;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(903, 655);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(209, 50);
            this.bunifuThinButton24.TabIndex = 35;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.EliminarCitaBtn.Location = new System.Drawing.Point(1125, 655);
            this.EliminarCitaBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EliminarCitaBtn.Name = "EliminarCitaBtn";
            this.EliminarCitaBtn.Size = new System.Drawing.Size(209, 50);
            this.EliminarCitaBtn.TabIndex = 36;
            this.EliminarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PacienteCbx
            // 
            this.PacienteCbx.BackColor = System.Drawing.Color.Transparent;
            this.PacienteCbx.BorderRadius = 3;
            this.PacienteCbx.DisabledColor = System.Drawing.Color.Gray;
            this.PacienteCbx.ForeColor = System.Drawing.Color.White;
            this.PacienteCbx.Items = new string[0];
            this.PacienteCbx.Location = new System.Drawing.Point(63, 112);
            this.PacienteCbx.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PacienteCbx.Name = "PacienteCbx";
            this.PacienteCbx.NomalColor = System.Drawing.Color.Purple;
            this.PacienteCbx.onHoverColor = System.Drawing.Color.Blue;
            this.PacienteCbx.selectedIndex = -1;
            this.PacienteCbx.Size = new System.Drawing.Size(289, 28);
            this.PacienteCbx.TabIndex = 37;
            // 
            // PacienteTxb
            // 
            this.PacienteTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PacienteTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PacienteTxb.ForeColor = System.Drawing.Color.Black;
            this.PacienteTxb.HintForeColor = System.Drawing.Color.Empty;
            this.PacienteTxb.HintText = "";
            this.PacienteTxb.isPassword = false;
            this.PacienteTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PacienteTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.PacienteTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PacienteTxb.LineThickness = 3;
            this.PacienteTxb.Location = new System.Drawing.Point(701, 112);
            this.PacienteTxb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PacienteTxb.Name = "PacienteTxb";
            this.PacienteTxb.Size = new System.Drawing.Size(505, 41);
            this.PacienteTxb.TabIndex = 38;
            this.PacienteTxb.Text = "PACIENTE";
            this.PacienteTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PacienteTxb.MouseEnter += new System.EventHandler(this.PacienteTxb_MouseEnter);
            this.PacienteTxb.MouseLeave += new System.EventHandler(this.PacienteTxb_MouseLeave);
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 743);
            this.Controls.Add(this.PacienteTxb);
            this.Controls.Add(this.PacienteCbx);
            this.Controls.Add(this.EliminarCitaBtn);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.Descripciontxb);
            this.Controls.Add(this.FechaTxb);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FechaTxb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Descripciontxb;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 EliminarCitaBtn;
        private Bunifu.Framework.UI.BunifuDropdown PacienteCbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PacienteTxb;
    }
}