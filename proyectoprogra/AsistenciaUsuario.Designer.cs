namespace proyectoprogra
{
    partial class AsistenciaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciaUsuario));
            btnMinimizar = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLoginAdmin = new Button();
            btnCerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtMensaje = new RichTextBox();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtContacto = new TextBox();
            btnVolver = new Button();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(834, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 10;
            btnMinimizar.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 0, 58);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLoginAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 400);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picsart_7f064203_d450_4b05_88be_0e99bb45916f;
            pictureBox1.Location = new Point(-83, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(737, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 21;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(701, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(396, 25);
            label1.Name = "label1";
            label1.Size = new Size(230, 24);
            label1.TabIndex = 22;
            label1.Text = "SOLICITUD ASISTENCIA";
            // 
            // txtMensaje
            // 
            txtMensaje.BackColor = Color.FromArgb(13, 13, 13);
            txtMensaje.ForeColor = Color.DimGray;
            txtMensaje.Location = new Point(332, 225);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(363, 96);
            txtMensaje.TabIndex = 26;
            txtMensaje.Text = "";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(15, 15, 15);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(332, 68);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 27);
            txtNombre.TabIndex = 25;
            txtNombre.Text = "NOMBRE";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(332, 119);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(363, 27);
            txtEmail.TabIndex = 23;
            txtEmail.Text = "EMAIL";
            // 
            // txtContacto
            // 
            txtContacto.BackColor = Color.FromArgb(15, 15, 15);
            txtContacto.BorderStyle = BorderStyle.FixedSingle;
            txtContacto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContacto.ForeColor = Color.DimGray;
            txtContacto.Location = new Point(332, 173);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(363, 27);
            txtContacto.TabIndex = 24;
            txtContacto.Text = "CONTACTO";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(40, 40, 40);
            btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(332, 359);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(148, 30);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(40, 40, 40);
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.LightGray;
            btnEnviar.Location = new Point(547, 359);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(148, 30);
            btnEnviar.TabIndex = 28;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // AsistenciaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 400);
            Controls.Add(btnEnviar);
            Controls.Add(btnVolver);
            Controls.Add(txtMensaje);
            Controls.Add(txtNombre);
            Controls.Add(txtEmail);
            Controls.Add(txtContacto);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btnMinimizar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AsistenciaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AsistenciaUsuario";
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnMinimizar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLoginAdmin;
        private PictureBox btnCerrar;
        private PictureBox pictureBox2;
        private Label label1;
        private RichTextBox txtMensaje;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtContacto;
        private Button btnVolver;
        private Button btnEnviar;
    }
}