using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
	private IStoreRepository repository;

    public HomeController(ILogger<HomeController> logger, IStoreRepository repo)
    {
        _logger = logger;
		repository = repo;
    }

    public IActionResult Index()
    {
        return View(repository.Urunler);
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
