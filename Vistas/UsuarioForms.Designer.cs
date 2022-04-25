
namespace SistemaConsultorioMedico.Vistas
{
    partial class UsuarioForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForms));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UsuarTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CorreoTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guardarPac_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(395, 82);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(494, 342);
            this.bunifuCustomDataGrid1.TabIndex = 29;
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(315, 50);
            this.linea.Margin = new System.Windows.Forms.Padding(5);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(245, 10);
            this.linea.TabIndex = 31;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(382, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 24);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "USUARIOS";
            // 
            // UsuarTxb
            // 
            this.UsuarTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsuarTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UsuarTxb.ForeColor = System.Drawing.Color.Black;
            this.UsuarTxb.HintForeColor = System.Drawing.Color.Empty;
            this.UsuarTxb.HintText = "";
            this.UsuarTxb.isPassword = false;
            this.UsuarTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.UsuarTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.UsuarTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UsuarTxb.LineThickness = 3;
            this.UsuarTxb.Location = new System.Drawing.Point(8, 106);
            this.UsuarTxb.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarTxb.Name = "UsuarTxb";
            this.UsuarTxb.Size = new System.Drawing.Size(379, 33);
            this.UsuarTxb.TabIndex = 32;
            this.UsuarTxb.Text = "USUARIO";
            this.UsuarTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CorreoTxb
            // 
            this.CorreoTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CorreoTxb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CorreoTxb.ForeColor = System.Drawing.Color.Black;
            this.CorreoTxb.HintForeColor = System.Drawing.Color.Empty;
            this.CorreoTxb.HintText = "";
            this.CorreoTxb.isPassword = false;
            this.CorreoTxb.LineFocusedColor = System.Drawing.Color.Blue;
            this.CorreoTxb.LineIdleColor = System.Drawing.Color.Purple;
            this.CorreoTxb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CorreoTxb.LineThickness = 3;
            this.CorreoTxb.Location = new System.Drawing.Point(8, 164);
            this.CorreoTxb.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoTxb.Name = "CorreoTxb";
            this.CorreoTxb.Size = new System.Drawing.Size(379, 33);
            this.CorreoTxb.TabIndex = 33;
            this.CorreoTxb.Text = "CONTRASEÑA";
            this.CorreoTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.guardarPac_Btn.Location = new System.Drawing.Point(14, 383);
            this.guardarPac_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.guardarPac_Btn.Name = "guardarPac_Btn";
            this.guardarPac_Btn.Padding = new System.Windows.Forms.Padding(33, 10, 0, 10);
            this.guardarPac_Btn.Size = new System.Drawing.Size(141, 41);
            this.guardarPac_Btn.TabIndex = 34;
            this.guardarPac_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.guardarPac_Btn);
            this.Controls.Add(this.CorreoTxb);
            this.Controls.Add(this.UsuarTxb);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UsuarTxb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CorreoTxb;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarPac_Btn;
    }
}