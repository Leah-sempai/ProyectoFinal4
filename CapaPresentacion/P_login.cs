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
using CapaNegocio;
using CapaEntidades;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class P_login : Form
    {
        E_sesion obje = new E_sesion();
        N_users objn = new N_users();
        public P_login()
        {
            InitializeComponent();
        }
        [DllImport("user.32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user.32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void P_Cerrarlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void P_minimizarlogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void P_medialogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void P_login_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                P_administrador form2 = new P_administrador();

                DataTable dt = new DataTable();
                obje.LoginName = txtUsuariologin.Text;
                obje.Password = txtContraseñalogin.Text;
                dt = objn.N_login(obje);

                if (dt.Rows[0][1].ToString() == "Admin")
                {
                    MessageBox.Show("ADMINISTRADOR");
                    obje.LoginName = dt.Rows[0][1].ToString();
                    obje.Password = dt.Rows[0][2].ToString();
                    this.Hide();

                    P_Bienvenida p_bienvenida = new P_Bienvenida();
                    p_bienvenida.ShowDialog();
                    P_administrador mainMenu = new P_administrador();
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                }
                else if (dt.Rows[0][1].ToString() == "General")
                {
                    MessageBox.Show("USUARIO GENERAL");
                    obje.LoginName = dt.Rows[0][1].ToString();
                    obje.Password = dt.Rows[0][2].ToString();
                    this.Hide();

                    P_Bienvenida p_bienvenida = new P_Bienvenida();
                    p_bienvenida.ShowDialog();
                    P_agregarusuario mainMenu = new P_agregarusuario();
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                }
            

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseñalogin.Text = "Password";
            txtContraseñalogin.UseSystemPasswordChar = false;
            txtUsuariologin.Text = "Username";
            txtUsuariologin.UseSystemPasswordChar = false;
            this.Show();
            txtUsuariologin.Focus();
        }
        private void P_Cerrarlogin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void P_minimizarlogin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void P_medialogin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void txtContraseñalogin_Enter_1(object sender, EventArgs e)
        {
            txtContraseñalogin.UseSystemPasswordChar = true;
        }

        private void txtContraseñalogin_Leave_1(object sender, EventArgs e)
        {
            txtContraseñalogin.UseSystemPasswordChar = false;

        }

        private void txtContraseñalogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
