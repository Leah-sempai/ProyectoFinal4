using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_usuario
    {
        D_users usuario = new D_users();

        DataTable data = new DataTable();

        public List<E_usuario> ListarUsuario(string buscar)
        {
            return usuario.ListarUsuario(buscar);
        }
        public void InsertandoUsuario(E_usuario categoria)
        {
            usuario.InsertarUsuario(categoria);
        }
        public void EditarUsuario(E_usuario categoria)
        {
            usuario.EditarUsuario(categoria);
        }
        public void EliminandoUsuario(E_usuario categoria)
        {
            usuario.EliminarUsuario(categoria);
        }
        public List<E_usuario> ListarEdificio(string buscar)
        {
            return usuario.ListarEdificio(buscar);
        }
        public List<E_usuario> ListarAula(string buscar)
        {
            return usuario.ListarAula(buscar);
        }


    }
}
