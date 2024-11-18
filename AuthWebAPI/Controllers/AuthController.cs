using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Specifications;
using EcommerseServices;
using ECommerseEntities;
using System.Web.UI.WebControls;

namespace AuthWebAPI.Controllers
{
    public class AuthController : ApiController
    {
        IAuthServices svc = null;

        AuthController()
        {
            svc = new AuthServices();
        }

        public IEnumerable<Credential> Get()    // always returns collection 
        {
            AuthServices svcc = new AuthServices();
            svcc.SeedingCred();
            List<Credential> credentials = svcc.GetAllCredentials();
            return credentials;
        }

        public HttpResponseMessage Post([FromBody] Credential credentials)
        {
            bool validation = svc.Login(credentials.Email,credentials.Password);
            
            var response = Request.CreateResponse(HttpStatusCode.OK,new {LoginStatus=validation});
            return response;
        }

    }
}
