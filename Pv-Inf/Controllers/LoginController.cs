using System.Web.Http;
using System.Web.Http.Description;

namespace INF_PV_neu.Controllers
{
    public class LoginController : ApiController
    {
        public struct LoginData
        {
            public string username;
            public string password;
        }

        [HttpPost]
        [Route("api/login")]
        public IHttpActionResult Login([FromBody]LoginData loginData)
        {
            if (loginData.username == "asd" && loginData.password == "asd")
                return Ok(true);
            return Ok(false);
        }
    }
}
