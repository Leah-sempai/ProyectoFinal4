using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaDatos;

namespace CapaPresentacion
{
    class Combobox
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        public void Seleccionar(ComboBox cb)
        {
            
            cb.Items.Clear();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select * from Usuario", conexion);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cb.Items.Add(dr[5].ToString());
            }
            conexion.Close();
            cb.Items.Insert(0, "Edificios Registrados");
            cb.SelectedIndex = 0;
        }
        public string[] captar_info(string edificio)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Usuario where Edificio='" + edificio + "'", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString()
                };
                resultado = valores;
            }
            conexion.Close();
            return resultado;
        }
        public void Escoger(ComboBox cb1)
        {
            cb1.Items.Clear();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Usuario", conexion);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cb1.Items.Add(dr[7].ToString());
            }
            conexion.Close();
            cb1.Items.Insert(0, "Aulas Registrada");
            cb1.SelectedIndex = 0;
        }

        public string[] captar_info1(string Aula)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Usuario where Aula='" + Aula + "'", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString()
                };
                resultado = valores;
            }
            conexion.Close();
            return resultado;
        }
    }
   
}
