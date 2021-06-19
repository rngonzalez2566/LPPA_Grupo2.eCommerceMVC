using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BLL
{
    public class Mapper_Categoria
    {
        DAL.Categoria mapper = new DAL.Categoria(); 
        public IList<Data.Models.Categoria> TraerCategorias()
        {
            return mapper.TraerCategorias();
        }
    }
}
