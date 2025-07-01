namespace proyectoprogra
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnUserlogin = new Button();
            linkpass = new LinkLabel();
            label1 = new Label();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnLoginAdmin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 0, 58);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 248);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(27, 0, 58);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-38, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(268, 57);
            txtuser.Margin = new Padding(3, 2, 3, 2);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(363, 27);
            txtuser.TabIndex = 1;
            txtuser.Text = "USUARIO";
            txtuser.TextChanged += textBox1_TextChanged;
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.DimGray;
            txtpass.Location = new Point(268, 113);
            txtpass.Margin = new Padding(3, 2, 3, 2);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(363, 27);
            txtpass.TabIndex = 2;
            txtpass.Text = "CONTRASEÑA";
            txtpass.Enter += textpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // btnUserlogin
            // 
            btnUserlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnUserlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnUserlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUserlogin.FlatStyle = FlatStyle.Flat;
            btnUserlogin.ForeColor = Color.LightGray;
            btnUserlogin.Location = new Point(268, 176);
            btnUserlogin.Margin = new Padding(3, 2, 3, 2);
            btnUserlogin.Name = "btnUserlogin";
            btnUserlogin.Size = new Size(162, 30);
            btnUserlogin.TabIndex = 3;
            btnUserlogin.Text = "Acceder Usuario";
            btnUserlogin.UseVisualStyleBackColor = false;
            btnUserlogin.Click += btnUserlogin_Click;
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.FromArgb(0, 122, 240);
            linkpass.AutoSize = true;
            linkpass.LinkColor = Color.DimGray;
            linkpass.Location = new Point(376, 224);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(142, 15);
            linkpass.TabIndex = 0;
            linkpass.TabStop = true;
            linkpass.Text = "¿Ha olvidado contraseña?";
            linkpass.LinkClicked += linkpass_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(399, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(656, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 7;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(40, 40, 40);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(629, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 8;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.FromArgb(40, 40, 40);
            btnLoginAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLoginAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.ForeColor = Color.LightGray;
            btnLoginAdmin.Location = new Point(469, 176);
            btnLoginAdmin.Margin = new Padding(3, 2, 3, 2);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(162, 30);
            btnLoginAdmin.TabIndex = 9;
            btnLoginAdmin.Text = "Acceder Admin";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(682, 248);
            Controls.Add(btnLoginAdmin);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(linkpass);
            Controls.Add(btnUserlogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            Text = "Form1";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnUserlogin;
        private LinkLabel linkpass;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnLoginAdmin;
    }
}
