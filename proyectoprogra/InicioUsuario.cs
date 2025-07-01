using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoprogra
{
    public partial class InicioUsuario : Form
    {
        public InicioUsuario()
        {
            InitializeComponent();
        }

        private void CerrarSesión_Click(object sender, EventArgs e)
        {
            Login AccederAdmin = new Login();
            AccederAdmin.Show();

            this.Hide();
        }

        private void labelReloj_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToString("F");
        }

        private void InicioUsuario_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Asistencia_Click(object sender, EventArgs e)
        {
            AsistenciaUsuario AccederAdmin = new AsistenciaUsuario();
            AccederAdmin.Show();

            
        }
    }
}
