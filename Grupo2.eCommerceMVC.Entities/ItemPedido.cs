using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data.Models
{
    public class ItemPedido
    {
        public int idItemPedido { get; set; }

        public int idCabeceraPedido { get; set; }

        public int idProducto { get; set; }

        public int cantidad { get; set; }

        public float PrecioUnitario { get; set; }

        public float Total { get; set; }
    }
}
