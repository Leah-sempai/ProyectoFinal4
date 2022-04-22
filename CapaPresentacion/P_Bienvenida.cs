using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class P_Bienvenida : Form
    {
        public P_Bienvenida()
        {
            InitializeComponent();
        }

        private void bienvenidaCircleProgressbar1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void P_Bienvenida_Load_1(object sender, EventArgs e)
        {

            E_sesion objl = new E_sesion();
            lblEspereunmomento.Text = objl.LoginName + "Espere un momento" + objl.Apellido;
            this.Opacity = 0.0;

            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 2;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();

            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

