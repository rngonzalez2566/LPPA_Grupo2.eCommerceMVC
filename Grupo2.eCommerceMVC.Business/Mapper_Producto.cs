using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.DAL;

namespace eCommerce.BLL
{
    public class Mapper_Producto
    {
        DAL.Producto mapper = new DAL.Producto();
        public int AltaProducto(Data.Models.Producto producto)
        {
            return mapper.AltaProducto(producto);
        }
    }
}
