using Microsoft.AspNetCore.Mvc;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.CountryCode = new SelectList(Country.GetCountries(), "CountryCode", "Name");
        return View();
    }

    public Task<ActionResult> Index()
}
