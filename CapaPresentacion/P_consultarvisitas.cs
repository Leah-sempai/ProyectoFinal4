using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CapaDatos;
using CapaNegocio;
using System.Runtime.InteropServices;




namespace CapaPresentacion
{
    public partial class P_consultarvisitas : Form
    {

        Combobox combo = new Combobox();
        N_usuario objnego = new N_usuario();
        DataTable data = new DataTable();
        
        public P_consultarvisitas()
        {
            InitializeComponent();
            combo.Seleccionar(cbxEdificios);
            combo.Escoger(cbxAula);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

       

        private void P_consultarvisitas_Load(object sender, EventArgs e)
        {

        }

        private void cbxEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxEdificios.SelectedIndex > 0)
            {
                string[] valores = combo.captar_info(cbxEdificios.Text);
            }
        }

        public void mostrarTabla(string buscar)
        {
            TablaConsultarVisitas.DataSource = objnego.ListarEdificio(buscar);    
        }
        public void mostrar(string buscar)
        {
            TablaConsultarVisitas.DataSource = objnego.ListarAula(buscar);
        }



        private void txtEdificios_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarConsultar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void cbxAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxAula.SelectedIndex > 0)
            {
                string[] valores = combo.captar_info1(cbxAula.Text);

            }
        }

        private void btnBuscarEdificiosConsultar_Click(object sender, EventArgs e)
        {
            mostrarTabla(txtEdificios.Text);
        }

        private void btnBuscarConsultarAula_Click(object sender, EventArgs e)
        {
            mostrarTabla(txtAulas.Text);
        }
    }
}
