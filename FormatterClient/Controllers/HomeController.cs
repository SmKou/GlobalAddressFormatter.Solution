using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Country> countries = Country.Test_Countries();
        if (countries != null)
            ViewBag.CountryCode = new SelectList(countries, "CountryCode", "CountryName");
        return View();
    }

    public ActionResult SetCountry(AddressFormatter model)
    {
        List<Format> formats = Format.Test_Formats(model.CountryCode);
        if (formats != null)
        {
            model.Formats = new Dictionary<string, Format>();
            foreach (Format format in formats)
                model.Formats.Add(format.FormatName, format);
        }
        return View(model);
    }
}
