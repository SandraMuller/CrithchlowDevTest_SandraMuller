using CrithchlowDevTest.Database;
using CrithchlowDevTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace CrithchlowDevTest.Controllers
{
    public class DevTestController : ApiController
    {
        public DevTestData db = new DevTestData();

        // GET: api/DevTest
        public IEnumerable<DevTestModel> Get()
        {
            return db.SeedData();
        }

        // GET: api/DevTest/5
        [ResponseType(typeof(DevTestModel))]
        public IHttpActionResult Get(int id)
        {
            DevTestModel product = db.SeedData().Where(w => w.ID == id).First();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
