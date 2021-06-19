using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Data.Models;

namespace eCommerce.DAL
{
    public class Categoria
    {
        DAL.Acceso Acceso = new Acceso();  
        public IList<Data.Models.Categoria> TraerCategorias()
        {
            var Consulta = "SELECT * FROM Categoria";
            DataTable dt = Acceso.GenerarConsulta(Consulta);
            var lista = new List<Data.Models.Categoria>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow rows in dt.Rows)
                {
                    int id = int.Parse(rows["idCategoria"].ToString());
                    string nombre = rows["Nombre"].ToString();

                    Data.Models.Categoria categoria = new Data.Models.Categoria();
                    categoria.idCategoria = id;
                    categoria.nombre = nombre;
                    lista.Add(categoria);
                }
            }
            return lista;
        }      
    }
}
