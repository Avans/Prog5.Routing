using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog5.Routing.Model
{
    public interface IProductRepository
    {
        IEnumerable<Model.Product> GetProducts();
    }

    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            var list = new List<Product>();
            list.Add(new Model.Product() { Name = "Lamp", Price = 2.55 });
            list.Add(new Model.Product() { Name = "Kist", Price = 82.50 });
            list.Add(new Model.Product() { Name = "Schoenen", Price = 12.66 });
            list.Add(new Model.Product() { Name = "Shampow", Price = 0.95 });
            return list;
        }
    }
}
