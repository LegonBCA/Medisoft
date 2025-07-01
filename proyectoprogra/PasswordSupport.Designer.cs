namespace proyectoprogra
{
    partial class PasswordSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordSupport));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLoginAdmin = new Button();
            txtMensaje = new RichTextBox();
            btnEnviar = new Button();
            txtContacto = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnVolver = new Button();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picsart_7f064203_d450_4b05_88be_0e99bb45916f;
            pictureBox1.Location = new Point(-48, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            panel1.Size = new Size(278, 415);
            panel1.TabIndex = 8;
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
            // txtMensaje
            // 
            txtMensaje.BackColor = Color.FromArgb(13, 13, 13);
            txtMensaje.ForeColor = Color.DimGray;
            txtMensaje.Location = new Point(382, 236);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(363, 96);
            txtMensaje.TabIndex = 15;
            txtMensaje.Text = "";
            txtMensaje.TextChanged += richTextBox1_TextChanged_1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(40, 40, 40);
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.LightGray;
            btnEnviar.Location = new Point(597, 361);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(148, 30);
            btnEnviar.TabIndex = 12;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // txtContacto
            // 
            txtContacto.BackColor = Color.FromArgb(15, 15, 15);
            txtContacto.BorderStyle = BorderStyle.FixedSingle;
            txtContacto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContacto.ForeColor = Color.DimGray;
            txtContacto.Location = new Point(382, 184);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(363, 27);
            txtContacto.TabIndex = 11;
            txtContacto.Text = "CONTACTO";
            txtContacto.Enter += txtContacto_Enter;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(382, 130);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(363, 27);
            txtEmail.TabIndex = 10;
            txtEmail.Text = "EMAIL";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(15, 15, 15);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(382, 79);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 27);
            txtNombre.TabIndex = 14;
            txtNombre.Text = "NOMBRE";
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(445, 25);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 16;
            label1.Text = "SOLICITA CONTRASEÑA";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(40, 40, 40);
            btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(382, 361);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(148, 30);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(766, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 18;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(793, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 19;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // PasswordSupport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(821, 415);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(txtMensaje);
            Controls.Add(txtNombre);
            Controls.Add(panel1);
            Controls.Add(btnEnviar);
            Controls.Add(txtEmail);
            Controls.Add(txtContacto);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordSupport";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordSupport";
            MouseDown += PasswordSupport_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLoginAdmin;
        private Button btnEnviar;
        private TextBox txtContacto;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private RichTextBox txtMensaje;
        private Label label1;
        private Button btnVolver;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
    }
}