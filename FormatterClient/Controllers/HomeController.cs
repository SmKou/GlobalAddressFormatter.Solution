using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ActionResult Index()
    {
        List<Country> countries = Country.Test_Countries();
        if (countries != null)
            ViewBag.CountryCode = countries;
        AddressFormatter model = new AddressFormatter();
        return View(model);
    }

    public ActionResult Index(string code)
    {
        AddressFormatter model = new AddressFormatter
        {
            CountryCode = code
        };
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
