using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.ViewComponents
{
    public class vcProductTab : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

            //var data = db.ProductMainCategories
            //             .Where(x => x.Status == true)
            //             .OrderBy(x => x.Position)
            //             .ToList();

            //return View(data);
        }
    }
}
