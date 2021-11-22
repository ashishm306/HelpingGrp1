using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    [Route("api/Test")]
    [ApiController]
    public class HomeController : Controller
    {
        
        [HttpGet]
        [Route("/api/Test/Showgrp")]
        public string[] ShowGRP()
        {
            return new string[] { "Aditya","Deepika","Ashish","Shubham"};
        }
    }
}
