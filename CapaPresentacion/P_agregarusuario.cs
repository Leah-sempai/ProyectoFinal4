using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class P_agregarusuario : Form
    {
        private string IdGeneral;
        private bool Editarse = false;

        E_general objgen = new E_general(); 
        N_general objnen = new N_general();


        public P_agregarusuario()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        
        private void P_agregarusuario_Load(object sender, EventArgs e)
        {

        }
        private void mostrarTabla(string buscar)
        {
            N_general objnen = new N_general();
            TablaAgregarUsuario.DataSource = objnen.ListarGeneral(buscar);

        }
        private void limpiarCaja()
        {
            Editarse = false;
            txtNombreAgregar.Text="";
            txtApellidoAgregar.Text = "";
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if ( Editarse == false)
            {
                try
                {
                    objgen.Nombre = txtNombreAgregar.Text.ToUpper();
                    objgen.Apellido = txtApellidoAgregar.Text.ToUpper();
                    objgen.Fecha = dtFechaAgregar.Text.ToUpper();

                    objnen.InsertandoGeneral(objgen);

                    MessageBox.Show("Se agrego usuario");
                    mostrarTabla("");
                    limpiarCaja();
                }catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if(TablaAgregarUsuario.SelectedRows.Count > 0)
            {
                
                
                    objgen.IdGeneral = Convert.ToInt32(TablaAgregarUsuario.CurrentRow.Cells[0].Value.ToString());
                    objnen.EliminandoGeneral(objgen);

                    MessageBox.Show("Se elimino correctamente");
                    mostrarTabla("");

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }

        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void dtFechaAgregar_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtFechaAgregar.Value;
        }

        private void btnModifiarUsuario_Click(object sender, EventArgs e)
        {
            if(TablaAgregarUsuario.SelectedRows.Count > 0)
            {
                Editarse = true;
                IdGeneral = TablaAgregarUsuario.CurrentRow.Cells[0].Value.ToString();
                txtNombreAgregar.Text = TablaAgregarUsuario.CurrentRow.Cells[1].Value.ToString();
                txtApellidoAgregar.Text = TablaAgregarUsuario.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona la fila que desea Modificar");
            }


        }


    }
}
