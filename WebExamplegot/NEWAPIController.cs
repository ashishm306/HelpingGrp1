using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebExamplegot
{
    [Route("api/NEWAPI")]
    [ApiController]
    public class NEWAPIController : ControllerBase
    {
        [HttpGet]
        [Route("/api/NEWAPI/ShowElements")]
        public string[] ShowElements()
        {
            return new string[] { "Earth", "Water", "Air", "Fire" };
        }
    }
}
