using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using TauThuyenViet.Models;

namespace TauThuyenViet.Controllers
{
    public class ArticleController : Controller
    {
        private readonly HttpClient client;
        public ArticleController(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        [Route("tin-tuc", Name="ArticleList")]
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Tin Tức";
            var response = await client.GetAsync("api/articles");
            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
                return View();
            string json = response.Content.ReadAsStringAsync().Result;
            List<Article> data = JsonConvert.DeserializeObject<List<Article>>(json);

            return View(data);
        }

        [Route("tin-tuc/{id}/{title}", Name="ArticleDetail")]
        public async Task<IActionResult> Detail(int id, string title)
        {
            var response = await client.GetAsync($"/api/Articles/{id}");
            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
                return View();
            string json = response.Content.ReadAsStringAsync().Result;
            Article data = JsonConvert.DeserializeObject<Article>(json);

            if (data == null)
            {
                ViewBag.Title = "404 - Dữ liệu không tồn tại | TauThuyenViet";

                Article defaultItem = new Article();
                defaultItem.Title = "404 - Dữ liệu không tồn tại";
                defaultItem.Description = "Dữ liệu bạn truy cập không còn tồn tại";
                defaultItem.Avatar = "/images/404.webp";
                defaultItem.Content = "Vui lòng click vào đây để <a href='/'>về trang chủ</a>";

                return View(defaultItem);
            }
            else
            {
                ViewBag.Title = data.Title + " | TauThuyenViet";
            }

            return View(data);
        }
    }
}
