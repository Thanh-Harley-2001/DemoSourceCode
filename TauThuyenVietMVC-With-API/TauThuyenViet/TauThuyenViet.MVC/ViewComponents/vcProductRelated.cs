using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using System.Net.Http;
using TauThuyenViet.Models;
using Newtonsoft.Json;

namespace TauThuyenViet.ViewComponents
{
    public class vcProductRelated : ViewComponent
    {
        private readonly HttpClient client;
        public vcProductRelated(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        public async Task<IViewComponentResult> InvokeAsync(int categoryID, int ID)
        {
            var reponse = await client.GetAsync($"api/Products/related/{categoryID}/{ID}");

            if (reponse == null || reponse.StatusCode != System.Net.HttpStatusCode.OK) return View();

            var json = reponse.Content.ReadAsStringAsync().Result;

            List<Product> data = JsonConvert.DeserializeObject<List<Product>>(json);

            return View(data);
        }
    }
}
