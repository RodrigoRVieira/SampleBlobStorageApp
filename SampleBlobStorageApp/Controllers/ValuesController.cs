using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SampleAuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("GetAnonymous")]
        public ActionResult<IEnumerable<string>> GetAnonymous()
        {
            return new string[] { "This route is unprotected!" };
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "It works! This route is protected." };
        }
    }
}
