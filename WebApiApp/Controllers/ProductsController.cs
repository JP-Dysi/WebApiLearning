using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class ProductsController : ApiController
    {
		Product[] products = new Product[]
		{
			new Product {Id = 1, Name = "Baseball cap", Category = "Protection", Price = 19 },
			new Product {Id = 1, Name = "Charm coin", Category = "Protection", Price = 6000 },
			new Product {Id = 1, Name = "Trick yo-yo", Category = "Weapons", Price = 998 }
		};


		public IEnumerable<Product> GetAllProducts()
		{
			return products;
		}

		public IHttpActionResult GetProduct(int id)
		{
			var product = products.FirstOrDefault(p => p.Id == id);
			if(product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}
    }
}
