using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI01.Models;

namespace WebAPI01.Mocks
{
    public class ProductMock
    {
        static IList<Product> productList = new List<Product>();

        public static Product CreateProduct(string nome, double preco)
        {
            var product = new Product()
            {
                Codigo = Guid.NewGuid().ToString(),
                Nome = nome,
                Preco = preco
            };

            return product;
        }

    }
}
