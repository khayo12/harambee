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
    public class BundlesController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: api/Bundles
        public IQueryable<Bundle> GetBundles()
        {
            return db.Bundles;
        }
    }
}