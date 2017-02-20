
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet]      
      public ActionResult Index() => View();
    }

}