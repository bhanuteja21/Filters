using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionFiltersExample.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ActionFiltersExample.Controllers
{
    [ApiController]
    [Route("api/controller")]
  
    
    public class WeatherForecastController : ControllerBase
    {
      [Route("myfirstfilter")]
      [HttpGet]
       [ActionFilter]
       [ResultFilter]
        public dynamic Get()
        {
            return (new { Name = "Bhanu", Age = 22, Post = "Junior Software Developer"});
        }
        [Route("Exception")]
        [HttpGet]
        [ExceptionFilter]

        public string GetExc()
        {
            throw new Exception("Exception Occur");
        }
        [Route("getdata")]
        [HttpGet]
        [OutputCache(Duration =5)]

        public string PredeFilter()
        {
            return DateTime.Now.ToString();
        }

    }
}
