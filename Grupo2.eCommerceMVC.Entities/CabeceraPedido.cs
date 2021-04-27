using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data.Models
{
    public class CabeceraPedido
    {
        public int idCabeceraPedido { get; set; }

        public int idUsuario { get; set; }

        public DateTime fecha { get; set; }

        public float total { get; set; }
        public string calle { get; set; }

        public int numero { get; set; }

        public string departamento { get; set; }

        public int idProvincia { get; set; }

        public int idLocalidad { get; set; }

        public int CodigoPostal { get; set; }
    }
}
