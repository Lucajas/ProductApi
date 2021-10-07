using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI01.Models
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }
    }
}
