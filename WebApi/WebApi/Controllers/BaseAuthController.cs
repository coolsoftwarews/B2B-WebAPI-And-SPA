using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Authorize]
    public class BaseAuthController : ControllerBase
    {


        protected string GetUserIdentifier(string userIdentifier = null)
        {

            var claim = User.FindFirst("preferred_username")?.Value;

            if (claim == null)
                return null;

            return claim;
        }

        protected string Name()
        {
            var claim = User.FindFirst("name")?.Value;

            if (claim == null)
                return null;

            return claim;
        }

     

        protected string GetObjectIdentifier()
        {
            var claim = User.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;

            if (claim == null)
                return null;

            return claim;
        }
    }
}
