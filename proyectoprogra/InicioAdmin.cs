using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyectoprogra
{
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void VerUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void InicioAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarSesión_Click(object sender, EventArgs e)
        {
            Login VolverLogin = new Login();
            VolverLogin.Show();

            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            Register AñadirUsuario = new Register();
            AñadirUsuario.Show();

        }

        private void CrearAdmin_Click(object sender, EventArgs e)
        {
            RegisterAdmin AñadirAdmin = new RegisterAdmin();
            AñadirAdmin.Show();
        }

        private void labelReloj_Click(object sender, EventArgs e)
        {

        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            timerReloj.Interval = 1000;
            timerReloj.Start();
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToString("F");
        }

        private void DocUsuarios_Click(object sender, EventArgs e)
        {
            DocumentosUsuarios Abrir = new DocumentosUsuarios();
            Abrir.Show();
        }
    }
}
