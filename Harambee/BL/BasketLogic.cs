using Harambee.Interfaces;
using Harambee.Models;
using Harambee.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Harambee.BL
{
    public class BasketLogic : IBasketLogic
    {
        private DatabaseContext db = new DatabaseContext();
        public bool CheckBunndle(Basket basket)
        {
            var customerBasket = db.Baskets.Where(c => c.CustomerId == basket.CustomerId).ToList();
            var bundles = db.Bundles;
            foreach(var item in customerBasket)
            {
                var bundle = bundles.Select(b => b.ProductIds.Contains(item.ProductId));
                return bundle.Any();
            }
            return false;
        }

        public double CheckValue(int id)
        {
            double value = 0.00;
            Product product = new Product();

            var customerBasket = db.Baskets.Where(c => c.CustomerId == id).ToList();

            if (customerBasket == null)
            {
                return value;
            }
            
            foreach(var item in customerBasket)
            {
                product = db.Products.Find(item.ProductId);
                value += product.Price;
            }
            var discountItem = customerBasket.Where(c => c.Discount == true);
            if(discountItem.Any())
            {
                value = value * 0.75;
            }
            return value;
        }
    }
}