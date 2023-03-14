using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TauThuyenViet.Models;

namespace TauThuyenViet.Controllers
{
    public class ContactController : Controller
    {
        private readonly HttpClient client;
        public ContactController(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("default");
        }

        [HttpGet]
        [Route("lien-he", Name="Contact")]
        public IActionResult Index()
        {
            ViewBag.Title = "Liên Hệ";
            ViewBag.MessageText = "Kính mời quý khách nhập thông tin liên hệ";
            ViewBag.MessageClass = "info";
            return View();
        }

        [HttpPost]
        [Route("lien-he", Name = "Contact")]
        public async Task<IActionResult> Index(Contact item)
        {
            //Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(item.FullName))
            {
                ViewBag.MessageText = "Mời quý khách nhập họ tên";
                ViewBag.MessageClass = "danger";
                return View();
            }

            if (string.IsNullOrEmpty(item.Mobi) && string.IsNullOrEmpty(item.Email))
            {
                ViewBag.MessageText = "Mời quý khách nhập số điện thoại hoặc email để liên lạc";
                ViewBag.MessageClass = "danger";
                return View();
            }

            if (string.IsNullOrEmpty(item.Content))
            {
                ViewBag.MessageText = "Mời quý khách nhập nội dung liên hệ";
                ViewBag.MessageClass = "danger";
                return View();
            }

            //Save vào DB
            item.CreateTime = DateTime.Now;
            item.Status = false;

            //Goi API
            string json = JsonConvert.SerializeObject(item);
            StringContent stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Contacts", stringContent);

            if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Báo lỗi
                ViewBag.MessageText = "Chưa gửi dữ liệu thành công. Vui lòng thử lại";
                ViewBag.MessageClass = "danger";
                return View();
            }

            //Xóa trắng Form
            ModelState.Clear();

            //Hiện thông báo
            ViewBag.MessageText = "Đã gửi thư liên hệ. Chúng tôi sẽ trả lời sớm, xin cảm ơn.";
            ViewBag.MessageClass = "success";

            return View();
        }
    }
}
