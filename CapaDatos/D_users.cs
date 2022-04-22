using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_users
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_usuario> ListarUsuario(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_buscarvisitas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_usuario> Listar = new List<E_usuario>();
            while (leerfilas.Read())
            {
                Listar.Add(new E_usuario
                {
                    IdUsuario = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Carrera = leerfilas.GetString(3),
                    Email = leerfilas.GetString(4),
                    Edificio = leerfilas.GetString(5),
                    Hora = leerfilas.GetString(6),
                    Aula = leerfilas.GetString(7),
                    Motivo = leerfilas.GetString(8),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return Listar;


        }
        public void InsertarUsuario(E_usuario Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_insertarusuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Usuario.Apellido);
            cmd.Parameters.AddWithValue("@Carrera", Usuario.Carrera);
            cmd.Parameters.AddWithValue("@Email", Usuario.Email);
            cmd.Parameters.AddWithValue("@Edificio", Usuario.Edificio);
            cmd.Parameters.AddWithValue("@Hora", Usuario.Hora);
            cmd.Parameters.AddWithValue("@Aula", Usuario.Aula);
            cmd.Parameters.AddWithValue("@Motivo", Usuario.Motivo);

            cmd.ExecuteNonQuery();
            conexion.Close();


        }
        public void EditarUsuario(E_usuario Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_editarusuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Usuario.Apellido);
            cmd.Parameters.AddWithValue("@Carrera", Usuario.Carrera);
            cmd.Parameters.AddWithValue("@Email", Usuario.Email);
            cmd.Parameters.AddWithValue("@Edificio", Usuario.Edificio);
            cmd.Parameters.AddWithValue("@Hora", Usuario.Hora);
            cmd.Parameters.AddWithValue("@Motivo", Usuario.Motivo);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public void EliminarUsuario(E_usuario Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminarusuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        public List<E_usuario> ListarEdificio(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_buscaredificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_usuario> Listar = new List<E_usuario>();
            while (leerfilas.Read())
            {
                Listar.Add(new E_usuario
                {
                    IdUsuario = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Carrera = leerfilas.GetString(3),
                    Email = leerfilas.GetString(4),
                    Edificio = leerfilas.GetString(5),
                    Hora = leerfilas.GetString(6),
                    Aula = leerfilas.GetString(7),
                    Motivo = leerfilas.GetString(8),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return Listar;

        }
        public List<E_usuario> ListarAula(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_buscaraula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            leerfilas = cmd.ExecuteReader();

            List<E_usuario> Listar = new List<E_usuario>();
            while (leerfilas.Read())
            {
                Listar.Add(new E_usuario
                {
                    IdUsuario = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Carrera = leerfilas.GetString(3),
                    Email = leerfilas.GetString(4),
                    Edificio = leerfilas.GetString(5),
                    Hora = leerfilas.GetString(6),
                    Aula = leerfilas.GetString(7),
                    Motivo = leerfilas.GetString(8),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return Listar;
        }
    }
}
