using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI01.Models;
using WebAPI01.Mocks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI01.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<Product> Get()
        {
            var products = ProductMock.CreateProduct("Ze",2.0);
            //List<Product> listaProducts = new List<Product>
            //{
            //    new Product()
            //};
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{Codigo:string}")]
        public IActionResult Get(string id)

        {
            return Ok(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            if (string.IsNullOrEmpty(value.Nome))
            {
                throw new SystemException("O nome não pode ser nulo ou vazio.");
            }
            var ret = ProductMock.CreateProduct(value.Nome, value.Preco);
            //var ret = new Product()
            //{
            //   Codigo = Guid.NewGuid().ToString(),
            //   Nome = value.Nome,
            //  Preco = value.Preco
            //}
            if (string.IsNullOrEmpty(ret.Codigo))
            {
                throw new SystemException("Erro na criação do Product");
            }

            return Ok(ret.Codigo);
        }



        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
