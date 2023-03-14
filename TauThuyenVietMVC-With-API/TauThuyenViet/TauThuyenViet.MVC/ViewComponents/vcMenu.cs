using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TauThuyenViet.Models;

namespace TauThuyenViet.ViewComponents
{
    public class vcMenu : ViewComponent
    {
        private readonly HttpClient client;
        public vcMenu(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var reponse = await client.GetAsync("api/ProductMainCategories/NestedMenu");

            if (reponse == null || reponse.StatusCode != System.Net.HttpStatusCode.OK) return View();

            var json = reponse.Content.ReadAsStringAsync().Result;

            List<ProductMainCategory> data = JsonConvert.DeserializeObject<List<ProductMainCategory>>(json);

            return View(data);
        }
    }
}
