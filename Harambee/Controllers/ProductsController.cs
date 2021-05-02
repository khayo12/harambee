using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Harambee.Models;
using Harambee.Models.Context;

namespace Harambee.Controllers
{
    public class ProductsController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            var product = db.Products.Where(p => p.CategoryId == id).ToList();
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}