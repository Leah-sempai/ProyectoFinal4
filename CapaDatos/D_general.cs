using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_general
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_general> ListarGeneral(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_buscargeneral", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_general> Listar = new List<E_general>();
            while (leerfilas.Read())
            {
                Listar.Add(new E_general
                {
                    IdGeneral = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Fecha = leerfilas.GetString(3),

                });
            }
            conexion.Close();
            leerfilas.Close();
            return Listar;
        }
        public void InsertarUsuario(E_general general)
        {
            SqlCommand cmd = new SqlCommand("SP_insertargeneral", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", general.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", general.Apellido);
            cmd.Parameters.AddWithValue("@Fecha", general.Fecha);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void EditarGeneral(E_general general)
        {
            SqlCommand cmd = new SqlCommand("SP_editargeneral", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", general.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", general.Apellido);
            cmd.Parameters.AddWithValue("@Fecha", general.Fecha);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarGeneral(E_general general)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminargeneral", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdGeneral", general.IdGeneral);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
