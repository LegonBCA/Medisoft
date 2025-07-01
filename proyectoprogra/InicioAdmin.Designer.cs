namespace proyectoprogra
{
    partial class InicioAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CerrarSesión = new Button();
            VerCalendario = new Button();
            VerUsuarios = new Button();
            CrearAdmin = new Button();
            DocUsuarios = new Button();
            CrearUsuario = new Button();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            GrillaSesionesHoy = new DataGridView();
            labelReloj = new Label();
            timerReloj = new System.Windows.Forms.Timer(components);
            btnEntrevistasDoc = new Button();
            panel2 = new Panel();
            btnPAVDDoc = new Button();
            btnPAdecDOC = new Button();
            btnPSocDOC = new Button();
            btnEvDesTODoc = new Button();
            btnEvSensorialDoc = new Button();
            btnEvIntegralesDoc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrillaSesionesHoy).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 0, 58);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CerrarSesión);
            panel1.Controls.Add(VerCalendario);
            panel1.Controls.Add(VerUsuarios);
            panel1.Controls.Add(CrearAdmin);
            panel1.Controls.Add(DocUsuarios);
            panel1.Controls.Add(CrearUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 720);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(27, 0, 58);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // CerrarSesión
            // 
            CerrarSesión.BackColor = Color.FromArgb(40, 40, 40);
            CerrarSesión.BackgroundImageLayout = ImageLayout.None;
            CerrarSesión.ForeColor = Color.White;
            CerrarSesión.Location = new Point(50, 669);
            CerrarSesión.Name = "CerrarSesión";
            CerrarSesión.Size = new Size(169, 29);
            CerrarSesión.TabIndex = 7;
            CerrarSesión.Text = "Cerrar Sesión";
            CerrarSesión.UseVisualStyleBackColor = false;
            CerrarSesión.Click += CerrarSesión_Click;
            // 
            // VerCalendario
            // 
            VerCalendario.BackColor = Color.FromArgb(40, 40, 40);
            VerCalendario.FlatStyle = FlatStyle.Flat;
            VerCalendario.ForeColor = SystemColors.ControlLight;
            VerCalendario.Location = new Point(50, 427);
            VerCalendario.Name = "VerCalendario";
            VerCalendario.Size = new Size(169, 53);
            VerCalendario.TabIndex = 6;
            VerCalendario.Text = "Ver Grilla Calendario";
            VerCalendario.UseVisualStyleBackColor = false;
            // 
            // VerUsuarios
            // 
            VerUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            VerUsuarios.FlatStyle = FlatStyle.Flat;
            VerUsuarios.ForeColor = SystemColors.ControlLight;
            VerUsuarios.Location = new Point(50, 496);
            VerUsuarios.Name = "VerUsuarios";
            VerUsuarios.Size = new Size(169, 63);
            VerUsuarios.TabIndex = 5;
            VerUsuarios.Text = "Ver Grilla Usuarios";
            VerUsuarios.UseVisualStyleBackColor = false;
            VerUsuarios.Click += VerUsuarios_Click;
            // 
            // CrearAdmin
            // 
            CrearAdmin.BackColor = Color.FromArgb(40, 40, 40);
            CrearAdmin.FlatStyle = FlatStyle.Flat;
            CrearAdmin.ForeColor = SystemColors.ControlLight;
            CrearAdmin.Location = new Point(50, 303);
            CrearAdmin.Name = "CrearAdmin";
            CrearAdmin.Size = new Size(169, 29);
            CrearAdmin.TabIndex = 3;
            CrearAdmin.Text = "Crear Admin";
            CrearAdmin.UseVisualStyleBackColor = false;
            CrearAdmin.Click += CrearAdmin_Click;
            // 
            // DocUsuarios
            // 
            DocUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            DocUsuarios.FlatStyle = FlatStyle.Flat;
            DocUsuarios.ForeColor = SystemColors.ControlLight;
            DocUsuarios.Location = new Point(50, 350);
            DocUsuarios.Name = "DocUsuarios";
            DocUsuarios.Size = new Size(169, 29);
            DocUsuarios.TabIndex = 4;
            DocUsuarios.Text = "Documenos Usuarios";
            DocUsuarios.UseVisualStyleBackColor = false;
            DocUsuarios.Click += DocUsuarios_Click;
            // 
            // CrearUsuario
            // 
            CrearUsuario.BackColor = Color.FromArgb(40, 40, 40);
            CrearUsuario.BackgroundImageLayout = ImageLayout.None;
            CrearUsuario.FlatStyle = FlatStyle.Flat;
            CrearUsuario.ForeColor = SystemColors.ControlLight;
            CrearUsuario.Location = new Point(50, 255);
            CrearUsuario.Margin = new Padding(3, 2, 3, 2);
            CrearUsuario.Name = "CrearUsuario";
            CrearUsuario.Size = new Size(169, 31);
            CrearUsuario.TabIndex = 2;
            CrearUsuario.Text = "Crear Usuario";
            CrearUsuario.TextImageRelation = TextImageRelation.TextBeforeImage;
            CrearUsuario.UseVisualStyleBackColor = false;
            CrearUsuario.Click += CrearUsuario_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1212, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 9;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1248, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 10;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // GrillaSesionesHoy
            // 
            GrillaSesionesHoy.BackgroundColor = Color.WhiteSmoke;
            GrillaSesionesHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaSesionesHoy.Location = new Point(631, 211);
            GrillaSesionesHoy.Name = "GrillaSesionesHoy";
            GrillaSesionesHoy.Size = new Size(626, 476);
            GrillaSesionesHoy.TabIndex = 0;
            // 
            // labelReloj
            // 
            labelReloj.BackColor = Color.FromArgb(20, 20, 20);
            labelReloj.Font = new Font("Segoe UI", 20F);
            labelReloj.ForeColor = SystemColors.ButtonFace;
            labelReloj.Location = new Point(640, 64);
            labelReloj.Name = "labelReloj";
            labelReloj.Size = new Size(626, 54);
            labelReloj.TabIndex = 1;
            labelReloj.Text = "00:00:00";
            labelReloj.TextAlign = ContentAlignment.MiddleCenter;
            labelReloj.Click += labelReloj_Click;
            // 
            // timerReloj
            // 
            timerReloj.Tick += timerReloj_Tick;
            // 
            // btnEntrevistasDoc
            // 
            btnEntrevistasDoc.BackColor = Color.FromArgb(40, 40, 40);
            btnEntrevistasDoc.FlatStyle = FlatStyle.Flat;
            btnEntrevistasDoc.ForeColor = SystemColors.ControlLight;
            btnEntrevistasDoc.Location = new Point(24, 97);
            btnEntrevistasDoc.Name = "btnEntrevistasDoc";
            btnEntrevistasDoc.Size = new Size(149, 32);
            btnEntrevistasDoc.TabIndex = 11;
            btnEntrevistasDoc.Text = "Entrevistas";
            btnEntrevistasDoc.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(btnPAVDDoc);
            panel2.Controls.Add(btnPAdecDOC);
            panel2.Controls.Add(btnPSocDOC);
            panel2.Controls.Add(btnEvDesTODoc);
            panel2.Controls.Add(btnEvSensorialDoc);
            panel2.Controls.Add(btnEvIntegralesDoc);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnEntrevistasDoc);
            panel2.Location = new Point(361, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 549);
            panel2.TabIndex = 12;
            // 
            // btnPAVDDoc
            // 
            btnPAVDDoc.BackColor = Color.FromArgb(40, 40, 40);
            btnPAVDDoc.FlatStyle = FlatStyle.Flat;
            btnPAVDDoc.ForeColor = SystemColors.ControlLight;
            btnPAVDDoc.Location = new Point(23, 478);
            btnPAVDDoc.Name = "btnPAVDDoc";
            btnPAVDDoc.Size = new Size(149, 45);
            btnPAVDDoc.TabIndex = 17;
            btnPAVDDoc.Text = "Pautas AVD y AVDI";
            btnPAVDDoc.UseVisualStyleBackColor = false;
            // 
            // btnPAdecDOC
            // 
            btnPAdecDOC.BackColor = Color.FromArgb(40, 40, 40);
            btnPAdecDOC.FlatStyle = FlatStyle.Flat;
            btnPAdecDOC.ForeColor = SystemColors.ControlLight;
            btnPAdecDOC.Location = new Point(23, 427);
            btnPAdecDOC.Name = "btnPAdecDOC";
            btnPAdecDOC.Size = new Size(149, 45);
            btnPAdecDOC.TabIndex = 16;
            btnPAdecDOC.Text = "Pautas Adecuaciones";
            btnPAdecDOC.UseVisualStyleBackColor = false;
            // 
            // btnPSocDOC
            // 
            btnPSocDOC.BackColor = Color.FromArgb(40, 40, 40);
            btnPSocDOC.FlatStyle = FlatStyle.Flat;
            btnPSocDOC.ForeColor = SystemColors.ControlLight;
            btnPSocDOC.Location = new Point(23, 376);
            btnPSocDOC.Name = "btnPSocDOC";
            btnPSocDOC.Size = new Size(149, 45);
            btnPSocDOC.TabIndex = 15;
            btnPSocDOC.Text = "Pautas Socioemocionales";
            btnPSocDOC.UseVisualStyleBackColor = false;
            // 
            // btnEvDesTODoc
            // 
            btnEvDesTODoc.BackColor = Color.FromArgb(40, 40, 40);
            btnEvDesTODoc.FlatStyle = FlatStyle.Flat;
            btnEvDesTODoc.ForeColor = SystemColors.ControlLight;
            btnEvDesTODoc.Location = new Point(23, 266);
            btnEvDesTODoc.Name = "btnEvDesTODoc";
            btnEvDesTODoc.Size = new Size(149, 47);
            btnEvDesTODoc.TabIndex = 14;
            btnEvDesTODoc.Text = "Evaluaciones Desemeño Ocupacional";
            btnEvDesTODoc.UseVisualStyleBackColor = false;
            // 
            // btnEvSensorialDoc
            // 
            btnEvSensorialDoc.BackColor = Color.FromArgb(40, 40, 40);
            btnEvSensorialDoc.FlatStyle = FlatStyle.Flat;
            btnEvSensorialDoc.ForeColor = SystemColors.ControlLight;
            btnEvSensorialDoc.Location = new Point(23, 209);
            btnEvSensorialDoc.Name = "btnEvSensorialDoc";
            btnEvSensorialDoc.Size = new Size(149, 32);
            btnEvSensorialDoc.TabIndex = 13;
            btnEvSensorialDoc.Text = "Evaluaciones Sensoriales";
            btnEvSensorialDoc.UseVisualStyleBackColor = false;
            // 
            // btnEvIntegralesDoc
            // 
            btnEvIntegralesDoc.BackColor = Color.FromArgb(40, 40, 40);
            btnEvIntegralesDoc.FlatStyle = FlatStyle.Flat;
            btnEvIntegralesDoc.ForeColor = SystemColors.ControlLight;
            btnEvIntegralesDoc.Location = new Point(24, 151);
            btnEvIntegralesDoc.Name = "btnEvIntegralesDoc";
            btnEvIntegralesDoc.Size = new Size(149, 32);
            btnEvIntegralesDoc.TabIndex = 12;
            btnEvIntegralesDoc.Text = "Evaluaciones integrales";
            btnEvIntegralesDoc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "Plantillas Pautas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(861, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 37);
            label2.TabIndex = 13;
            label2.Text = "Fecha actual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(640, 158);
            label3.Name = "label3";
            label3.Size = new Size(240, 37);
            label3.TabIndex = 14;
            label3.Text = "Sesiones para Hoy:";
            // 
            // InicioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(1288, 720);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(labelReloj);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(GrillaSesionesHoy);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioAdmin";
            Text = "InicioAdmin";
            Load += InicioAdmin_Load;
            MouseDown += InicioAdmin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrillaSesionesHoy).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button VerCalendario;
        private Button VerUsuarios;
        private Button DocUsuarios;
        private Button CrearAdmin;
        private Button CrearUsuario;
        private Button CerrarSesión;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private DataGridView GrillaSesionesHoy;
        private Label labelReloj;
        private System.Windows.Forms.Timer timerReloj;
        private Button btnEntrevistasDoc;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnEvDesTODoc;
        private Button btnEvSensorialDoc;
        private Button btnEvIntegralesDoc;
        private Button btnPAVDDoc;
        private Button btnPAdecDOC;
        private Button btnPSocDOC;
        private Label label3;
    }
}