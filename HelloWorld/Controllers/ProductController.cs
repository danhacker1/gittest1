using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public List<string> Index()
        {
            return new List<string>()
            {
                "Item1",
                "Item2"
            };

        }
    }
}
