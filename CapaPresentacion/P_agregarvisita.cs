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
    public partial class P_agregarvisita : Form

    {
        private string IdUsuario;

        private bool Editarse = false;

        E_usuario objEnti = new E_usuario();
        N_usuario objNego = new N_usuario();
        public P_agregarvisita()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        
        private void lblCerrarAgregarvisita_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void P_agregarvisita_Load(object sender, EventArgs e)
        {
            mostrarTabla("");

        }
        private void mostrarTabla(string buscar)
        {
            N_usuario objNegocio = new N_usuario();
            TablaAgregarvisita.DataSource = objNegocio.ListarUsuario(buscar);
        }
        private void LimpiarCaja()
        {
            Editarse = false;
            txtNombreAgregarvisita.Text = "";
            txtApellidoAgregarvisita.Text = "";
            txtCarreraAgregarvisita.Text = "";
            txtCorreoAgregarVisita.Text = "";
            cbxEdificioAgregarvisita.Text = "";
            cbxAulaAgregarvisita.Text = "";
            txtMotivoAgregarvisita.Text = "";
            txtNombreAgregarvisita.Focus();
        }

        private void dtpFechaAgregarvisita_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpFechaAgregarvisita.Value;

        }

        private void btnAgregarAgregarvisita_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEnti.Nombre = txtNombreAgregarvisita.Text.ToUpper();
                    objEnti.Apellido = txtApellidoAgregarvisita.Text.ToUpper();
                    objEnti.Carrera = txtCarreraAgregarvisita.Text.ToUpper();
                    objEnti.Email = txtCorreoAgregarVisita.Text.ToUpper();
                    objEnti.Edificio = cbxEdificioAgregarvisita.Text.ToUpper();
                    objEnti.Hora = dtpFechaAgregarvisita.Text.ToUpper();
                    objEnti.Aula = cbxAulaAgregarvisita.Text.ToUpper();
                    objEnti.Motivo = txtMotivoAgregarvisita.Text.ToUpper();

                    objNego.InsertandoUsuario(objEnti);

                    MessageBox.Show("Se guardo la visita");
                    mostrarTabla("");
                    LimpiarCaja();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo el registro de la visita" + ex);
                }
            }
                if (Editarse == true)
                {
                    try
                    {
                        objEnti.IdUsuario = Convert.ToInt32(IdUsuario);
                        objEnti.Nombre = txtNombreAgregarvisita.Text.ToUpper();
                        objEnti.Apellido = txtApellidoAgregarvisita.Text.ToUpper();
                        objEnti.Carrera = txtCarreraAgregarvisita.Text.ToUpper();
                        objEnti.Email = txtCorreoAgregarVisita.Text.ToUpper();
                        objEnti.Edificio = cbxEdificioAgregarvisita.Text.ToUpper();
                        objEnti.Hora = dtpFechaAgregarvisita.Text.ToUpper();
                        objEnti.Aula = cbxAulaAgregarvisita.Text.ToUpper();
                        objEnti.Motivo = txtMotivoAgregarvisita.Text.ToUpper();

                        objNego.InsertandoUsuario(objEnti);

                        MessageBox.Show("Se guardo la visita");
                        mostrarTabla("");
                        LimpiarCaja();
                        Editarse = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo guardar el registro de la visita" + ex);
                    }
                }
            }
        


        private void btnModificarAgregarvisita_Click(object sender, EventArgs e)
        {
            if (TablaAgregarvisita.SelectedRows.Count > 0)
            {
                Editarse = true;
                IdUsuario = TablaAgregarvisita.CurrentRow.Cells[0].Value.ToString();
                txtNombreAgregarvisita.Text = TablaAgregarvisita.CurrentRow.Cells[1].Value.ToString();
                txtApellidoAgregarvisita.Text = TablaAgregarvisita.CurrentRow.Cells[2].Value.ToString();
                txtCarreraAgregarvisita.Text = TablaAgregarvisita.CurrentRow.Cells[3].Value.ToString();
                txtCorreoAgregarVisita.Text = TablaAgregarvisita.CurrentRow.Cells[4].Value.ToString();
                cbxEdificioAgregarvisita.Text = TablaAgregarvisita.CurrentRow.Cells[5].Value.ToString();
                cbxAulaAgregarvisita.Text = TablaAgregarvisita.CurrentRow.Cells[6].Value.ToString();
                txtMotivoAgregarvisita.Text = TablaAgregarvisita.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selecciona la fila que desea Editar");
            }
        }

        private void btnEliminarAgregarvisita_Click(object sender, EventArgs e)
        {
            if (TablaAgregarvisita.SelectedRows.Count > 0)
            {
                objEnti.IdUsuario = Convert.ToInt32(TablaAgregarvisita.CurrentRow.Cells[0].Value.ToString());
                objNego.EliminandoUsuario(objEnti);

                MessageBox.Show("Se elimino correctamente");
                mostrarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea Eliminar");
            }
        }
    }
}
