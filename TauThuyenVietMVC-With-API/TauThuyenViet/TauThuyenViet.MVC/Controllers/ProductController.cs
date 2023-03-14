using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TauThuyenViet.ClassHelpers;
using System.Net.Http;
using Newtonsoft.Json;
using TauThuyenViet.Models;

namespace TauThuyenViet.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient client;
        public ProductController(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        [Route("san-pham/{mid?}/{cid?}/{title?}", Name="ProductList")]
        public async Task<IActionResult> Index(int? mid, int? cid, string title)
        {
            ViewBag.Title = "Sản phẩm | TauThuyenViet";

            if(mid == null)
                mid = 0;

            if(cid == null)
                cid = 0;

            var response = await client.GetAsync($"/api/Products/getlist/{mid}/{cid}");
            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
                return View();
            string json = response.Content.ReadAsStringAsync().Result;
            List<Product> data = JsonConvert.DeserializeObject<List<Product>>(json);

            return View(data);
        }

        [Route("san-pham/{id}/{title}", Name="ProductDetail")]
        public async Task<IActionResult> Detail(int id, string title)
        {
            var response = await client.GetAsync($"/api/Products/{id}");
            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
                return View();
            string json = response.Content.ReadAsStringAsync().Result;
            Product data = JsonConvert.DeserializeObject<Product>(json);

            if (data == null)
            {
                //Xử lý lỗi 404
            }
            else
            {
                ViewBag.Title = data.Title;
            }

            return View(data);
        }
    }
}
