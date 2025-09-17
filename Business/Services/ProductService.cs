using Business.Interfaces;
using Data.Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductService(AppDbContext dbContext) : IProductService
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product GetProductByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
