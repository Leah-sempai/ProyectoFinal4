using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidades;


namespace CapaNegocio
{
    public class N_users
    {
        CapaDatos.D_usuario objd = new CapaDatos.D_usuario();

        public DataTable N_login(CapaEntidades.E_sesion obje)
        {
            return objd.D_login(obje);
        }
    }
}