using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Stock_API.Controllers
{
    public class LoteController : ApiController
    {
        // GET: Lote
        public bool Post([FromBody] Lote lote)
        {
            return true;
        }
    }
}