using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Country> countries = Country.Test_GetCountries();
        ViewBag.CountryCode = new SelectList(countries, "CountryCode", "Name");
        return View();
    }

    public ActionResult Index(string code)
    {

    }

    private class AddressFormat
    {
        public string CountryCode { get; set; }
        public Dictionary<string, Format> Formats { get; set; }
        public string Pattern { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }
}
