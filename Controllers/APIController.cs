using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using ACFTechTest2.Models;
using ACFTechTest2.Classes;

namespace ACFTechTest2.Controllers
{
    [Route("api/")]
    public class APIController : ControllerBase
    {
        public List<testAPI> Get()
        {
            //this is for testing purposes
            return API.Get();
        }
    }
}