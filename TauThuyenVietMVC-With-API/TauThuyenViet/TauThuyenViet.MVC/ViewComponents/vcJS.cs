using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.ViewComponents
{
    public class vcJS : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
