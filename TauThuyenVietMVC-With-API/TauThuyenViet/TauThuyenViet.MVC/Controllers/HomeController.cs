using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.Controllers
{
    public class HomeController : Controller
    {
        [Route("/", Name="Home")]
        public IActionResult Index()
        {
            ViewBag.Title = "Trang chủ";
            return View();
        }
    }
}
