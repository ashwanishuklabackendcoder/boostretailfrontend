using DemoUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

public class ProductsController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public ProductsController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public IActionResult ProductsSearch()
    {

        return View();
    }
}
