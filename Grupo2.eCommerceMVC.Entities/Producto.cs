using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data.Models
{
    public class Producto
    {
        public int idProducto { get; set; }      
        public string nombre { get; set; }        
        public int idCategoria { get; set; }
        public float precio { get; set; }
    }
}
