using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Data.Models;

namespace eCommerce.DAL
{
    public class Producto
    {
        Acceso Acceso = new Acceso();
        public int AltaProducto(Data.Models.Producto producto)
        {
            int fa = 0;
            SqlParameter[] Parametros = new SqlParameter[3];
            Parametros[0] = new SqlParameter("@nombre", producto.nombre);
            Parametros[1] = new SqlParameter("@idcategoria", producto.idCategoria);
            Parametros[2] = new SqlParameter("@precio", producto.precio);

            fa = Acceso.Escribir("AltaProducto", Parametros);
            return fa;
        }
        //public Categoria ObtenerIDCategoria()
    }
}
