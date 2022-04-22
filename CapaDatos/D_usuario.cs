using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_usuario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        public DataTable D_login(CapaEntidades.E_sesion obje)
        {
            SqlCommand cmd = new SqlCommand("SP_login", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoginName", obje.LoginName);
            cmd.Parameters.AddWithValue("@Password", obje.Password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            return dtable;

            SqlDataReader reader = cmd.ExecuteReader();

            E_sesion objE = new E_sesion();
            conexion.Close();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    objE.IdUser = reader.GetInt32(0);
                    objE.LoginName = reader.GetString(1);
                    objE.Password = reader.GetString(2);
                    objE.Nombre = reader.GetString(3);
                    objE.Apellido = reader.GetString(4);
                    objE.Posicion = reader.GetString(5);
                    objE.Email = reader.GetString(6);

                }
                return dtable;
            }

        }
    }
}
