using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using System.Net.Http;
using Newtonsoft.Json;
using TauThuyenViet.Models;

namespace TauThuyenViet.ViewComponents
{
    public class vcArticleRelated : ViewComponent
    {
        private readonly HttpClient client;
        public vcArticleRelated(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        public async Task<IViewComponentResult> InvokeAsync(int categoryID, int ID)
        {
            var response = await client.GetAsync($"api/Articles/related/{categoryID}/{ID}");
            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
                return View();
            string json = response.Content.ReadAsStringAsync().Result;
            List<Article> data = JsonConvert.DeserializeObject<List<Article>>(json);

            return View(data);
        }
    }
}
