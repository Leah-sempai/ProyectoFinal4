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
    public class N_general
    {
        D_general gene = new D_general();

        public List<E_general> ListarGeneral(string buscar)
        {
            return gene.ListarGeneral(buscar);
        }
        public void InsertandoGeneral(E_general categoria)
        {
            gene.InsertarUsuario(categoria);
        }
        public void EditarGeneral(E_general categoria)
        {
            gene.EditarGeneral(categoria);
        }
        public void EliminandoGeneral(E_general categoria)
        {
            gene.EliminarGeneral(categoria);
        }
    }
}
