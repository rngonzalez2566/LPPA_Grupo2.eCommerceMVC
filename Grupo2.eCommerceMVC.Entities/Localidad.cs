using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data.Models
{
    public class Localidad
    {
        public int idLocalidad { get; set; }

        public int idProvincia { get; set; }

        public string nombre { get; set; }
    }
}
