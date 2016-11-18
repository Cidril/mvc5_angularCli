using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pv_Inf.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult getText()
        {
            return Ok(new { id = -1, text = "WOOOOOOHOOOOOOO" });
        }
    }
}
