using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
     //   [Route("Index")]
        public string Index()
        {
            return "Hello from home controller.Index!";
        }
        //[Route("")]
        //[Route("about")]
        //[Route("something")]
        public string About()
        {
            return "About us";
        }
    }
}
