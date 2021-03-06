
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
            this.usuarios_DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usuarioTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guardarUsuario_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rol_comboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.modificarBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.eliminarBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.IdUsuarioTituloLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IdUsuarioLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarios_DataGrid
            // 
            this.usuarios_DataGrid.AllowUserToAddRows = false;
            this.usuarios_DataGrid.AllowUserToDeleteRows = false;
            this.usuarios_DataGrid.AllowUserToResizeColumns = false;
            this.usuarios_DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usuarios_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usuarios_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarios_DataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.usuarios_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarios_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarios_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usuarios_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_DataGrid.DoubleBuffered = true;
            this.usuarios_DataGrid.EnableHeadersVisualStyles = false;
            this.usuarios_DataGrid.HeaderBgColor = System.Drawing.Color.Purple;
            this.usuarios_DataGrid.HeaderForeColor = System.Drawing.Color.Purple;
            this.usuarios_DataGrid.Location = new System.Drawing.Point(527, 101);
            this.usuarios_DataGrid.Margin = new System.Windows.Forms.Padding(5);
            this.usuarios_DataGrid.Name = "usuarios_DataGrid";
            this.usuarios_DataGrid.ReadOnly = true;
            this.usuarios_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usuarios_DataGrid.RowHeadersWidth = 51;
            this.usuarios_DataGrid.Size = new System.Drawing.Size(659, 421);
            this.usuarios_DataGrid.TabIndex = 29;
            this.usuarios_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LlenarInfoUsuarios_DataGrid);
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(420, 62);
            this.linea.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(327, 12);
            this.linea.TabIndex = 31;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(509, 26);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 29);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "USUARIOS";
            // 
            // usuarioTbx
            // 
            this.usuarioTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usuarioTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usuarioTbx.ForeColor = System.Drawing.Color.Black;
            this.usuarioTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.usuarioTbx.HintText = "USUARIO";
            this.usuarioTbx.isPassword = false;
            this.usuarioTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.usuarioTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.usuarioTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usuarioTbx.LineThickness = 3;
            this.usuarioTbx.Location = new System.Drawing.Point(11, 130);
            this.usuarioTbx.Margin = new System.Windows.Forms.Padding(5);
            this.usuarioTbx.Name = "usuarioTbx";
            this.usuarioTbx.Size = new System.Drawing.Size(505, 41);
            this.usuarioTbx.TabIndex = 32;
            this.usuarioTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usuarioTbx.OnValueChanged += new System.EventHandler(this.BloqueoBtnGuardar);
            // 
            // passwordTbx
            // 
            this.passwordTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTbx.ForeColor = System.Drawing.Color.Black;
            this.passwordTbx.HintForeColor = System.Drawing.Color.DimGray;
            this.passwordTbx.HintText = "CONTRASEÑA";
            this.passwordTbx.isPassword = false;
            this.passwordTbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.passwordTbx.LineIdleColor = System.Drawing.Color.Purple;
            this.passwordTbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passwordTbx.LineThickness = 3;
            this.passwordTbx.Location = new System.Drawing.Point(11, 202);
            this.passwordTbx.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(505, 41);
            this.passwordTbx.TabIndex = 33;
            this.passwordTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTbx.OnValueChanged += new System.EventHandler(this.BloqueoBtnGuardar);
            // 
            // guardarUsuario_Btn
            // 
            this.guardarUsuario_Btn.ActiveBorderThickness = 1;
            this.guardarUsuario_Btn.ActiveCornerRadius = 20;
            this.guardarUsuario_Btn.ActiveFillColor = System.Drawing.Color.Plum;
            this.guardarUsuario_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.guardarUsuario_Btn.ActiveLineColor = System.Drawing.Color.Plum;
            this.guardarUsuario_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarUsuario_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardarUsuario_Btn.BackgroundImage")));
            this.guardarUsuario_Btn.ButtonText = "GUARDAR";
            this.guardarUsuario_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarUsuario_Btn.Enabled = false;
            this.guardarUsuario_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarUsuario_Btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.guardarUsuario_Btn.IdleBorderThickness = 1;
            this.guardarUsuario_Btn.IdleCornerRadius = 20;
            this.guardarUsuario_Btn.IdleFillColor = System.Drawing.Color.Gray;
            this.guardarUsuario_Btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarUsuario_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guardarUsuario_Btn.Location = new System.Drawing.Point(16, 406);
            this.guardarUsuario_Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guardarUsuario_Btn.Name = "guardarUsuario_Btn";
            this.guardarUsuario_Btn.Padding = new System.Windows.Forms.Padding(44, 12, 0, 12);
            this.guardarUsuario_Btn.Size = new System.Drawing.Size(188, 50);
            this.guardarUsuario_Btn.TabIndex = 34;
            this.guardarUsuario_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guardarUsuario_Btn.Click += new System.EventHandler(this.guardarUsuario_Btn_Click);
            this.guardarUsuario_Btn.EnabledChanged += new System.EventHandler(this.BloqueoBotonGuardar);
            // 
            // rol_comboBox
            // 
            this.rol_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.rol_comboBox.BorderRadius = 3;
            this.rol_comboBox.DisabledColor = System.Drawing.Color.Gray;
            this.rol_comboBox.ForeColor = System.Drawing.Color.White;
            this.rol_comboBox.Items = new string[] {
        "ROL",
        "SECRETARIO/A",
        "DOCTOR/A"};
            this.rol_comboBox.Location = new System.Drawing.Point(11, 280);
            this.rol_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rol_comboBox.Name = "rol_comboBox";
            this.rol_comboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rol_comboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rol_comboBox.selectedIndex = -1;
            this.rol_comboBox.Size = new System.Drawing.Size(289, 43);
            this.rol_comboBox.TabIndex = 35;
            this.rol_comboBox.onItemSelected += new System.EventHandler(this.BloqueoBtnGuardar);
            // 
            // modificarBtn
            // 
            this.modificarBtn.ActiveBorderThickness = 1;
            this.modificarBtn.ActiveCornerRadius = 20;
            this.modificarBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.modificarBtn.ActiveForecolor = System.Drawing.Color.White;
            this.modificarBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.modificarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarBtn.BackgroundImage")));
            this.modificarBtn.ButtonText = "MODIFICAR";
            this.modificarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarBtn.Enabled = false;
            this.modificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.modificarBtn.IdleBorderThickness = 1;
            this.modificarBtn.IdleCornerRadius = 20;
            this.modificarBtn.IdleFillColor = System.Drawing.Color.Gray;
            this.modificarBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.modificarBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.modificarBtn.Location = new System.Drawing.Point(260, 406);
            this.modificarBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Padding = new System.Windows.Forms.Padding(44, 12, 0, 12);
            this.modificarBtn.Size = new System.Drawing.Size(188, 50);
            this.modificarBtn.TabIndex = 36;
            this.modificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            this.modificarBtn.EnabledChanged += new System.EventHandler(this.ModificarBotonBloquear);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.ActiveBorderThickness = 1;
            this.eliminarBtn.ActiveCornerRadius = 20;
            this.eliminarBtn.ActiveFillColor = System.Drawing.Color.Plum;
            this.eliminarBtn.ActiveForecolor = System.Drawing.Color.White;
            this.eliminarBtn.ActiveLineColor = System.Drawing.Color.Plum;
            this.eliminarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarBtn.BackgroundImage")));
            this.eliminarBtn.ButtonText = "ELIMINAR";
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarBtn.Enabled = false;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.eliminarBtn.IdleBorderThickness = 1;
            this.eliminarBtn.IdleCornerRadius = 20;
            this.eliminarBtn.IdleFillColor = System.Drawing.Color.Gray;
            this.eliminarBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.eliminarBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.eliminarBtn.Location = new System.Drawing.Point(260, 472);
            this.eliminarBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Padding = new System.Windows.Forms.Padding(44, 12, 0, 12);
            this.eliminarBtn.Size = new System.Drawing.Size(188, 50);
            this.eliminarBtn.TabIndex = 37;
            this.eliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            this.eliminarBtn.EnabledChanged += new System.EventHandler(this.EliminarBotonBloquear);
            // 
            // IdUsuarioTituloLbl
            // 
            this.IdUsuarioTituloLbl.AutoSize = true;
            this.IdUsuarioTituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuarioTituloLbl.Location = new System.Drawing.Point(7, 89);
            this.IdUsuarioTituloLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdUsuarioTituloLbl.Name = "IdUsuarioTituloLbl";
            this.IdUsuarioTituloLbl.Size = new System.Drawing.Size(131, 24);
            this.IdUsuarioTituloLbl.TabIndex = 38;
            this.IdUsuarioTituloLbl.Text = "ID USUARIO:";
            this.IdUsuarioTituloLbl.Visible = false;
            // 
            // IdUsuarioLbl
            // 
            this.IdUsuarioLbl.AutoSize = true;
            this.IdUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuarioLbl.Location = new System.Drawing.Point(152, 89);
            this.IdUsuarioLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdUsuarioLbl.Name = "IdUsuarioLbl";
            this.IdUsuarioLbl.Size = new System.Drawing.Size(0, 24);
            this.IdUsuarioLbl.TabIndex = 39;
            this.IdUsuarioLbl.Visible = false;
            // 
            // UsuarioForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1213, 554);
            this.Controls.Add(this.IdUsuarioLbl);
            this.Controls.Add(this.IdUsuarioTituloLbl);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.rol_comboBox);
            this.Controls.Add(this.guardarUsuario_Btn);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.usuarioTbx);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.usuarios_DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsuarioForms";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuarioForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid usuarios_DataGrid;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usuarioTbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTbx;
        private Bunifu.Framework.UI.BunifuThinButton2 guardarUsuario_Btn;
        private Bunifu.Framework.UI.BunifuDropdown rol_comboBox;
        private Bunifu.Framework.UI.BunifuThinButton2 modificarBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 eliminarBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel IdUsuarioTituloLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel IdUsuarioLbl;
    }
}