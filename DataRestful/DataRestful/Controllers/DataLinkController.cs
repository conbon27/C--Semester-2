using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataRestful.Models;

namespace DataRestful.Controllers
{
    public class DataLinkController : ApiController
    {
        // GET: api/DataLink
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DataLink/5
        public DataPoints Get(string Station)
        {
            DataPoints data = new DataPoints();
            data.stationID = Station;
            return data;
        }

        // POST: api/DataLink
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DataLink/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DataLink/5
        public void Delete(int id)
        {
        }
    }
}
