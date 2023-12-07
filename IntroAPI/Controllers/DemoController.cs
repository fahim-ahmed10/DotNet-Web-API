using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/names")]
        public HttpResponseMessage GetNames()
        {
            var names = new String[] { "Fahim", "Ahmed" };
            return Request.CreateResponse(HttpStatusCode.OK, names);    
        }
        [HttpPost]
        [Route("api/test/post")]
        public HttpResponseMessage ReceivedPost()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Post received");
        }
    }
}
