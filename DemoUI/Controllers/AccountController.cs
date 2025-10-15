using DemoUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace DemoUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;

        public AccountController(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _config = config;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_config["ApiSettings:BaseUrl"]);

            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/authenticate/login", content);

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                string token = result.token;
                string username = result.username;
                string role = result.role;

                // Store token securely in session
                HttpContext.Session.SetString("JWToken", token);
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("UserRole", role);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
