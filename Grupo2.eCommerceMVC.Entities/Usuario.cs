﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Data.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }

        public string usuario { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public int bloqueo { get; set; }

        public int admin { get; set; }
    }
}
