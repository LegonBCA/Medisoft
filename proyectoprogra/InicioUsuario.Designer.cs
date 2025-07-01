namespace proyectoprogra
{
    partial class InicioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioUsuario));
            panel1 = new Panel();
            CerrarSesión = new Button();
            Asistencia = new Button();
            button2 = new Button();
            button1 = new Button();
            DocUsuarios = new Button();
            pictureBox1 = new PictureBox();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            labelReloj = new Label();
            label2 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            GrillaDocUsuario = new DataGridView();
            panel2 = new Panel();
            textSemestre = new TextBox();
            textProfesionalaCargo = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            textContactoUsuario = new TextBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            textDireccionUsuario = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            textRutUsuario = new TextBox();
            textNombreUsuario = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrillaDocUsuario).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 0, 58);
            panel1.Controls.Add(CerrarSesión);
            panel1.Controls.Add(Asistencia);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(DocUsuarios);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 650);
            panel1.TabIndex = 0;
            // 
            // CerrarSesión
            // 
            CerrarSesión.BackColor = Color.FromArgb(40, 40, 40);
            CerrarSesión.BackgroundImageLayout = ImageLayout.None;
            CerrarSesión.ForeColor = Color.White;
            CerrarSesión.Location = new Point(28, 567);
            CerrarSesión.Name = "CerrarSesión";
            CerrarSesión.Size = new Size(169, 29);
            CerrarSesión.TabIndex = 14;
            CerrarSesión.Text = "Cerrar Sesión";
            CerrarSesión.UseVisualStyleBackColor = false;
            CerrarSesión.Click += CerrarSesión_Click;
            // 
            // Asistencia
            // 
            Asistencia.BackColor = Color.FromArgb(40, 40, 40);
            Asistencia.FlatStyle = FlatStyle.Flat;
            Asistencia.ForeColor = SystemColors.ControlLight;
            Asistencia.Location = new Point(28, 431);
            Asistencia.Name = "Asistencia";
            Asistencia.Size = new Size(169, 29);
            Asistencia.TabIndex = 13;
            Asistencia.Text = "Pedir Asistencia";
            Asistencia.UseVisualStyleBackColor = false;
            Asistencia.Click += Asistencia_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 40, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(28, 376);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 12;
            button2.Text = "Guardar Cambios";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(28, 324);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 11;
            button1.Text = "Editar Datos";
            button1.UseVisualStyleBackColor = false;
            // 
            // DocUsuarios
            // 
            DocUsuarios.BackColor = Color.FromArgb(40, 40, 40);
            DocUsuarios.FlatStyle = FlatStyle.Flat;
            DocUsuarios.ForeColor = SystemColors.ControlLight;
            DocUsuarios.Location = new Point(28, 272);
            DocUsuarios.Name = "DocUsuarios";
            DocUsuarios.Size = new Size(169, 29);
            DocUsuarios.TabIndex = 10;
            DocUsuarios.Text = "Descargar Documentos";
            DocUsuarios.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(27, 0, 58);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(910, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 10;
            btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(946, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 11;
            btnCerrar.TabStop = false;
            // 
            // labelReloj
            // 
            labelReloj.BackColor = Color.FromArgb(20, 20, 20);
            labelReloj.Font = new Font("Segoe UI", 20F);
            labelReloj.ForeColor = SystemColors.ButtonFace;
            labelReloj.Location = new Point(350, 80);
            labelReloj.Name = "labelReloj";
            labelReloj.Size = new Size(626, 54);
            labelReloj.TabIndex = 12;
            labelReloj.Text = "00:00:00";
            labelReloj.TextAlign = ContentAlignment.MiddleCenter;
            labelReloj.Click += labelReloj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(575, 33);
            label2.Name = "label2";
            label2.Size = new Size(169, 37);
            label2.TabIndex = 14;
            label2.Text = "Fecha actual:";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // GrillaDocUsuario
            // 
            GrillaDocUsuario.BackgroundColor = Color.WhiteSmoke;
            GrillaDocUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaDocUsuario.Location = new Point(750, 217);
            GrillaDocUsuario.Name = "GrillaDocUsuario";
            GrillaDocUsuario.Size = new Size(199, 379);
            GrillaDocUsuario.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(textSemestre);
            panel2.Controls.Add(textProfesionalaCargo);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textContactoUsuario);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textDireccionUsuario);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textRutUsuario);
            panel2.Controls.Add(textNombreUsuario);
            panel2.Location = new Point(284, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 379);
            panel2.TabIndex = 16;
            // 
            // textSemestre
            // 
            textSemestre.Location = new Point(102, 335);
            textSemestre.Margin = new Padding(3, 2, 3, 2);
            textSemestre.Multiline = true;
            textSemestre.Name = "textSemestre";
            textSemestre.Size = new Size(230, 31);
            textSemestre.TabIndex = 43;
            // 
            // textProfesionalaCargo
            // 
            textProfesionalaCargo.Location = new Point(103, 277);
            textProfesionalaCargo.Margin = new Padding(3, 2, 3, 2);
            textProfesionalaCargo.Multiline = true;
            textProfesionalaCargo.Name = "textProfesionalaCargo";
            textProfesionalaCargo.Size = new Size(230, 31);
            textProfesionalaCargo.TabIndex = 42;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_31;
            pictureBox6.Location = new Point(63, 335);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 41;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.System_administrator_male;
            pictureBox5.Location = new Point(63, 276);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 40;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(102, 318);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 39;
            label10.Text = "Semestre ";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(102, 260);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 37;
            label8.Text = "Profesional a Cargo";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(59, 220);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 28);
            pictureBox7.TabIndex = 28;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 201);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 27;
            label4.Text = "Contacto";
            // 
            // textContactoUsuario
            // 
            textContactoUsuario.Location = new Point(102, 218);
            textContactoUsuario.Margin = new Padding(3, 2, 3, 2);
            textContactoUsuario.Multiline = true;
            textContactoUsuario.Name = "textContactoUsuario";
            textContactoUsuario.Size = new Size(230, 31);
            textContactoUsuario.TabIndex = 26;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(59, 156);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 28);
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 132);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 24;
            label5.Text = "Direccion";
            // 
            // textDireccionUsuario
            // 
            textDireccionUsuario.Location = new Point(102, 156);
            textDireccionUsuario.Margin = new Padding(3, 2, 3, 2);
            textDireccionUsuario.Multiline = true;
            textDireccionUsuario.Name = "textDireccionUsuario";
            textDireccionUsuario.Size = new Size(230, 32);
            textDireccionUsuario.TabIndex = 23;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(59, 90);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 28);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(59, 34);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 28);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 70);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 20;
            label3.Text = "Rut";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 17);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 19;
            label1.Text = "Nombre Usuario";
            // 
            // textRutUsuario
            // 
            textRutUsuario.Location = new Point(102, 87);
            textRutUsuario.Margin = new Padding(3, 2, 3, 2);
            textRutUsuario.Multiline = true;
            textRutUsuario.Name = "textRutUsuario";
            textRutUsuario.Size = new Size(230, 31);
            textRutUsuario.TabIndex = 18;
            // 
            // textNombreUsuario
            // 
            textNombreUsuario.Location = new Point(155, 33);
            textNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            textNombreUsuario.Multiline = true;
            textNombreUsuario.Name = "textNombreUsuario";
            textNombreUsuario.Size = new Size(230, 29);
            textNombreUsuario.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(750, 162);
            label6.Name = "label6";
            label6.Size = new Size(173, 37);
            label6.TabIndex = 17;
            label6.Text = "Documentos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(398, 162);
            label7.Name = "label7";
            label7.Size = new Size(190, 37);
            label7.TabIndex = 18;
            label7.Text = "Datos Usuario:";
            // 
            // InicioUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1000, 650);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(GrillaDocUsuario);
            Controls.Add(label2);
            Controls.Add(labelReloj);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioUsuario";
            Text = "InicioUsuario";
            Load += InicioUsuario_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrillaDocUsuario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button Asistencia;
        private Button button2;
        private Button button1;
        private Button DocUsuarios;
        private Button CerrarSesión;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Label labelReloj;
        private Label label2;
        private System.Windows.Forms.Timer timer;
        private DataGridView GrillaDocUsuario;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private TextBox textRutUsuario;
        private TextBox textNombreUsuario;
        private PictureBox pictureBox4;
        private Label label5;
        private TextBox textDireccionUsuario;
        private PictureBox pictureBox7;
        private Label label4;
        private TextBox textContactoUsuario;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label7;
        private TextBox textSemestre;
        private TextBox textProfesionalaCargo;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}