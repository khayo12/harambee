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
using Harambee.BL;
using Harambee.Interfaces;
using Harambee.Models;
using Harambee.Models.Context;

namespace Harambee.Controllers
{
    public class BasketsController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        BasketLogic basketLogic = new BasketLogic();

        // GET: api/Baskets/5
        [ResponseType(typeof(Basket))]
        public double GetBasket(int id)
        {
            return basketLogic.CheckValue(id);
        }
                
        // POST: api/Baskets
        [ResponseType(typeof(Basket))]
        public IHttpActionResult PostBasket(Basket basket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            basket.Discount = basketLogic.CheckBunndle(basket);

            db.Baskets.Add(basket);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = basket.Id }, basket);
        }
    }
}