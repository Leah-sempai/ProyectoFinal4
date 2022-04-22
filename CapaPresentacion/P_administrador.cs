using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_administrador : Form
    {
        public P_administrador()
        {
            InitializeComponent();
        }

        private void btnAgregarVisitaAdministrador_Click(object sender, EventArgs e)
        {
            Form formulario = new P_agregarvisita();
            formulario.Show();
        }

        private void btnAgregarUsuarioAdministrador_Click(object sender, EventArgs e)
        {
            Form formulario = new P_agregarusuario();
            formulario.Show();
        }

        private void btnConsultarVisitaAdministrador_Click(object sender, EventArgs e)
        {
            Form formulario = new P_consultarvisitas();
            formulario.Show();
        }

        private void P_administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
