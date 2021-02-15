using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(int id=0)
        {
            return Content("User ID is " + id.ToString());
        }
    }
}