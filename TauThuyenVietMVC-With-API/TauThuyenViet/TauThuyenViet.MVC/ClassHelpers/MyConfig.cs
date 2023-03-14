using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TauThuyenViet.Models;

namespace TauThuyenViet.ClassHelpers
{
    public class MyConfig
    {
        private readonly HttpClient client;
        public MyConfig(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        public string GetConfigByKey(string key)
        {
            var response = client.GetAsync($"/api/Configs/{key}").Result;
            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
                return string.Empty;

            string json = response.Content.ReadAsStringAsync().Result;
            Config data = JsonConvert.DeserializeObject<Config>(json);

            if (data == null)
                return string.Empty;

            return data.Value;
        }
    }
}
