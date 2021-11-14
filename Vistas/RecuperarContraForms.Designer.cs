
namespace SistemaConsultorioMedico
{
    partial class RecuperarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContra));
            this.UsuarTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CorreoTxb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.UsuarTxb.Location = new System.Drawing.Point(35, 52);
            this.UsuarTxb.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarTxb.Name = "UsuarTxb";
            this.UsuarTxb.Size = new System.Drawing.Size(379, 33);
            this.UsuarTxb.TabIndex = 19;
            this.UsuarTxb.Text = "USUARIO";
            this.UsuarTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsuarTxb.MouseEnter += new System.EventHandler(this.NombreTxb_MouseEnter);
            this.UsuarTxb.MouseLeave += new System.EventHandler(this.UsuarTxb_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(317, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.CorreoTxb.Location = new System.Drawing.Point(35, 93);
            this.CorreoTxb.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoTxb.Name = "CorreoTxb";
            this.CorreoTxb.Size = new System.Drawing.Size(379, 33);
            this.CorreoTxb.TabIndex = 22;
            this.CorreoTxb.Text = "CORREO ELECTRONICO";
            this.CorreoTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CorreoTxb.MouseEnter += new System.EventHandler(this.CorreoTxb_MouseEnter);
            this.CorreoTxb.MouseLeave += new System.EventHandler(this.CorreoTxb_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(157, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "SOLICITAR NUEVA CONTRASEÑA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(368, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CorreoTxb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsuarTxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContra";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecuperarContra_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox UsuarTxb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CorreoTxb;
        private System.Windows.Forms.Button button1;
    }
}