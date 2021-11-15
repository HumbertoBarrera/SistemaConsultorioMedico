
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
            this.guardarbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EliminarCitaBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PacienteTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(315, 47);
            this.linea.Margin = new System.Windows.Forms.Padding(4);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(245, 10);
            this.linea.TabIndex = 29;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(369, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 23);
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
            this.FechaTxb.Location = new System.Drawing.Point(47, 121);
            this.FechaTxb.Margin = new System.Windows.Forms.Padding(4);
            this.FechaTxb.Name = "FechaTxb";
            this.FechaTxb.Size = new System.Drawing.Size(379, 33);
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
            this.Descripciontxb.Location = new System.Drawing.Point(47, 161);
            this.Descripciontxb.Multiline = true;
            this.Descripciontxb.Name = "Descripciontxb";
            this.Descripciontxb.Size = new System.Drawing.Size(633, 245);
            this.Descripciontxb.TabIndex = 32;
            this.Descripciontxb.Text = "DESCRIPCION";
            this.Descripciontxb.MouseEnter += new System.EventHandler(this.Descripciontxb_MouseEnter);
            this.Descripciontxb.MouseLeave += new System.EventHandler(this.Descripciontxb_MouseLeave);
            // 
            // guardarbtn
            // 
            this.guardarbtn.ActiveBorderThickness = 1;
            this.guardarbtn.ActiveCornerRadius = 20;
            this.guardarbtn.ActiveFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarbtn.ActiveForecolor = System.Drawing.Color.White;
            this.guardarbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guardarbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarbtn.BackgroundImage")));
            this.guardarbtn.ButtonText = "GUARDAR";
            this.guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.guardarbtn.IdleBorderThickness = 1;
            this.guardarbtn.IdleCornerRadius = 20;
            this.guardarbtn.IdleFillColor = System.Drawing.Color.White;
            this.guardarbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarbtn.Location = new System.Drawing.Point(511, 532);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(157, 41);
            this.guardarbtn.TabIndex = 34;
            this.guardarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(677, 532);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(157, 41);
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
            this.EliminarCitaBtn.Location = new System.Drawing.Point(844, 532);
            this.EliminarCitaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EliminarCitaBtn.Name = "EliminarCitaBtn";
            this.EliminarCitaBtn.Size = new System.Drawing.Size(157, 41);
            this.EliminarCitaBtn.TabIndex = 36;
            this.EliminarCitaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PacienteTxb.Location = new System.Drawing.Point(526, 91);
            this.PacienteTxb.Margin = new System.Windows.Forms.Padding(4);
            this.PacienteTxb.Name = "PacienteTxb";
            this.PacienteTxb.Size = new System.Drawing.Size(379, 33);
            this.PacienteTxb.TabIndex = 38;
            this.PacienteTxb.Text = "PACIENTE";
            this.PacienteTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PacienteTxb.MouseEnter += new System.EventHandler(this.PacienteTxb_MouseEnter);
            this.PacienteTxb.MouseLeave += new System.EventHandler(this.PacienteTxb_MouseLeave);
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 604);
            this.Controls.Add(this.PacienteTxb);
            this.Controls.Add(this.EliminarCitaBtn);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.guardarbtn);
            this.Controls.Add(this.Descripciontxb);
            this.Controls.Add(this.FechaTxb);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Bunifu.Framework.UI.BunifuThinButton2 guardarbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 EliminarCitaBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PacienteTxb;
    }
}