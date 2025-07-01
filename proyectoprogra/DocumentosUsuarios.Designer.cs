namespace proyectoprogra
{
    partial class DocumentosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentosUsuarios));
            panel1 = new Panel();
            btnBuscarUsu = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textRutUsuario = new TextBox();
            btnLoginAdmin = new Button();
            GrillaDocUsuario = new DataGridView();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            panel2 = new Panel();
            btnAgregarDoc = new Button();
            btnExaminar = new Button();
            pictureBox8 = new PictureBox();
            textRutaArchivo = new TextBox();
            label7 = new Label();
            label2 = new Label();
            btnEliminarDoc = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GrillaDocUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 0, 58);
            panel1.Controls.Add(btnBuscarUsu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textRutUsuario);
            panel1.Controls.Add(btnLoginAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 580);
            panel1.TabIndex = 12;
            // 
            // btnBuscarUsu
            // 
            btnBuscarUsu.BackColor = Color.FromArgb(80, 80, 80);
            btnBuscarUsu.ForeColor = SystemColors.ButtonFace;
            btnBuscarUsu.Location = new Point(37, 341);
            btnBuscarUsu.Margin = new Padding(3, 2, 3, 2);
            btnBuscarUsu.Name = "btnBuscarUsu";
            btnBuscarUsu.Size = new Size(120, 34);
            btnBuscarUsu.TabIndex = 79;
            btnBuscarUsu.Text = "Buscar";
            btnBuscarUsu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(37, 266);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 80;
            label1.Text = "RUT Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picsart_7f064203_d450_4b05_88be_0e99bb45916f;
            pictureBox1.Location = new Point(-87, -85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textRutUsuario
            // 
            textRutUsuario.Location = new Point(37, 297);
            textRutUsuario.Margin = new Padding(3, 2, 3, 2);
            textRutUsuario.Multiline = true;
            textRutUsuario.Name = "textRutUsuario";
            textRutUsuario.Size = new Size(133, 30);
            textRutUsuario.TabIndex = 77;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.FromArgb(40, 40, 40);
            btnLoginAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLoginAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.ForeColor = Color.LightGray;
            btnLoginAdmin.Location = new Point(125, 60);
            btnLoginAdmin.Margin = new Padding(3, 2, 3, 2);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(162, 30);
            btnLoginAdmin.TabIndex = 13;
            btnLoginAdmin.Text = "Acceder Admin";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            // 
            // GrillaDocUsuario
            // 
            GrillaDocUsuario.BackgroundColor = Color.WhiteSmoke;
            GrillaDocUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrillaDocUsuario.Location = new Point(274, 190);
            GrillaDocUsuario.Name = "GrillaDocUsuario";
            GrillaDocUsuario.Size = new Size(564, 340);
            GrillaDocUsuario.TabIndex = 13;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(808, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 15;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(772, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 14;
            btnMinimizar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnAgregarDoc);
            panel2.Controls.Add(btnExaminar);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(textRutaArchivo);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(274, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 91);
            panel2.TabIndex = 16;
            // 
            // btnAgregarDoc
            // 
            btnAgregarDoc.BackColor = Color.FromArgb(80, 80, 80);
            btnAgregarDoc.ForeColor = SystemColors.ButtonFace;
            btnAgregarDoc.Location = new Point(424, 55);
            btnAgregarDoc.Margin = new Padding(3, 2, 3, 2);
            btnAgregarDoc.Name = "btnAgregarDoc";
            btnAgregarDoc.Size = new Size(120, 34);
            btnAgregarDoc.TabIndex = 77;
            btnAgregarDoc.Text = "Agregar";
            btnAgregarDoc.UseVisualStyleBackColor = false;
            // 
            // btnExaminar
            // 
            btnExaminar.BackColor = Color.FromArgb(80, 80, 80);
            btnExaminar.ForeColor = SystemColors.ButtonFace;
            btnExaminar.Location = new Point(424, 2);
            btnExaminar.Margin = new Padding(3, 2, 3, 2);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(120, 34);
            btnExaminar.TabIndex = 76;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Google_Docs;
            pictureBox8.Location = new Point(-36, 68);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 74;
            pictureBox8.TabStop = false;
            // 
            // textRutaArchivo
            // 
            textRutaArchivo.Location = new Point(51, 29);
            textRutaArchivo.Margin = new Padding(3, 2, 3, 2);
            textRutaArchivo.Multiline = true;
            textRutaArchivo.Name = "textRutaArchivo";
            textRutaArchivo.Size = new Size(348, 30);
            textRutaArchivo.TabIndex = 75;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 12);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 73;
            label7.Text = "Subir Documentos Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(419, 139);
            label2.Name = "label2";
            label2.Size = new Size(271, 37);
            label2.TabIndex = 19;
            label2.Text = "Documentos Usuario:";
            // 
            // btnEliminarDoc
            // 
            btnEliminarDoc.BackColor = Color.FromArgb(80, 80, 80);
            btnEliminarDoc.ForeColor = SystemColors.ButtonFace;
            btnEliminarDoc.Location = new Point(718, 535);
            btnEliminarDoc.Margin = new Padding(3, 2, 3, 2);
            btnEliminarDoc.Name = "btnEliminarDoc";
            btnEliminarDoc.Size = new Size(120, 34);
            btnEliminarDoc.TabIndex = 81;
            btnEliminarDoc.Text = "Eliminar Doc";
            btnEliminarDoc.UseVisualStyleBackColor = false;
            // 
            // DocumentosUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(872, 580);
            Controls.Add(btnEliminarDoc);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(GrillaDocUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocumentosUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocumentosUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GrillaDocUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLoginAdmin;
        private DataGridView GrillaDocUsuario;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel panel2;
        private Button btnExaminar;
        private TextBox textRutaArchivo;
        private PictureBox pictureBox8;
        private Label label7;
        private Button btnBuscarUsu;
        private TextBox textRutUsuario;
        private Label label2;
        private Label label1;
        private Button btnAgregarDoc;
        private Button btnEliminarDoc;
    }
}