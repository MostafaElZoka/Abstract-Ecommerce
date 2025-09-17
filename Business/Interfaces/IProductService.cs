using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    internal interface IProductService
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProductByCode(string code);

    }
}
