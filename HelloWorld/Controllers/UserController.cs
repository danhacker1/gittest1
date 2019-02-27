using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class UserController : Controller
    {
        [Route("admin/[controller]/[action]")]
        // GET: /<controller>/
        public string Index()
        {
            return "from User Index";
        }
    }
}
