using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.soduko;

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
      

        return View(indexView);
    }
    [HttpPost]
    public IActionResult Index(IndexViewModel viewModel)
    {
        var indexView = new IndexViewModel();
        var grid = new Grid();
        var Solution = grid.Solve(viewModel.SudokuProblem);
        this.TempData["Solution"] = Solution;



        return RedirectToAction("Solution");
    }

    [HttpGet]
    public IActionResult Solution()
    {
        var solutionView = new SolutionViewModel();
        solutionView.Solution = (string)this.TempData["Solution"];

        return View(solutionView);
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
