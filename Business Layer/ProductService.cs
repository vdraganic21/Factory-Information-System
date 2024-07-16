using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>
            {
            new Product("58-044-000256", "1", "Product A", 10.5f, 5.0f, "kg", DateTime.Now),
            new Product("58-044-000257", "2", "Product B", 20.0f, 15.0f, "kg", DateTime.Now),
            new Product("58-044-000258", "3", "Product C", 5.5f, 3.0f, "kom", DateTime.Now)
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
