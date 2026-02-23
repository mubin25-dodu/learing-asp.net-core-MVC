using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practice_asp.Models;

namespace practice_asp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(int? id)
    {
        ViewBag.UserId = id;
        return View();
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
