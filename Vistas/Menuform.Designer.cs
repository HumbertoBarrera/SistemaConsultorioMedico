
namespace SistemaConsultorioMedico
{
    partial class Menuform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuform));
            BunifuAnimatorNS.Animation animation14 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation13 = new BunifuAnimatorNS.Animation();
            this.contenidoPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedorMenuPnl = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.InformacionMedicaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.diagnosticoBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.citaBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Pacientebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuTopPnl = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuDesplegableBtn = new System.Windows.Forms.PictureBox();
            this.curvaTablero = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarAtras = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logoutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contenidoPnl.SuspendLayout();
            this.contenedorMenuPnl.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuTopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegableBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // contenidoPnl
            // 
            this.contenidoPnl.BackColor = System.Drawing.SystemColors.Control;
            this.contenidoPnl.Controls.Add(this.panel1);
            this.AnimacionSidebarAtras.SetDecoration(this.contenidoPnl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.contenidoPnl, BunifuAnimatorNS.DecorationType.None);
            this.contenidoPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenidoPnl.Location = new System.Drawing.Point(0, 0);
            this.contenidoPnl.Margin = new System.Windows.Forms.Padding(4);
            this.contenidoPnl.Name = "contenidoPnl";
            this.contenidoPnl.Size = new System.Drawing.Size(1837, 960);
            this.contenidoPnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AnimacionSidebarAtras.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(408, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 863);
            this.panel1.TabIndex = 0;
            // 
            // contenedorMenuPnl
            // 
            this.contenedorMenuPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.contenedorMenuPnl.Controls.Add(this.Sidebar);
            this.AnimacionSidebarAtras.SetDecoration(this.contenedorMenuPnl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.contenedorMenuPnl, BunifuAnimatorNS.DecorationType.None);
            this.contenedorMenuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorMenuPnl.Location = new System.Drawing.Point(0, 81);
            this.contenedorMenuPnl.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorMenuPnl.Name = "contenedorMenuPnl";
            this.contenedorMenuPnl.Size = new System.Drawing.Size(400, 879);
            this.contenedorMenuPnl.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.logoutBtn);
            this.Sidebar.Controls.Add(this.InformacionMedicaBtn);
            this.Sidebar.Controls.Add(this.diagnosticoBtn);
            this.Sidebar.Controls.Add(this.citaBtn);
            this.Sidebar.Controls.Add(this.Pacientebtn);
            this.Sidebar.Controls.Add(this.linea);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Controls.Add(this.pictureBox3);
            this.AnimacionSidebarAtras.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.MediumSlateBlue;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.Purple;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Gray;
            this.Sidebar.Location = new System.Drawing.Point(16, 30);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(360, 834);
            this.Sidebar.TabIndex = 0;
            // 
            // InformacionMedicaBtn
            // 
            this.InformacionMedicaBtn.Activecolor = System.Drawing.Color.Transparent;
            this.InformacionMedicaBtn.BackColor = System.Drawing.Color.Transparent;
            this.InformacionMedicaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InformacionMedicaBtn.BorderRadius = 0;
            this.InformacionMedicaBtn.ButtonText = "        INFORMACION MEDICA";
            this.InformacionMedicaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.InformacionMedicaBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.InformacionMedicaBtn, BunifuAnimatorNS.DecorationType.None);
            this.InformacionMedicaBtn.DisabledColor = System.Drawing.Color.Gray;
            this.InformacionMedicaBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.InformacionMedicaBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("InformacionMedicaBtn.Iconimage")));
            this.InformacionMedicaBtn.Iconimage_right = null;
            this.InformacionMedicaBtn.Iconimage_right_Selected = null;
            this.InformacionMedicaBtn.Iconimage_Selected = null;
            this.InformacionMedicaBtn.IconMarginLeft = 0;
            this.InformacionMedicaBtn.IconMarginRight = 0;
            this.InformacionMedicaBtn.IconRightVisible = true;
            this.InformacionMedicaBtn.IconRightZoom = 0D;
            this.InformacionMedicaBtn.IconVisible = true;
            this.InformacionMedicaBtn.IconZoom = 50D;
            this.InformacionMedicaBtn.IsTab = false;
            this.InformacionMedicaBtn.Location = new System.Drawing.Point(5, 329);
            this.InformacionMedicaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.InformacionMedicaBtn.Name = "InformacionMedicaBtn";
            this.InformacionMedicaBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.InformacionMedicaBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.InformacionMedicaBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.InformacionMedicaBtn.selected = false;
            this.InformacionMedicaBtn.Size = new System.Drawing.Size(350, 63);
            this.InformacionMedicaBtn.TabIndex = 16;
            this.InformacionMedicaBtn.Text = "        INFORMACION MEDICA";
            this.InformacionMedicaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InformacionMedicaBtn.Textcolor = System.Drawing.Color.LightGray;
            this.InformacionMedicaBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.InformacionMedicaBtn.Click += new System.EventHandler(this.InformacionMedicaBtn_Click);
            // 
            // diagnosticoBtn
            // 
            this.diagnosticoBtn.Activecolor = System.Drawing.Color.Transparent;
            this.diagnosticoBtn.BackColor = System.Drawing.Color.Transparent;
            this.diagnosticoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diagnosticoBtn.BorderRadius = 0;
            this.diagnosticoBtn.ButtonText = "          DIAGNOSTICO";
            this.diagnosticoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.diagnosticoBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.diagnosticoBtn, BunifuAnimatorNS.DecorationType.None);
            this.diagnosticoBtn.DisabledColor = System.Drawing.Color.Gray;
            this.diagnosticoBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.diagnosticoBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("diagnosticoBtn.Iconimage")));
            this.diagnosticoBtn.Iconimage_right = null;
            this.diagnosticoBtn.Iconimage_right_Selected = null;
            this.diagnosticoBtn.Iconimage_Selected = null;
            this.diagnosticoBtn.IconMarginLeft = 0;
            this.diagnosticoBtn.IconMarginRight = 0;
            this.diagnosticoBtn.IconRightVisible = true;
            this.diagnosticoBtn.IconRightZoom = 0D;
            this.diagnosticoBtn.IconVisible = true;
            this.diagnosticoBtn.IconZoom = 50D;
            this.diagnosticoBtn.IsTab = false;
            this.diagnosticoBtn.Location = new System.Drawing.Point(6, 271);
            this.diagnosticoBtn.Margin = new System.Windows.Forms.Padding(5);
            this.diagnosticoBtn.Name = "diagnosticoBtn";
            this.diagnosticoBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.diagnosticoBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.diagnosticoBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.diagnosticoBtn.selected = false;
            this.diagnosticoBtn.Size = new System.Drawing.Size(349, 63);
            this.diagnosticoBtn.TabIndex = 15;
            this.diagnosticoBtn.Text = "          DIAGNOSTICO";
            this.diagnosticoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diagnosticoBtn.Textcolor = System.Drawing.Color.LightGray;
            this.diagnosticoBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.diagnosticoBtn.Click += new System.EventHandler(this.diagnosticoBtn_Click);
            // 
            // citaBtn
            // 
            this.citaBtn.Activecolor = System.Drawing.Color.Transparent;
            this.citaBtn.BackColor = System.Drawing.Color.Transparent;
            this.citaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.citaBtn.BorderRadius = 0;
            this.citaBtn.ButtonText = "          CITA";
            this.citaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.citaBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.citaBtn, BunifuAnimatorNS.DecorationType.None);
            this.citaBtn.DisabledColor = System.Drawing.Color.Gray;
            this.citaBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.citaBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("citaBtn.Iconimage")));
            this.citaBtn.Iconimage_right = null;
            this.citaBtn.Iconimage_right_Selected = null;
            this.citaBtn.Iconimage_Selected = null;
            this.citaBtn.IconMarginLeft = 0;
            this.citaBtn.IconMarginRight = 0;
            this.citaBtn.IconRightVisible = true;
            this.citaBtn.IconRightZoom = 0D;
            this.citaBtn.IconVisible = true;
            this.citaBtn.IconZoom = 50D;
            this.citaBtn.IsTab = false;
            this.citaBtn.Location = new System.Drawing.Point(5, 198);
            this.citaBtn.Margin = new System.Windows.Forms.Padding(5);
            this.citaBtn.Name = "citaBtn";
            this.citaBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.citaBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.citaBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.citaBtn.selected = false;
            this.citaBtn.Size = new System.Drawing.Size(346, 63);
            this.citaBtn.TabIndex = 14;
            this.citaBtn.Text = "          CITA";
            this.citaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citaBtn.Textcolor = System.Drawing.Color.LightGray;
            this.citaBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.citaBtn.Click += new System.EventHandler(this.citaBtn_Click);
            // 
            // Pacientebtn
            // 
            this.Pacientebtn.Activecolor = System.Drawing.Color.Transparent;
            this.Pacientebtn.BackColor = System.Drawing.Color.Transparent;
            this.Pacientebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pacientebtn.BorderRadius = 0;
            this.Pacientebtn.ButtonText = "          PACIENTES";
            this.Pacientebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Pacientebtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.Pacientebtn, BunifuAnimatorNS.DecorationType.None);
            this.Pacientebtn.DisabledColor = System.Drawing.Color.Gray;
            this.Pacientebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Pacientebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Pacientebtn.Iconimage")));
            this.Pacientebtn.Iconimage_right = null;
            this.Pacientebtn.Iconimage_right_Selected = null;
            this.Pacientebtn.Iconimage_Selected = null;
            this.Pacientebtn.IconMarginLeft = 0;
            this.Pacientebtn.IconMarginRight = 0;
            this.Pacientebtn.IconRightVisible = true;
            this.Pacientebtn.IconRightZoom = 0D;
            this.Pacientebtn.IconVisible = true;
            this.Pacientebtn.IconZoom = 50D;
            this.Pacientebtn.IsTab = false;
            this.Pacientebtn.Location = new System.Drawing.Point(0, 135);
            this.Pacientebtn.Margin = new System.Windows.Forms.Padding(5);
            this.Pacientebtn.Name = "Pacientebtn";
            this.Pacientebtn.Normalcolor = System.Drawing.Color.Transparent;
            this.Pacientebtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Pacientebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Pacientebtn.selected = false;
            this.Pacientebtn.Size = new System.Drawing.Size(355, 63);
            this.Pacientebtn.TabIndex = 13;
            this.Pacientebtn.Text = "          PACIENTES";
            this.Pacientebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pacientebtn.Textcolor = System.Drawing.Color.LightGray;
            this.Pacientebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Pacientebtn.Click += new System.EventHandler(this.Pacientebtn_Click);
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarAtras.SetDecoration(this.linea, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.linea, BunifuAnimatorNS.DecorationType.None);
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(15, 82);
            this.linea.Margin = new System.Windows.Forms.Padding(5);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(327, 12);
            this.linea.TabIndex = 0;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultorio Ginecologico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-12, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // menuTopPnl
            // 
            this.menuTopPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.menuTopPnl.Controls.Add(this.Restaurar);
            this.menuTopPnl.Controls.Add(this.Minimizar);
            this.menuTopPnl.Controls.Add(this.Maximizar);
            this.menuTopPnl.Controls.Add(this.Salir);
            this.menuTopPnl.Controls.Add(this.label2);
            this.menuTopPnl.Controls.Add(this.MenuDesplegableBtn);
            this.AnimacionSidebarAtras.SetDecoration(this.menuTopPnl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.menuTopPnl, BunifuAnimatorNS.DecorationType.None);
            this.menuTopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTopPnl.Location = new System.Drawing.Point(0, 0);
            this.menuTopPnl.Margin = new System.Windows.Forms.Padding(4);
            this.menuTopPnl.Name = "menuTopPnl";
            this.menuTopPnl.Size = new System.Drawing.Size(1837, 81);
            this.menuTopPnl.TabIndex = 1;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1733, 26);
            this.Restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(40, 37);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 9;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1685, 26);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 37);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 8;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1733, 26);
            this.Maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(40, 37);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 7;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1781, 26);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(40, 37);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 6;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "OPCIONES";
            // 
            // MenuDesplegableBtn
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuDesplegableBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.MenuDesplegableBtn, BunifuAnimatorNS.DecorationType.None);
            this.MenuDesplegableBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuDesplegableBtn.Image")));
            this.MenuDesplegableBtn.Location = new System.Drawing.Point(36, 26);
            this.MenuDesplegableBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuDesplegableBtn.Name = "MenuDesplegableBtn";
            this.MenuDesplegableBtn.Size = new System.Drawing.Size(40, 37);
            this.MenuDesplegableBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuDesplegableBtn.TabIndex = 1;
            this.MenuDesplegableBtn.TabStop = false;
            this.MenuDesplegableBtn.Click += new System.EventHandler(this.MenuDesplegableBtn_Click);
            // 
            // curvaTablero
            // 
            this.curvaTablero.ElipseRadius = 7;
            this.curvaTablero.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebar.Cursor = null;
            animation14.AnimateOnlyDifferences = true;
            animation14.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.BlindCoeff")));
            animation14.LeafCoeff = 0F;
            animation14.MaxTime = 1F;
            animation14.MinTime = 0F;
            animation14.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicCoeff")));
            animation14.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicShift")));
            animation14.MosaicSize = 0;
            animation14.Padding = new System.Windows.Forms.Padding(0);
            animation14.RotateCoeff = 0F;
            animation14.RotateLimit = 0F;
            animation14.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.ScaleCoeff")));
            animation14.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.SlideCoeff")));
            animation14.TimeCoeff = 0F;
            animation14.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation14;
            // 
            // AnimacionSidebarAtras
            // 
            this.AnimacionSidebarAtras.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarAtras.Cursor = null;
            animation13.AnimateOnlyDifferences = true;
            animation13.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.BlindCoeff")));
            animation13.LeafCoeff = 0F;
            animation13.MaxTime = 1F;
            animation13.MinTime = 0F;
            animation13.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicCoeff")));
            animation13.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicShift")));
            animation13.MosaicSize = 0;
            animation13.Padding = new System.Windows.Forms.Padding(0);
            animation13.RotateCoeff = 0F;
            animation13.RotateLimit = 0F;
            animation13.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.ScaleCoeff")));
            animation13.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.SlideCoeff")));
            animation13.TimeCoeff = 0F;
            animation13.TransparencyCoeff = 0F;
            this.AnimacionSidebarAtras.DefaultAnimation = animation13;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.contenidoPnl;
            // 
            // Mover
            // 
            this.Mover.Fixed = true;
            this.Mover.Horizontal = true;
            this.Mover.TargetControl = this.menuTopPnl;
            this.Mover.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Activecolor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.BorderRadius = 0;
            this.logoutBtn.ButtonText = "       CERRAR SESIÓN";
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.logoutBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.logoutBtn, BunifuAnimatorNS.DecorationType.None);
            this.logoutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.logoutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Iconimage")));
            this.logoutBtn.Iconimage_right = null;
            this.logoutBtn.Iconimage_right_Selected = null;
            this.logoutBtn.Iconimage_Selected = null;
            this.logoutBtn.IconMarginLeft = 0;
            this.logoutBtn.IconMarginRight = 0;
            this.logoutBtn.IconRightVisible = true;
            this.logoutBtn.IconRightZoom = 0D;
            this.logoutBtn.IconVisible = true;
            this.logoutBtn.IconZoom = 50D;
            this.logoutBtn.IsTab = false;
            this.logoutBtn.Location = new System.Drawing.Point(6, 391);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(5);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.logoutBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.logoutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutBtn.selected = false;
            this.logoutBtn.Size = new System.Drawing.Size(354, 63);
            this.logoutBtn.TabIndex = 19;
            this.logoutBtn.Text = "       CERRAR SESIÓN";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Textcolor = System.Drawing.Color.LightGray;
            this.logoutBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Menuform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1837, 960);
            this.Controls.Add(this.contenedorMenuPnl);
            this.Controls.Add(this.menuTopPnl);
            this.Controls.Add(this.contenidoPnl);
            this.AnimacionSidebarAtras.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menuform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menuform";
            this.contenidoPnl.ResumeLayout(false);
            this.contenedorMenuPnl.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuTopPnl.ResumeLayout(false);
            this.menuTopPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegableBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenidoPnl;
        private System.Windows.Forms.Panel contenedorMenuPnl;
        private System.Windows.Forms.Panel menuTopPnl;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MenuDesplegableBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton diagnosticoBtn;
        private Bunifu.Framework.UI.BunifuFlatButton citaBtn;
        private Bunifu.Framework.UI.BunifuFlatButton Pacientebtn;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuElipse curvaTablero;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarAtras;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl Mover;
        private Bunifu.Framework.UI.BunifuFlatButton InformacionMedicaBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton logoutBtn;
    }
}