using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var indexView = new IndexViewModel();
        indexView.FirstName = "Paul";
        indexView.LastName = "French";

        return View(indexView);
    }
    [HttpPost]
    public IActionResult Index(IndexViewModel viewModel)
    {
        var indexView = new IndexViewModel();
        indexView.FirstName = "Paul";
        indexView.LastName = "French";

        return View(indexView);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
